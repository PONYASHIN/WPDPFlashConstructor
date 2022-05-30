using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;

namespace WPDP_Flash_Constructor
{
    public partial class Form2 : Form
    {
        #region Инициализе
        public Form2()
        {
            InitializeComponent();
            Disk();
            Lang();
            if (Strings.Btn != "true") if (File.Exists(".\\Arc\\osnova.bin")) button6.Enabled = true;
            if (Strings.Btn == "true") button6.Enabled = true;
        }
        #endregion
        public static string warning1;
        public static string warning2;
        #region Старт
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                DialogResult fd = MessageBox.Show(warning1,warning2,MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (fd == DialogResult.OK)
                {
                    Progress();
                    if (radioButton1.Checked == true)
                    {
                        Legacy();
                        BootMGR();
                    }
                    if (radioButton2.Checked == true)
                    {
                        if (checkBox1.Checked == false)
                        {
                            UEFI();
                            BootMGR();
                        }
                        if (checkBox1.Checked == true)
                        {
                            UEFI2PTN();
                            BootMGR();
                        }
                    }
                }
            }
        }
        #endregion
        string ptn2 = "diskpart.txt";
        #region Легаси
        void Legacy()
        {
            string[] ptns = { "sel disk " + comboBox1.SelectedIndex,
                             "clean",
                             "create part pri",
                             "FORMAT FS=NTFS LABEL=WPDP_Flash QUICK",
                             "assign letter=W",
                             "active"};
            File.Create(ptn2).Close();
            File.WriteAllLines(ptn2, ptns);
            Process process2 = Process.Start(new ProcessStartInfo
            {
                FileName = "diskpart.exe",
                Arguments = "/s " + ptn2,
                UseShellExecute = false,
                CreateNoWindow = true
            });
        }
        #endregion
        #region Уефи
        void UEFI()
        {
            string[] ptn = { "sel disk " + comboBox1.SelectedIndex,
                             "clean",
                             "create part pri",
                             "FORMAT FS=NTFS LABEL=WPDP_Flash QUICK",
                             "assign letter=W",
                             "active"};
            File.Create(ptn2).Close();
            File.WriteAllLines(ptn2, ptn);
            File.WriteAllBytes(".\\fat32format.exe", Properties.Resources.fat32format);
            Process process2 = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c diskpart /s " + ptn2 + " & " + ".\\fat32format.exe -lWPDP_Flash -y W:",
                UseShellExecute = false,
                CreateNoWindow = true
            });
            process2.WaitForExit();
        }
        #endregion
        #region Уефи 2 раздела
        void UEFI2PTN()
        {
            string[] ptn = { "sel disk " + comboBox1.SelectedIndex,
                             "clean",
                             "create part pri size=131072",
                             "FORMAT FS=NTFS LABEL=WPDP_Flesh QUICK",
                             "assign letter=W",
                             "active",
                             "create part pri",
                             "FORMAT FS=NTFS LABEL=UserFiles QUICK",
                             "assign"};
            File.Create(ptn2).Close();
            File.WriteAllLines(ptn2, ptn);
            File.WriteAllBytes(".\\fat32format.exe", Properties.Resources.fat32format);
            Process process2 = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c diskpart /s " + ptn2 + " & " + ".\\fat32format.exe -lWPDP_Flash -y W:",
                UseShellExecute = false,
                CreateNoWindow = true
            });
            process2.WaitForExit();
            File.Delete(ptn2);
        }
        #endregion
        void BootMGR()
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c c:\\windows\\system32\\bootsect.exe /nt60 w:",
                UseShellExecute = false,
                CreateNoWindow = true
            });
            process.WaitForExit();
        }
        #region Проверка дисков
        void Disk()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\Microsoft\\Windows\\Storage", "SELECT * FROM MSFT_PhysicalDisk");
            int d = 1024;
            foreach (ManagementObject queryObj in searcher.Get())
            {
                label2.Text += "DRIVE";
                label2.Text += queryObj["DeviceId"];
                label2.Text += " ";
                label2.Text += queryObj["Manufacturer"];
                label2.Text += " ";
                label2.Text += queryObj["Model"];
                label2.Text += " ";
                long b = Convert.ToInt64(queryObj["Size"]);
                if (b > 8)
                {
                    var dev = b / d;
                    if (dev > 1024)
                    {
                        var dev2 = dev / d;
                        if (dev2 > 1024)
                        {
                            var dev3 = dev2 / d;
                            label2.Text += dev3 + "(GB)";
                        }
                    }
                }
                label2.Text += Environment.NewLine;
            }
            File.Create(".\\1.txt").Close();
            File.WriteAllText(".\\1.txt", label2.Text);
            string[] lines = File.ReadAllLines(".\\1.txt");
            foreach (string line in lines) if (line.Contains("DRIVE")) comboBox1.Items.Add(line);
            File.Delete(".\\1.txt");
        }
        #endregion
        #region Софт
        async private void Button2_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                File.WriteAllBytes("BOOTICE.exe", Properties.Resources.BOOTICE);
                Process bt = Process.Start(new ProcessStartInfo { FileName = "Bootice.exe" });
                bt.WaitForExit();
                File.Delete("bootice.exe");
            });
        }
        async private void Button3_Click(object sender, EventArgs e) => await Task.Run(() => {Process.Start(new ProcessStartInfo { FileName = @"C:\Windows\System32\diskmgmt.msc" });});
        #endregion
        #region Ссылки
        private void PictureBox1_Click(object sender, EventArgs e) => Process.Start("https://github.com/DmitryPonyn/WPDPFlashConstructor");
        private void PictureBox2_Click(object sender, EventArgs e) => Process.Start("https://vk.com/dimamusor8");
        private void PictureBox5_Click(object sender, EventArgs e) => Process.Start("https://www.youtube.com/channel/UCwra73M3uB3c3oTF53B6qWA");
        #endregion
        #region Языки
        void Lang()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\WPDP_Flash_Constructor");
            if (key?.GetValue("Lang").ToString() == "Russian") Russian();
            if (key?.GetValue("Lang").ToString() == "") English();
        }
        void Russian()
        {
            comboBox1.Text = "1.Выбери диск";
            button1.Text = "2.Старт";
            groupBox1.Text = "Стиль разметки";
            checkBox1.Text = "2 раздел";
            button6.Text = "Файлы для сборника";
            warning2 = "Предупреждение";
            warning1 = "Как только ты нажмёшь ОК твои файлы на выбранном диске улетят в бездну поэтому смотри внимательнее.";
            ToolTip toolTip = new ToolTip { ShowAlways = true };
            toolTip.SetToolTip(this.pictureBox1, "Мой Github(на случай если хочешь обновить)");
            toolTip.SetToolTip(this.pictureBox2, "Мой VK(Поддержка)");
            toolTip.SetToolTip(this.pictureBox3, "Translate to English");
            toolTip.SetToolTip(this.pictureBox4, "Перевести на Русский");
            toolTip.SetToolTip(this.pictureBox5, "Мой ютюб(Разные видеки)");
            toolTip.SetToolTip(this.button2, "Программа для редактирования загрузчика");
            toolTip.SetToolTip(this.button3, "Программа для редактирования разделов");
        }
        void English()
        {
            comboBox1.Text = "1.Select disk";
            button1.Text = "2.Start";
            groupBox1.Text = "Partition style";
            checkBox1.Text = "2 part";
            button6.Text = "Files for compilation";
            ToolTip toolTip = new ToolTip { ShowAlways = true };
            toolTip.SetToolTip(this.pictureBox1, "My Github(if you want update)");
            toolTip.SetToolTip(this.pictureBox2, "My VK(support)");
            toolTip.SetToolTip(this.pictureBox3, "Translate to English");
            toolTip.SetToolTip(this.pictureBox4, "Перевести на Русский");
            toolTip.SetToolTip(this.pictureBox5, "My Youtube(Various videos)");
            toolTip.SetToolTip(this.button2, "Bootloader editing program");
            toolTip.SetToolTip(this.button3, "Partition editor program");
        }
        private void PictureBox4_Click(object sender, EventArgs e) => Russian();
        private void PictureBox3_Click(object sender, EventArgs e) => English();
        #endregion
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox1.Checked = false;
        }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e) => checkBox1.Enabled = true;
        async void Progress()
        {
            progressBar1.Visible = true;
            while (progressBar1.Value != 100)
            {
                progressBar1.Value++;
                await Task.Delay(50);
            }
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        public void Button6_Click(object sender, EventArgs e)
        {
            Hide();
            WinPEFiles b = new WinPEFiles();
            b.ShowDialog();
        }
    }
}