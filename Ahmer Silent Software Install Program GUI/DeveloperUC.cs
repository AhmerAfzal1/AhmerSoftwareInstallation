using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public partial class DeveloperUC : UserControl
    {
        private static string androidStudio = Constants.AndroidStudio;
        private static string git = Constants.Git;
        private static string gpg4Win = Constants.GPG4Win;
        private static string javaJDK12 = Constants.JavaJDK12;
        private static string javaJDK8 = Constants.JavaJDK8;
        private static string python = Constants.Python;

        public DeveloperUC()
        {
            InitializeComponent();

            buttonAndroidStudio.Text = androidStudio;
            buttonGit.Text = git;
            buttonGpg.Text = gpg4Win;
            buttonJavaJDK12.Text = javaJDK12;
            buttonJavaJDK8.Text = javaJDK8;
            buttonPython.Text = python;
        }

        private void ButtonJavaJDK8_Click(object sender, EventArgs e)
        {
            JavaJDK8();
        }

        private void ButtonJavaJDK12_Click(object sender, EventArgs e)
        {
            JavaJDK12();
        }

        private void ButtonAndroidStudio_Click(object sender, EventArgs e)
        {
            AndroidStudio();
        }

        private void ButtonGit_Click(object sender, EventArgs e)
        {
            Git();
        }

        private void ButtonPython_Click(object sender, EventArgs e)
        {
            Python();
        }

        private void ButtonGpg_Click(object sender, EventArgs e)
        {
            Gpg();
        }

        public static void JavaJDK8()
        {
            string zipFile = Constants.FolderDeveloper + javaJDK8 + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(javaJDK8, "Setup.exe", "/s ADDLOCAL=\"ToolsFeature,SourceFeature,PublicjreFeature\"", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void JavaJDK12()
        {
            string zipFile = Constants.FolderDeveloper + javaJDK12 + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(javaJDK12, "Setup.exe", "/s ADDLOCAL=\"ToolsFeature,SourceFeature,PublicjreFeature\"", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void AndroidStudio()
        {
            string zipFile = Constants.FolderDeveloper + androidStudio + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(androidStudio, "Setup.exe", "/S /Allusers", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void Git()
        {
            string zipFile = Constants.FolderDeveloper + git + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(git, "Setup.exe", "/VERYSILENT /NORESTART /NOCANCEL /SP- /CLOSEAPPLICATIONS /RESTARTAPPLICATIONS /COMPONENTS=\"icons,icons\\desktop,ext\\reg,ext\\reg\\shellhere,assoc,assoc_sh,consolefont\"", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void Gpg()
        {
            string zipFile = Constants.FolderDeveloper + gpg4Win + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(gpg4Win, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void Python()
        {
            string zipFile = Constants.FolderDeveloper + python + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(python, "Setup.exe", "/passive InstallAllUsers=1 PrependPath=1 CompileAll=1", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
    }
}
