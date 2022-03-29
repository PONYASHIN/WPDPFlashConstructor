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
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                Process process2 = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c .\\tools\\USBPREP.exe DRIVE=" + comboBox1.SelectedIndex + " VISTA FORCELBA fat32"+ ".\\tools\\USBPREP.exe DRIVE=" + comboBox1.SelectedIndex + " VOLUME=WPDP_Flesh" + 
                    "& .\\tools\\BOOTICE.exe /DEVICE=" + comboBox1.SelectedIndex + ":0 /partitions /activate" + "& .\\tools\\BOOTICE.exe /DEVICE=" + comboBox1.SelectedIndex + 
                    ":0 /partitions /delete_letter" + "& .\\tools\\BOOTICE.exe /DEVICE=" + comboBox1.SelectedIndex + ":0 /partitions /assign_letter=W",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
                process2.WaitForExit();
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            File.Delete(@".\tools\1.txt");
        }
    }
}
