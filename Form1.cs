using Microsoft.Win32;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace WPDP_Flash_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lang();
            string[] skip = Environment.GetCommandLineArgs();
            foreach (string s in skip) if (s.Contains("skiptest")) Strings.Btn = "true";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().Show();
        }
        private void Button2_Click(object sender, EventArgs e) => Application.Exit();
        RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\WPDP_Flash_Constructor");
        void Russian()
        {
            key.SetValue("Lang", "Russian");
            this.Text = "Предупреждение";
            button1.Text = "ОК";
            button2.Text = "Отмена";
            label1.Text = "Это программа для подготовки флешки под мой сборник WinPE.\n" +
                          "Если есть баг программы то я пишите мне в ВК или в комментарии\n" +
                          "на ютюбе.";
        }
        void English()
        {
            key.SetValue("Lang", "");
            this.Text = "Warning";
            button1.Text = "OK";
            button2.Text = "Cancel";
            label1.Text = "This is a program for preparing a flash drive for my WinPE build. If there is\n" +
                          "a program bug, then I write to me in VK or in a comment on YouTube.";
        }
        void Lang()
        {
            CultureInfo lang = CultureInfo.CurrentCulture;
            key.SetValue("Lang", lang.Name == "ru-RU" ? "Russian" : "");
            if (key?.GetValue("Lang").ToString() == "Russian") Russian();
            if (key?.GetValue("Lang").ToString() == "") English();
        }
        private void PictureBox4_Click(object sender, EventArgs e) => Russian();
        private void PictureBox3_Click(object sender, EventArgs e) => English();
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Registry.CurrentUser.DeleteSubKey("SOFTWARE\\WPDP_Flash_Constructor");
        }
    }
}
