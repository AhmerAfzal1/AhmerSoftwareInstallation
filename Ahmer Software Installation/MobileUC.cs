using System;
using System.IO;
using System.Windows.Forms;

namespace Ahmer_Software_Installation
{
    public partial class MobileUC : UserControl
    {
        private static string iTunes = Constants.iTunes;
        private static string samsungUSBDriver = Constants.SamsungUSBDriver;
        private static string sideSync = Constants.SideSync;
        private static string smartSwitch = Constants.SmartSwitch;

        public MobileUC()
        {
            InitializeComponent();

            buttoniTunes.Text = iTunes;
            buttonSamsungUSBDriver.Text = samsungUSBDriver;
            buttonSideSync.Text = sideSync;
            buttonSmartSwitch.Text = smartSwitch;
        }

        private void ButtonSmartSwitch_Click(object sender, EventArgs e)
        {
            SmartSwitch();
        }

        private void ButtonSideSync_Click(object sender, EventArgs e)
        {
            SideSync();
        }

        private void ButtonSamsungUSBDriver_Click(object sender, EventArgs e)
        {
            SumsungUSBDriver();
        }

        private void ButtoniTunes_Click(object sender, EventArgs e)
        {
            Itunes();
        }

        public static void SmartSwitch()
        {
            string zipFile = Constants.FolderMobile + smartSwitch + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(smartSwitch, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void SideSync()
        {
            string zipFile = Constants.FolderMobile + sideSync + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(sideSync, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
        public static void SumsungUSBDriver()
        {
            string zipFile = Constants.FolderMobile + samsungUSBDriver + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(samsungUSBDriver, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
        public static void Itunes()
        {
            string zipFile = Constants.FolderMobile + iTunes + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(iTunes, "Setup.exe", "/qn /norestart", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }

        }
    }
}
