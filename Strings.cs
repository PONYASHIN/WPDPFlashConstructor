using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace WPDP_Flash_Constructor
{
    public class Strings
    {
        public static string Btn;
        async public static void ARC(string file, string pathtounpack)
        {
            await Task.Run(() => {
                Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = ".\\unarc.exe",
                    Arguments = "x " + file + " -dp" + pathtounpack + " -o+"
                });
                process.WaitForExit();
            });
        }
        public static void FileCopy(string file, string dest) => File.Copy(file, dest);
        public static string LegacyID;
        public static void MenuLineLegacy(string pathtobcd, string name)
        {
            Process LG = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c bcdedit /store " + pathtobcd + " /create /d "+ name +" /application osloader",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });
            LG.WaitForExit();
            Strings.LegacyID = LG.StandardOutput.ReadToEnd().Remove(0, 10).Remove(38);
        }
        public static string UEFIID;
        public static void MenuLineEfi(string disk, string name)
        {
            Process LG = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c bcdedit /store " + disk + "efi\\microsoft\\boot\\BCD /create /d "+ name +" /application osloader",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });
            LG.WaitForExit();
            Strings.UEFIID = LG.StandardOutput.ReadToEnd().Remove(0, 10).Remove(38);
        }
        async public static void BOOTWIMlegacy(string pathbcd, string id, string file)
        {
            await Task.Run(() => {
                Process processg = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c bcdedit /store " + pathbcd + " /set " + id + " device RAMDISK=[boot]\\" + file + ",{ramdiskoptions} & " +
                    "bcdedit /store " + pathbcd + " /set " + id + " osdevice RAMDISK=[boot]\\" + file + ",{ramdiskoptions} & " +
                    "bcdedit /store " + pathbcd + " /set " + id + " path \\windows\\system32\\boot\\winload.exe & " +
                    "bcdedit /store " + pathbcd + " /set " + id + " systemroot \\windows & " +
                    "bcdedit /store " + pathbcd + " /displayorder " + id + " /addlast & " +
                    "bcdedit /store " + pathbcd + " /set " + id + " winpe yes & " +
                    "bcdedit /store " + pathbcd + " /set " + id + " locale en-US & " +
                    "bcdedit /store " + pathbcd + " /set " + id + " DETECTHAL yes",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
                processg.WaitForExit();
            });
        }
        async public static void BOOTWIMefi(string disk, string id, string file)
        {
            await Task.Run(() => {
                Process processg = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c bcdedit /store " + disk + "efi\\microsoft\\boot\\BCD /set " + id + " device RAMDISK=[boot]\\" + file + ",{ramdiskoptions} & " +
                    "bcdedit /store " + disk + "efi\\microsoft\\boot\\BCD /set " + id + " osdevice RAMDISK=[boot]\\" + file + ",{ramdiskoptions} & " +
                    "bcdedit /store " + disk + "efi\\microsoft\\boot\\BCD /set " + id + " path \\windows\\system32\\boot\\winload.efi & " +
                    "bcdedit /store " + disk + "efi\\microsoft\\boot\\BCD /set " + id + " systemroot \\windows & " +
                    "bcdedit /store " + disk + "efi\\microsoft\\boot\\BCD /displayorder " + id + " /addlast & " +
                    "bcdedit /store " + disk + "efi\\microsoft\\boot\\BCD /set " + id + " winpe yes & " +
                    "bcdedit /store " + disk + "efi\\microsoft\\boot\\BCD /set " + id + " locale en-US & " +
                    "bcdedit /store " + disk + "efi\\microsoft\\boot\\BCD /set " + id + " DETECTHAL yes",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
                processg.WaitForExit();
            });
        }
        public static string GRUBID;
        public static void MenuLineGrub(string pathtobcd, string name)
        {
            Process LG = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c bcdedit /store " + pathtobcd + " /create /d " + name + " /application bootsector",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });
            LG.WaitForExit();
            Strings.GRUBID = LG.StandardOutput.ReadToEnd().Remove(0, 10).Remove(38);
        }
        async public static void BOOTGRUB(string pathbcd, string id, string file)
        {
            await Task.Run(() => {
                Process processg = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c bcdedit /store " + pathbcd + " /set " + id + " device=[boot] & " +
                    "bcdedit /store " + pathbcd + " /set " + id + " osdevice partition=[boot] & " +
                    "bcdedit /store " + pathbcd + " /set " + id + @" path "+ file + " &" +
                    "bcdedit /store " + pathbcd + " /displayorder " + id + " /addlast"
                });
            });
        }
        public static string BCDINFO;
        public static void CheckBCD(string pathtobcd)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c bcdedit /store " + pathtobcd,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });
            Strings.BCDINFO = process.StandardOutput.ReadToEnd();
        }
    }
}
