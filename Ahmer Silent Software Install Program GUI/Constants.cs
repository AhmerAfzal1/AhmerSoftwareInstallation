using System.IO;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public static class Constants
    {
        // Temp Folders declared
        private static string Temp = Path.GetTempPath();
        private static string tempFolder = Temp + "New\\";

        // Get & Set Temp Folders
        public static string TempFolder
        {
            get => tempFolder;
            set => tempFolder = value;
        }
    }
}