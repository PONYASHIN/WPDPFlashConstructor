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
            new Form2().Show();
        }
        void Button1_Click(object sender, EventArgs e)
        {
            string jj = comboBox1.Text.ToString().Remove(2);
            File.WriteAllBytes(".\\unarc.exe", Properties.Resources.unarc);
            Strings.ARC(".\\ARC\\osnova.bin", jj);
            Task.Delay(100000).Wait();
            if (WinPE10x64.Checked == true) WinPE10X64U();
            if (WinPE10x86.Checked == true) WinPE10X86U();
            if (WinPE81x64.Checked == true) WinPE81X64U();
            if (WinPE81x86.Checked == true) WinPE81X86U();
            if (Minstall.Checked == true) Strings.ARC(".\\ARC\\MInstall.bin", jj);
            if (MSDart10x64.Checked == true) MSDart10x64U();
            if (MSDart10x86.Checked == true) MSDart10x86U();
            if (MSDart81x64.Checked == true) MSDart81x64U();
            if (MSDart81x86.Checked == true) MSDart81x86U();
            if (MSDart7x64.Checked == true) MSDart7x64U();
            if (MSDart7x86.Checked == true) MSDart7x86U();
            if (DOS.Checked == true) DOSU();
            if (Acronis.Checked == true) AcronisU();
            if (Kaspersky.Checked == true) KasperskyU();
            if (W11.Checked == true) Windows11();
            if (W10x64.Checked == true) Windows10x64();
            if (W10X86.Checked == true) Windows10x86();
            if (W10LTSC2021.Checked == true) Windows10LTSC2021();
            if (W10LTSC2019.Checked == true) Windows10LTSC2019();
            if (W10LTSB.Checked == true) Windows10LTSB();
            if (W81X64.Checked == true) Windows81x64();
            if (W81X86.Checked == true) Windows81x86();
            if (W81IEIPX64.Checked == true) Windows81IEIPx64();
            if (W81IEIPX86.Checked == true) Windows81IEIPx86();
            if (W8.Checked == true) Windows8();
            if (W7X64.Checked == true) Windows7x64();
            if (W7X86.Checked == true) Windows7x86();
            if (XP.Checked == true) WindowsXP();
            if (Mint.Checked == true) LinuxMint();
            if (RemixOSx64.Checked == true) LinuxRemixOSx64();
            if (RemixOSx86.Checked == true) LinuxRemixOSx86();
            if (Ubuntu.Checked == true) LinuxUbuntu();
        }
        private void WinPEFiles_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        #region Checkboxes
        private void WinPe_1_CheckedChanged(object sender, EventArgs e)
        {
            if (WinPE_1.Checked == true)
            {
                WinPE10x64.Checked = true;
                WinPE10x86.Checked = true;
                WinPE81x64.Checked = true;
                WinPE81x86.Checked = true;
            }
            else
            {
                WinPE10x64.Checked = false;
                WinPE10x86.Checked = false;
                WinPE81x64.Checked = false;
                WinPE81x86.Checked = false;
            }
        }
        private void WinPE10x64_1_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 505;
            int op = Convert.ToInt32(label1.Text) + 505;
            label1.Text = WinPE10x64.Checked == true ? op.ToString() : ll.ToString();
        }
        private void WinPE10x86_1_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 352;
            int op = Convert.ToInt32(label1.Text) + 352;
            label1.Text = WinPE10x86.Checked == true ? op.ToString() : ll.ToString();
        }
        private void WinPE81x64_1_CheckedChanged(object sender, EventArgs e)
        { 
            int ll = Convert.ToInt32(label1.Text) - 157;
            int op = Convert.ToInt32(label1.Text) + 157;
            label1.Text = WinPE81x64.Checked == true ? op.ToString() : ll.ToString();
        }
        private void WinPE81x86_1_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 113;
            int op = Convert.ToInt32(label1.Text) + 113;
            label1.Text = WinPE81x86.Checked == true ? op.ToString() : ll.ToString();
        }
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
            int ll = Convert.ToInt32(label1.Text) - 264;
            int op = Convert.ToInt32(label1.Text) + 264;
            label1.Text = MSDart10x64.Checked == true ? op.ToString() : ll.ToString();
        }
        private void MSDart10x86_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 224;
            int op = Convert.ToInt32(label1.Text) + 224;
            label1.Text = MSDart10x86.Checked == true ? op.ToString() : ll.ToString();
        }
        private void MSDart81x64_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 360;
            int op = Convert.ToInt32(label1.Text) + 360;
            label1.Text = MSDart81x64.Checked == true ? op.ToString() : ll.ToString();
        }
        private void MSDart81x86_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 316;
            int op = Convert.ToInt32(label1.Text) + 316;
            label1.Text = MSDart81x86.Checked == true ? op.ToString() : ll.ToString();
        }
        private void MSDart7x64_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 156;
            int op = Convert.ToInt32(label1.Text) + 156;
            label1.Text = MSDart7x64.Checked == true ? op.ToString() : ll.ToString();
        }
        private void MSDart7x86_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 133;
            int op = Convert.ToInt32(label1.Text) + 133;
            label1.Text = MSDart7x86.Checked == true ? op.ToString() : ll.ToString();
        }
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
            int ll = Convert.ToInt32(label1.Text) - 660;
            int op = Convert.ToInt32(label1.Text) + 660;
            label1.Text = Acronis.Checked == true ? op.ToString() : ll.ToString();
        }
        private void Kaspersky_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 611;
            int op = Convert.ToInt32(label1.Text) + 611;
            label1.Text = Kaspersky.Checked == true ? op.ToString() : ll.ToString();
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
                XP.Checked = true;
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
                XP.Checked = false;
                BootWIMx64.Checked = false;
                BootWIMx86.Checked = false;
            }
        }
        private void W11_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 3477;
            int op = Convert.ToInt32(label1.Text) + 3477;
            if (W11.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx64.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void W10x64_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 3698;
            int op = Convert.ToInt32(label1.Text) + 3698;
            if (W10x64.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx64.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void W81X64_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 3449;
            int op = Convert.ToInt32(label1.Text) + 3449;
            if (W81X64.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx64.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void W81IEIPX64_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 3152;
            int op = Convert.ToInt32(label1.Text) + 3152;
            if (W81IEIPX64.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx64.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void W10LTSC2021_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 3946;
            int op = Convert.ToInt32(label1.Text) + 3946;
            if (W10LTSC2021.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx64.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void W10X86_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 2645;
            int op = Convert.ToInt32(label1.Text) + 2645;
            if (W10X86.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx86.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void W10LTSC2019_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 3334;
            int op = Convert.ToInt32(label1.Text) + 3334;
            if (W10LTSC2019.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx64.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void W10LTSB_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 2979;
            int op = Convert.ToInt32(label1.Text) + 2979;
            if (W10LTSB.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx64.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void W81X86_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 2608;
            int op = Convert.ToInt32(label1.Text) + 2608;
            if (W10X86.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx86.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void W81IEIPX86_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 2338;
            int op = Convert.ToInt32(label1.Text) + 2338;
            if (W81IEIPX86.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx86.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void W8_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 2614;
            int op = Convert.ToInt32(label1.Text) + 2614;
            if (W8.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx64.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void W7X64_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 1862;
            int op = Convert.ToInt32(label1.Text) + 1862;
            if (W7X64.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx64.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void W7X86_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 2138;
            int op = Convert.ToInt32(label1.Text) + 2138;
            if (W7X86.Checked == true)
            {
                label1.Text = op.ToString();
                BootWIMx86.Checked = true;
            }
            else label1.Text = ll.ToString();
        }
        private void BootWIMx64_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 978;
            int op = Convert.ToInt32(label1.Text) + 978;
            label1.Text = BootWIMx64.Checked == true ? op.ToString() : ll.ToString();
        }
        private void BootWIMx86_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 738;
            int op = Convert.ToInt32(label1.Text) + 738;
            label1.Text = BootWIMx86.Checked == true ? op.ToString() : ll.ToString();
        }
        private void XP_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 513;
            int op = Convert.ToInt32(label1.Text) + 513;
            label1.Text = XP.Checked == true ? op.ToString() : ll.ToString();
        }
        private void Minstall_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 865;
            int op = Convert.ToInt32(label1.Text) + 865;
            label1.Text = Minstall.Checked == true ? op.ToString() : ll.ToString();
        }
        private void DOS_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 6;
            int op = Convert.ToInt32(label1.Text) + 6;
            label1.Text = DOS.Checked == true ? op.ToString() : ll.ToString();
        }
        private void LS_CheckedChanged(object sender, EventArgs e)
        {
            if (LS.Checked == true)
            {
                Mint.Checked = true;
                RemixOSx64.Checked = true;
                RemixOSx86.Checked = true;
                Ubuntu.Checked = true;
            }
            if (LS.Checked == false)
            {
                Mint.Checked = false;
                RemixOSx64.Checked = false;
                RemixOSx86.Checked = false;
                Ubuntu.Checked = false;
            }
        }
        private void RemixOSx64_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 986;
            int op = Convert.ToInt32(label1.Text) + 986;
            label1.Text = RemixOSx64.Checked == true ? op.ToString() : ll.ToString();
        }
        private void RemixOSx86_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 1026;
            int op = Convert.ToInt32(label1.Text) + 1026;
            label1.Text = RemixOSx86.Checked == true ? op.ToString() : ll.ToString();
        }
        private void Ubuntu_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 3116;
            int op = Convert.ToInt32(label1.Text) + 3116;
            label1.Text = Ubuntu.Checked == true ? op.ToString() : ll.ToString();
        }
        private void Mint_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 2239;
            int op = Convert.ToInt32(label1.Text) + 2239;
            label1.Text = Mint.Checked == true ? op.ToString() : ll.ToString();
        }
        private void ADMPEX86_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 2002;
            int op = Convert.ToInt32(label1.Text) + 2002;
            label1.Text = ADMPEX86.Checked == true ? op.ToString() : ll.ToString();
        }
        private void XMPE_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 2992;
            int op = Convert.ToInt32(label1.Text) + 2992;
            label1.Text = XMPE.Checked == true ? op.ToString() : ll.ToString();
        }
        private void SSTR_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 4134;
            int op = Convert.ToInt32(label1.Text) + 4134;
            label1.Text = SSTR.Checked == true ? op.ToString() : ll.ToString();
        }
        private void SMBB_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 25112;
            int op = Convert.ToInt32(label1.Text) + 25112;
            label1.Text = SMBB.Checked == true ? op.ToString() : ll.ToString();
        }
        private void A2k10_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 6076;
            int op = Convert.ToInt32(label1.Text) + 6076;
            label1.Text = A2k10.Checked == true ? op.ToString() : ll.ToString();
        }
        private void ADMPEX64_CheckedChanged(object sender, EventArgs e)
        {
            int ll = Convert.ToInt32(label1.Text) - 1579;
            int op = Convert.ToInt32(label1.Text) + 1579;
            label1.Text = ADMPEX64.Checked == true ? op.ToString() : ll.ToString();
        }
        #endregion
        async void WinPE10X64U()
        { 
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinPE\\Win10PEx64.wim", jj+"\\WPDP\\Win10PEx64.wim",true); });
            Strings.MenuLineLegacy(jj+"WPDP\\BCD", "Win10PEx64");
            Strings.BOOTWIMlegacy(jj+"WPDP\\BCD", Strings.LegacyID, "WPDP\\Win10PEx64.wim");
            Strings.MenuLineEfi(jj, "WinPE10x64");
            Strings.BOOTWIMefi(jj, Strings.UEFIID, "WPDP\\Win10PEx64.wim");
        }
        async void WinPE10X86U()
        {
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinPE\\Win10PEx86.wim", jj+"\\WPDP\\Win10PEx86.wim", true); });
            Strings.MenuLineLegacy(jj + "WPDP\\BCD", "Win10PEx86");
            Strings.BOOTWIMlegacy(jj + "WPDP\\BCD", Strings.LegacyID, "WPDP\\Win10PEx86.wim");
        }
        async void WinPE81X64U()
        {
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinPE\\Win81PEx64.wim", jj + "\\WPDP\\Win81PEx64.wim", true); });
            Strings.MenuLineLegacy(jj + "WPDP\\BCD", "Win8.1PEx64");
            Strings.BOOTWIMlegacy(jj + "WPDP\\BCD", Strings.LegacyID, "WPDP\\Win81PEx64.wim");
            Strings.MenuLineEfi(jj, "WinPE8.1x64");
            Strings.BOOTWIMefi(jj, Strings.UEFIID, "WPDP\\Win81PEx64.wim");
        }
        async void WinPE81X86U()
        {
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinPE\\Win81PEx86.wim", jj + "\\WPDP\\Win81PEx86.wim", true); });
            Strings.MenuLineLegacy(jj + "WPDP\\BCD", "Win8.1PEx86");
            Strings.BOOTWIMlegacy(jj + "WPDP\\BCD", Strings.LegacyID, "WPDP\\Win81PEx86.wim");
        }
        void MSDARTBCDTEST()
        {
            string jj = comboBox1.Text.ToString().Remove(2);
            if (!File.Exists(jj + @"WPDP\Fonts\MSDART.LDR")) Strings.ARC(".\\ARC\\MsDart\\MSDartLoader.bin", jj);
            Strings.CheckBCD(jj+"WPDP\\BCD");
            if (!Strings.BCDINFO.Contains("MS-Dart"))
            {
                Strings.MenuLineGrub(jj + @"WPDP\BCD", "MS-Dart");
                Strings.BOOTGRUB(jj + @"WPDP\BCD", Strings.GRUBID, "WPDP\\Fonts\\MSDART.LDR");
            }
        }
        async void MSDart10x64U()
        {
            MSDARTBCDTEST();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\MsDart\\ERD10X64.wim", jj + "\\WPDP\\MSDart\\ERD10X64.wim", true); });
            Strings.MenuLineLegacy(jj + "WPDP\\Fonts\\MSD", "MS-Dart10x64");
            Strings.BOOTWIMlegacy(jj + "WPDP\\Fonts\\MSD",  Strings.LegacyID, "WPDP\\MSDart\\ERD10x64.wim");
        }
        async void MSDart10x86U()
        {
            MSDARTBCDTEST();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\MsDart\\ERD10X86.wim", jj + "\\WPDP\\MSDart\\ERD10X86.wim", true); });
            Strings.MenuLineLegacy(jj + "WPDP\\Fonts\\MSD", "MS-Dart10x86");
            Strings.BOOTWIMlegacy(jj + "WPDP\\Fonts\\MSD", Strings.LegacyID, "WPDP\\MSDart\\ERD10x86.wim");
        }
        async void MSDart81x64U()
        {
            MSDARTBCDTEST();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\MsDart\\ERD81X64.wim", jj + "\\WPDP\\MSDart\\ERD81X64.wim", true); });
            Strings.MenuLineLegacy(jj + "WPDP\\Fonts\\MSD", "MS-Dart8.1x64");
            Strings.BOOTWIMlegacy(jj + "WPDP\\Fonts\\MSD", Strings.LegacyID, "WPDP\\MSDart\\ERD81x64.wim");
        }
        async void MSDart81x86U()
        {
            MSDARTBCDTEST();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\MsDart\\ERD81X86.wim", jj + "\\WPDP\\MSDart\\ERD81X86.wim", true); });
            Strings.MenuLineLegacy(jj + "WPDP\\Fonts\\MSD", "MS-Dart8.1x86");
            Strings.BOOTWIMlegacy(jj + "WPDP\\Fonts\\MSD", Strings.LegacyID, "WPDP\\MSDart\\ERD81x86.wim");
        }
        async void MSDart7x64U()
        {
            MSDARTBCDTEST();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\MsDart\\ERD7X64.wim", jj + "\\WPDP\\MSDart\\ERD7X64.wim", true); });
            Strings.MenuLineLegacy(jj + "WPDP\\Fonts\\MSD", "MS-Dart7x64");
            Strings.BOOTWIMlegacy(jj + "WPDP\\Fonts\\MSD", Strings.LegacyID, "WPDP\\MSDart\\ERD7x64.wim");
        }
        async void MSDart7x86U()
        {
            MSDARTBCDTEST();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\MsDart\\ERD7X86.wim", jj + "\\WPDP\\MSDart\\ERD7X86.wim", true); });
            Strings.MenuLineLegacy(jj + "WPDP\\Fonts\\MSD", "MS-Dart7x86");
            Strings.BOOTWIMlegacy(jj + "WPDP\\Fonts\\MSD", Strings.LegacyID, "WPDP\\MSDart\\ERD7x86.wim");
        }
        async void AcronisU()
        {
            string jj = comboBox1.Text.ToString().Remove(2);
            Grub4DosT();
            await Task.Run(() => { File.Copy(".\\Arc\\Linux\\Acronis.iso", jj + "\\WPDP\\Linux\\RESCUE\\AcronisDVD.iso", true); });
        }
        async void KasperskyU()
        {
            string jj = comboBox1.Text.ToString().Remove(2);
            Grub4DosT();
            await Task.Run(() => { File.Copy(".\\Arc\\Linux\\krd.iso", jj + "\\WPDP\\Linux\\RESCUE\\krd.iso", true); });
        }
        async void WindowsInstallerWimX64()
        {
            string jj = comboBox1.Text.ToString().Remove(2);
            if (!File.Exists(jj + @"WPDP\WALLSx64\Boot.wim")) await Task.Run(() => { Process pros = Process.Start(new ProcessStartInfo { FileName = "unarc.exe", Arguments = "x .\\ARC\\WinSetup\\BOOTx64.bin -dp" + jj + " -o+"}); pros.WaitForExit();});
            Strings.CheckBCD(jj + @"WPDP\BCD");
            if (!Strings.BCDINFO.Contains("Windows Setup 7-11 x64"))
            {
                Strings.MenuLineLegacy(jj + "WPDP\\BCD", '\u0022' + "Windows Setup 7-11 x64" + '\u0022');
                Strings.BOOTWIMlegacy(jj + "WPDP\\BCD", Strings.LegacyID, "WPDP\\WALLSx64\\boot.wim");
                //Strings.MenuLineEfi(jj, '\u0022' + "Windows Setup 7-11 x64" + '\u0022');
                //Strings.BOOTWIMefi(jj, Strings.UEFIID, "WPDP\\WALLSx64\\boot.wim");
            }
        }
        async void WindowsInstallerWimX86()
        {
            string jj = comboBox1.Text.ToString().Remove(2);
            if (!File.Exists(jj + @"WPDP\WALLSx86\Boot.wim")) await Task.Run(() => { Process pros = Process.Start(new ProcessStartInfo { FileName = "unarc.exe", Arguments = "x .\\ARC\\WinSetup\\BOOTx86.bin -dp" + jj + " -o+" }); pros.WaitForExit(); });
            Strings.CheckBCD(jj + "WPDP\\BCD");
            if (!Strings.BCDINFO.Contains("Windows Setup 7-11 x86"))
            {
                Strings.MenuLineLegacy(jj + "WPDP\\BCD", '\u0022' + "Windows Setup 7-10 x86" + '\u0022');
                Strings.BOOTWIMlegacy(jj + "WPDP\\BCD", Strings.LegacyID, "WPDP\\WALLSx86\\boot.wim");
            }
        }
        async void Windows11()
        {
            WindowsInstallerWimX64();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x64\\Win11.esd", jj + "\\WPDP\\WALLSx64\\Win11.esd", true); });
        }
        async void Windows10x64()
        {
            WindowsInstallerWimX64();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x64\\Win10x64.esd", jj + "\\WPDP\\WALLSx64\\Win10x64.esd", true); });
        }
        async void Windows10x86()
        {
            WindowsInstallerWimX86();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x86\\Win10x86.esd", jj + "\\WPDP\\WALLSx86\\Win10x86.esd", true); });
        }
        async void Windows10LTSC2019()
        {
            WindowsInstallerWimX64();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x64\\Win10LTSC2019.esd", jj + "\\WPDP\\WALLSx64\\Win10LTSC2019.esd", true); });
        }
        async void Windows10LTSC2021()
        {
            WindowsInstallerWimX64();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x64\\Win10LTSC2021.esd", jj + "\\WPDP\\WALLSx64\\Win10LTSC2021.esd", true); });
        }
        async void Windows10LTSB()
        {
            WindowsInstallerWimX64();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x64\\Win10LTSB.esd", jj + "\\WPDP\\WALLSx64\\Win10LTSB.esd", true); });
        }
        async void Windows81x64()
        {
            WindowsInstallerWimX64();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x64\\Win81x64.esd", jj + "\\WPDP\\WALLSx64\\Win81x64.esd", true); });
        }
        async void Windows81x86()
        {
            WindowsInstallerWimX86();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x86\\Win81x86.esd", jj + "\\WPDP\\WALLSx86\\Win81x86.esd", true); });
        }
        async void Windows81IEIPx64()
        {
            WindowsInstallerWimX64();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x64\\Win81IE_IPIE_IPx64.esd", jj + "\\WPDP\\WALLSx64\\Win81IE_IPx64.esd", true); });
        }
        async void Windows81IEIPx86()
        {
            WindowsInstallerWimX86();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x64\\Win81IE_IPx64.esd", jj + "\\WPDP\\WALLSx64\\Win81IE_IPx64.esd", true); });
        }
        async void Windows8()
        {
            WindowsInstallerWimX64();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x64\\Win8.esd", jj + "\\WPDP\\WALLSx64\\Win8.esd", true); });
        }
        async void Windows7x64()
        {
            WindowsInstallerWimX64();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x64\\Win7x64.esd", jj + "\\WPDP\\WALLSx64\\Win7x64.esd", true); });
        }
        async void Windows7x86()
        {
            WindowsInstallerWimX86();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x86\\Win7x86.esd", jj + "\\WPDP\\WALLSx86\\Win7x86.esd", true); });
        }
        async void WindowsXP()
        {
            string jj = comboBox1.Text.ToString().Remove(2);
            if (!File.Exists(jj + @"WPDP\WALLSx86\WinXPPro.iso"))
            {
                await Task.Run(() => { File.Copy(".\\Arc\\WinSetup\\x86\\WinXPPro.iso", jj + "\\WPDP\\WALLSx86\\WinXPPro.iso", true); });
                Strings.ARC(".\\Arc\\WinSetup\\x86\\XPBoot.bin", jj);
            }
            Strings.CheckBCD(jj + "WPDP\\BCD");
            if (!Strings.BCDINFO.Contains("Windows XP Setup"))
            {
                Strings.MenuLineLegacy(jj + "WPDP\\BCD", '\u0022' + "Windows XP Setup" + '\u0022');
                Strings.BOOTGRUB(jj + "WPDP\\BCD", Strings.GRUBID, "\\WPDP\\Fonts\\XP");
             }
        }
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
            File.Delete(".\\dsk.txt");
        }
        void DOSU()
        {
            Grub4DosT();
            string jj = comboBox1.Text.ToString().Remove(2);
            Strings.ARC(".\\ARC\\DOS.bin", jj);
        }
        void Grub4DosT()
        {
            string jj = comboBox1.Text.ToString().Remove(2);
            if (!File.Exists(jj + @"WPDP\Fonts\grldr")) Strings.ARC(".\\ARC\\Grub4Dos.bin", jj);
            Strings.CheckBCD(jj + "WPDP\\BCD");
            if (!Strings.BCDINFO.Contains("Grub4Dos"))
            {
                Strings.MenuLineGrub(jj + "WPDP\\BCD", "Grub4Dos");
                Strings.BOOTGRUB(jj + "WPDP\\BCD", Strings.GRUBID, "WPDP\\Fonts\\grldr");
            }
        }
        async void LinuxMint()
        {
            LinuxTest();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\Linux\\linuxmint.iso", jj + "\\WPDP\\Linux\\INSTALLERS\\linuxmint.iso", true); });
        }
        async void LinuxRemixOSx64()
        {
            LinuxTest();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\Linux\\Remix_OS_64bit.iso", jj + "\\WPDP\\Linux\\INSTALLERS\\RemixOS\\Remix_OS_64bit.iso", true); });
        }
        async void LinuxRemixOSx86()
        {
            LinuxTest();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\Linux\\Remix_OS_32bit.iso", jj + "\\WPDP\\Linux\\INSTALLERS\\RemixOS\\Remix_OS_32bit.iso", true); });
        }
        async void LinuxUbuntu()
        {
            LinuxTest();
            string jj = comboBox1.Text.ToString().Remove(2);
            await Task.Run(() => { File.Copy(".\\Arc\\Linux\\ubuntu.iso", jj + "\\WPDP\\Linux\\INSTALLERS\\ubuntu.iso", true); });
        }
        void LinuxTest()
        {
            string jj = comboBox1.Text.ToString().Remove(2);
            if (!File.Exists(jj + @"WPDP\Fonts\Linux")) Strings.ARC(".\\ARC\\Linux\\Boot.bin", jj);
            Strings.CheckBCD(jj + "WPDP\\BCD");
            if (!Strings.BCDINFO.Contains("LinuxSetup"))
            {
                Strings.MenuLineGrub(jj + "WPDP\\BCD", '\u0022' + "Linux Setup" + '\u0022');
                Strings.BOOTGRUB(jj + "WPDP\\BCD", Strings.GRUBID, "\\WPDP\\fonts\\Linux");
            }
        }
    }
}