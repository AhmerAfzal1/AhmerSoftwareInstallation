using System.IO;
using System.Windows.Forms;

namespace Ahmer_Software_Installation
{
    public static class Constants
    {
        //---------------------------------------------------------------------------------------------------
        // Developer Softwares Category Category
        public const string AndroidStudio = "Android Studio 183.5692245";
        public const string Git = "Git 2.21.0";
        public const string GPG4Win = "GPG4Win 3.1.9";
        public const string JavaJDK12 = "Java JDK 12.0.2";
        public const string JavaJDK8 = "Java JDK 8 Update 221";
        public const string Python = "Python 3.7.4";
        // Internet Softwares Category
        public const string AdobeFlashPlayer = "Adobe Flash Player 32 Beta";
        public const string BetterNetVPN = "Betternet VPN 5.0.5";
        public const string GoogleChrome = "Google Chrome 74.0.3729.108";
        public const string InternetDownloadManager = "Internet Download Manager 6.33.3";
        public const string MozillaFirefox = "Mozilla Firefox 69 Beta 8";
        public const string NetLimiter = "NetLimiter 4.0.49";
        public const string TorBrowser = "Tor Browser 8.5.3";
        public const string UTorrent = "uTorrent 3.5.5.45311";
        // Major Softwares Category
        public const string AdobeAcrobatProDC = "Adobe Acrobat Pro DC 2019.012.20035";
        public const string AdobeAcrobatReaderDC = "Adobe Acrobat Reader DC 2019.012.20035";
        public const string AdobePhotoshop = "Adobe Photoshop CC 2019 20.0.5.27259";
        public const string CorelDraw = "CorelDRAW Graphics Suite 2019 21.2.0.706";
        public const string MSDotNetFramework = "Microsoft .NET Framework 4.8";
        // Mobile Softwares Category
        public const string iTunes = "iTunes 12.9.5.7";
        public const string SamsungUSBDriver = "Samsung USB Driver 1.5.65.0";
        public const string SideSync = "SideSync 4.7.5.244";
        public const string SmartSwitch = "Smart Switch 4.2.18124.4";
        // Multimedia Softwares Category
        public static string KLiteCodecPack = "K-Lite Mega Codec Pack 15.0.0";
        public static string MPCHC = "Media Player Classic Home Cinema 1.8.7";
        public static string MirillisSplash = "Mirillis Splash 2.7.0";
        public static string MP3Tag = "Mp3Tag 2.96";
        // PDF Softwares Category
        public const string FoxitAdvPDFEditor = "Foxit Advanced PDF Editor 3.10";
        public const string InfixPDFEditor = "Infix PDF Editor Pro 7.4.0";
        public const string PDFCreator = "PDFCreator 3.4.1";
        public const string PDFShaper = "PDF Shaper Pro 8.9";
        public const string PDFToJPG = "PDF to JPG 2.9.10";
        public const string PDFToJPGConverter = "PDF To JPG Converter 4.3.1";
        // Utilities Softwares Category
        public const string AomeiPartition = "AOMEI Partition Assistant Technician 8.4.0";
        public const string CCleaner = "CCleaner 5.60.7307";
        public const string CPUz = "CPUZ 1.89";
        public const string EngToUrduDic = "Cleantouch English to Urdu Dictionary 7.0";
        public const string HWInfo = "HWiNFO 6.08";
        public const string NotepadPlusPlus = "Notepad++ 7.7";
        public const string PowerISO = "PowerISO 7.4";
        public const string Rufus = "Rufus 3.5";
        public const string SevenZip = "7-Zip 19.00";
        public const string VSRedistributable = "Microsoft Visual C++ Redistributable";
        public const string WinRAR = "WinRAR 5.71";
        //---------------------------------------------------------------------------------------------------

        // Variables declared
        public const string Drivers = "Drivers";
        public const string Portable = "Portable";
        public const string PortableButton = " (Portable)";
        public const string x64 = "x64";
        public const string x86 = "x86";
        public const string ZipExtension = ".zip";

        // Directories path and location declared
        public const string SoftwareFolder = "E:\\Softwares\\";
        public const string FolderDeveloper = SoftwareFolder + "Developer\\Softwares\\";
        public const string FolderDrivers = "E:\\Drivers\\Drivers";
        public const string FolderInternet = SoftwareFolder + "Internet\\";
        public const string FolderMajor = SoftwareFolder + "Common\\";
        public const string FolderMobile = SoftwareFolder + "Mobile\\";
        public const string FolderMultimedia = SoftwareFolder + "Multimedia\\";
        public const string FolderPDF = SoftwareFolder + "PDF\\";
        public const string FolderUtilities = SoftwareFolder + "Utilities\\";

        // Temp Folders declared
        private static string Temp = Path.GetTempPath();
        private static string tempFolderPortable = Temp + Portable + "\\";
        private static string tempFolder = Temp + "New\\";
        private static string tempDriverFolder = TempFolder + "Drivers\\";

        // Get & Set Temp Folders
        public static string TempDriverFolder
        {
            get => tempDriverFolder;
            set => tempDriverFolder = value;
        }

        public static string TempFolder
        {
            get => tempFolder;
            set => tempFolder = value;
        }

        public static string TempFolderPortable
        {
            get => tempFolderPortable;
            set => tempFolderPortable = value;
        }

        // MessageBox
        public static void MessageBoxInformation(string s)
        {
            MessageBox.Show(s, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MessageBoxException(string s)
        {
            MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MessageBoxExceptionFileExist(string s)
        {
            MessageBox.Show("The file or path "+"\"" + s + "\"" + " does not exist. Please verify the filename or folder path.", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}