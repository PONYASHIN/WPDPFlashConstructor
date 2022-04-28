using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WPDP_Flash_Constructor
{
    public partial class WinPEFiles : Form
    {
        public WinPEFiles()
        {
            InitializeComponent();
            Disk();
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 b = new Form2();
            b.ShowDialog();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            LoadUnpack();
        }
        void LoadUnpack()
        {
            File.WriteAllBytes(".\\7z.exe", Properties.Resources._7zexe);
            File.WriteAllBytes(".\\7z.dll", Properties.Resources._7zdll);
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = ".\\7z.exe",
                Arguments = "x osnova.7z -oW:\\",
                CreateNoWindow = true,
                UseShellExecute = false
            });
            process.WaitForExit();
            File.Delete(".\\7z.exe");
            File.Delete(".\\7z.dll");
        }
        private void WinPEFiles_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        #region WinPE
        private void WinPe_1_CheckedChanged(object sender, EventArgs e)
        {
            if (WinPE_1.Checked == true)
            {
                WinPE10x64_1.Checked = true;
                WinPE10x86_1.Checked = true;
                WinPE81x64_1.Checked = true;
                WinPE81x86_1.Checked = true;
                WinPE7x86_1.Checked = true;
            }
            else
            {
                WinPE10x64_1.Checked = false;
                WinPE10x86_1.Checked = false;
                WinPE81x64_1.Checked = false;
                WinPE81x86_1.Checked = false;
                WinPE7x86_1.Checked = false;
            }
        }
        private void WinPE10x64_1_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 505;
            int op = lb + 505;
            if (WinPE10x64_1.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void WinPE10x86_1_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 352;
            int op = lb + 352;
            if (WinPE10x86_1.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void WinPE81x64_1_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 157;
            int op = lb + 157;
            if (WinPE81x64_1.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void WinPE81x86_1_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 113;
            int op = lb + 113;
            if (WinPE81x86_1.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();

        }
        private void WinPE7x86_1_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 101;
            int op = lb + 101;
            if (WinPE7x86_1.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        #endregion
        #region MS-Dart
        private void MSDART_CheckedChanged(object sender, EventArgs e)
        {
            if (MSDART.Checked == true)
            {
                MSDart10x64.Checked = true;
                MSDart10x86.Checked = true;
                MSDart81x64.Checked = true;
                MSDart81x86.Checked = true;
                MSDart7x64.Checked = true;
                MSDart7x86.Checked = true;
            }
            else
            {
                MSDart10x64.Checked = false;
                MSDart10x86.Checked = false;
                MSDart81x64.Checked = false;
                MSDart81x86.Checked = false;
                MSDart7x64.Checked = false;
                MSDart7x86.Checked = false;

            }
        }
        private void MSDart10x64_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 264;
            int op = lb + 264;
            if (MSDart10x64.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void MSDart10x86_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 224;
            int op = lb + 224;
            if (MSDart10x86.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void MSDart81x64_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 360;
            int op = lb + 360;
            if (MSDart81x64.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void MSDart81x86_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 316;
            int op = lb + 316;
            if (MSDart81x86.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void MSDart7x64_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 156;
            int op = lb + 156;
            if (MSDart7x64.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void MSDart7x86_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 133;
            int op = lb + 133;
            if (MSDart7x86.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        #endregion
        #region LinuxR
        private void LinuxRescue_CheckedChanged(object sender, EventArgs e)
        {
            if (LinuxRescue.Checked == true)
            {
                Acronis.Checked = true;
                Kaspersky.Checked = true;
            }
            else
            {
                Acronis.Checked = false;
                Kaspersky.Checked = false;
            }
        }
        private void Acronis_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 660;
            int op = lb + 660;
            if (Acronis.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void Kaspersky_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 611;
            int op = lb + 611;
            if (Kaspersky.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        #endregion
        #region WinSetup
        private void W11_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 3477;
            int op = lb + 3477;
            if (W11.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void W10x64_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 3698;
            int op = lb + 3698;
            if (W10x64.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void W81X64_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 3449;
            int op = lb + 3449;
            if (W81X64.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void W81IEIPX64_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 3152;
            int op = lb + 3152;
            if (W81IEIPX64.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void W10LTSC2021_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 3946;
            int op = lb + 3946;
            if (W10LTSC2021.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void W10X86_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 2645;
            int op = lb + 2645;
            if (W10X86.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void W10LTSC2019_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 3334;
            int op = lb + 3334;
            if (W10LTSC2019.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void WinS_CheckedChanged(object sender, EventArgs e)
        {
            if (WinS.Checked == true)
            {
                W11.Checked = true;
                W10x64.Checked = true;
                W10X86.Checked = true;
                W10LTSC2021.Checked = true;
                W10LTSC2019.Checked = true;
                W10LTSB.Checked = true;
                W81X64.Checked = true;
                W81X86.Checked = true;
                W81IEIPX64.Checked = true;
                W81IEIPX86.Checked = true;
                W8.Checked = true;
                W7X64.Checked = true;
                W7X86.Checked = true;
            }
            else
            {
                W11.Checked = false;
                W10x64.Checked = false;
                W10X86.Checked = false;
                W10LTSC2021.Checked = false;
                W10LTSC2019.Checked = false;
                W10LTSB.Checked = false;
                W81X64.Checked = false;
                W81X86.Checked = false;
                W81IEIPX64.Checked = false;
                W81IEIPX86.Checked = false;
                W8.Checked = false;
                W7X64.Checked = false;
                W7X86.Checked = false;
            }
        }
        private void W10LTSB_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 2979;
            int op = lb + 2979;
            if (W10LTSB.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void W81X86_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 2608;
            int op = lb + 2608;
            if (W10X86.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void W81IEIPX86_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 2338;
            int op = lb + 2338;
            if (W81IEIPX86.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void W8_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 2614;
            int op = lb + 2614;
            if (W8.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void W7X64_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 1862;
            int op = lb + 1862;
            if (W7X64.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void W7X86_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 2138;
            int op = lb + 2138;
            if (W7X86.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        #endregion
        #region ect
        void Disk()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                label3.Text += $"{drive.Name}";
                label3.Text += $" {drive.AvailableFreeSpace / 1024 / 1024} MB Free";
                label3.Text += Environment.NewLine;
            }
            File.Create(".\\dsk.txt").Close();
            File.WriteAllText(".\\dsk.txt", label3.Text);
            string[] lines = File.ReadAllLines(".\\dsk.txt");
            foreach (string line in lines) if (line.Contains("MB")) comboBox1.Items.Add(line);
            comboBox1.Sorted = true;
        }
        #endregion
        private void Minstall_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 865;
            int op = lb + 865;
            if (Minstall.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void DOS_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 6;
            int op = lb + 6;
            if (DOS.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
        private void SDI_CheckedChanged(object sender, EventArgs e)
        {
            int lb = Convert.ToInt32(label1.Text);
            int ll = lb - 14874;
            int op = lb + 14874;
            if (SDI.Checked == true) label1.Text = op.ToString();
            else label1.Text = ll.ToString();
        }
    }
}
