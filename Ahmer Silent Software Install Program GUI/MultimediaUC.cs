using System;
using System.IO;
using System.Windows.Forms;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public partial class MultimediaUC : UserControl
    {
        private const string kLiteCodecPack = "K-Lite Mega Codec Pack 15.0.0";
        private const string mpcHC = "Media Player Classic Home Cinema 1.8.7";
        private const string mirillisSplash = "Mirillis Splash 2.7.0";
        private const string mp3Tag = "Mp3Tag 2.96";

        public MultimediaUC()
        {
            InitializeComponent();

            buttonKLiteMegaCodecPack.Text = kLiteCodecPack;
            buttonMirillisSplash.Text = mirillisSplash;
            buttonMP3Tag.Text = mp3Tag;
            buttonMPCHC.Text = mpcHC;
        }

        private void ButtonKLiteMegaCodecPack_Click(object sender, EventArgs e)
        {
            KLiteMegaCodecPack();
        }

        private void ButtonMP3Tag_Click(object sender, EventArgs e)
        {
            MP3Tag();
        }

        private void ButtonMirillisSplash_Click(object sender, EventArgs e)
        {
            MirillishSplash();
        }

        private void ButtonMPCHC_Click(object sender, EventArgs e)
        {
            MPChC();
        }

        public static void KLiteMegaCodecPack()
        {
            string zipFile = Constants.FolderMultimedia + kLiteCodecPack + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(kLiteCodecPack, "Setup.exe", "klcp_mega_unattended.bat", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
        public static void MP3Tag()
        {
            string zipFile = Constants.FolderMultimedia + mp3Tag + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(mp3Tag, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
        public static void MirillishSplash()
        {
            string zipFile = Constants.FolderMultimedia + mirillisSplash + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(mirillisSplash, "Setup.exe", "/S /EN", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
        public static void MPChC()
        {
            string zipFile = Constants.FolderMultimedia + mpcHC + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(mpcHC, "Setup.exe", "/S /I", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
    }
}
