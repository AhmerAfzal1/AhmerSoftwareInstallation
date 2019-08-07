using System;
using System.IO;
using System.Windows.Forms;

namespace Ahmer_Software_Installation
{
    public partial class MultimediaUC : UserControl
    {
        private static string kLiteCodecPack = Constants.KLiteCodecPack;
        private static string mpcHC = Constants.MPCHC;
        private static string mirillisSplash = Constants.MirillisSplash;
        private static string mp3Tag = Constants.MP3Tag;

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
