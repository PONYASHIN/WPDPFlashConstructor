using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WPDP_Flash_Constructor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c .\\tools\\bootice.exe /diskinfo /list: list disks /file=.\\tools\\1.txt",
                CreateNoWindow = true,
                UseShellExecute = false
            });
            process.WaitForExit();
            string[] lines = File.ReadAllLines(@".\tools\1.txt");
            foreach (string line in lines)
                if (line.Contains("DRIVE"))
                    comboBox1.Items.Add(line);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                Process process2 = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c .\\tools\\USBPREP.exe DRIVE=" + comboBox1.SelectedIndex + " clean & .\\tools\\USBPREP.exe DRIVE=" + comboBox1.SelectedIndex + " VISTA FORCELBA " +
                    "& .\\tools\\USBPREP.exe DRIVE=" + comboBox1.SelectedIndex + " volume=WPDP_USB & .\\tools\\BOOTICE.exe /DEVICE=" + comboBox1.SelectedIndex +
                    ":0 /partitions /activate /assign_letter=W",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
                process2.WaitForExit();
                MessageBox.Show("Этап завершён.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c taskkill /im WPDP_Flash_Constructor.exe & taskkill /im WPDP_Flash_Constructor.exe",
                UseShellExecute = false,
                CreateNoWindow = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c .\\tools\\7z.exe x osnova.7z -oW:\\ & .\\tools\\7z.exe x ws.7z -oW:\\",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
                MessageBox.Show("Операция успешно завершена");
            }
            else
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c .\\tools\\7z.exe x osnova.7z -oW:\\",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
                MessageBox.Show("Операция успешно завершена");
            }
        }
    }
}
