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
            string[] lines = File.ReadAllLines(@".\tools\1.txt");
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c .\\tools\\bootice.exe /diskinfo /list: list disks /file=1.txt",
                CreateNoWindow = true,
                UseShellExecute = false
            });
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
                MessageBox.Show("ты выбрал " + comboBox1.SelectedIndex);
            }
        }
    }
}
