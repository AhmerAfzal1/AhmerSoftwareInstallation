using System;
using System.IO;
using System.Windows.Forms;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public partial class MajorUC : UserControl
    {
        private static string adobeAcrobatProDC = Constants.AdobeAcrobatProDC;
        private static string adobeAcrobatReaderDC = Constants.AdobeAcrobatReaderDC;
        private static string adobePhotoshop = Constants.AdobePhotoshop;
        private static string corelDraw = Constants.CorelDraw;
        private static string msDotNetFramework = Constants.MSDotNetFramework;

        public MajorUC()
        {
            InitializeComponent();

            buttonAcrobatProDC.Text = adobeAcrobatProDC;
            buttonAcrobatReaderDC.Text = adobeAcrobatReaderDC;
            buttonAdobePhotoshop.Text = adobePhotoshop;
            buttonCorelDraw.Text = corelDraw;
            buttonDotNetFrameWork.Text = msDotNetFramework;
        }

        private void ButtonAcrobatProDC_Click(object sender, EventArgs e)
        {
            AcrobatProDC();
        }

        private void ButtonAcrobatReaderDC_Click(object sender, EventArgs e)
        {
            AcrobatReaderDC();
        }

        private void ButtonAdobePhotoshop_Click(object sender, EventArgs e)
        {
            Photoshop();
        }

        private void ButtonCorelDraw_Click(object sender, EventArgs e)
        {
            CorelDraw();
        }

        private void ButtonDotNetFrameWork_Click(object sender, EventArgs e)
        {
            DotNetFrameWork();
        }

        public static void AcrobatProDC()
        {
            string zipFile = Constants.FolderMajor + adobeAcrobatProDC + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(adobeAcrobatProDC, "Setup.exe", "/S /AUTO", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void AcrobatReaderDC()
        {
            string zipFile = Constants.FolderMajor + adobeAcrobatReaderDC + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(adobeAcrobatReaderDC, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
        public static void Photoshop()
        {
            string zipFile = Constants.FolderMajor + adobePhotoshop + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(adobePhotoshop, "Setup.exe", "-S /XDISABLENET=1", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
        public static void CorelDraw()
        {
            string zipFile = Constants.FolderMajor + corelDraw + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(corelDraw, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
        public static void DotNetFrameWork()
        {
            string zipFile = Constants.FolderMajor + msDotNetFramework + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(msDotNetFramework, "Setup.exe", "/lcid 1033 /norestart /passive /showfinalerror", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
    }
}
