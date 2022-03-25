using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WPDP_Flash_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 b = new Form2();
            b.ShowDialog();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c taskkill /im WPDP_Flash_Constructor.exe",
                UseShellExecute = false,
                CreateNoWindow = true
            });
        }
    }
}
