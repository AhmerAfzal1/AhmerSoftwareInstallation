using System.IO;
using System.Windows.Forms;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public static class Constants
    {
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