using System;
using System.IO;
using System.Windows.Forms;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public partial class MobileUC : UserControl
    {
        private const string iTunes = "iTunes 12.9.5.7";
        private const string samsungUSBDriver = "Samsung USB Driver 1.5.65.0";
        private const string sideSync = "SideSync 4.7.5.244";
        private const string smartSwitch = "Smart Switch 4.2.18124.4";

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
