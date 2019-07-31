using System.IO;
using System.Windows.Forms;

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

        // MessageBox
        public static void MessageBoxInformation(string s)
        {
            MessageBox.Show(s, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MessageBoxException(string s)
        {
            MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}