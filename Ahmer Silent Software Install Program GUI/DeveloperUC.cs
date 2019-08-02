using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public partial class DeveloperUC : UserControl
    {
        private const string androidStudio = "Android Studio 183.5692245";
        private const string git = "Git 2.21.0";
        private const string gpg4Win = "GPG4Win 3.1.9";
        private const string javaJDK12 = "Java JDK 12.0.2";
        private const string javaJDK8 = "Java JDK 8 Update 221";
        private const string python = "Python 3.7.4";

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
            string zipFile = Constants.FolderDeveloper + javaJDK8 + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(javaJDK8, "Setup.exe", "/s ADDLOCAL=\"ToolsFeature,SourceFeature,PublicjreFeature\"", null, false);
        }

        private void ButtonJavaJDK12_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderDeveloper + javaJDK12 + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(javaJDK12, "Setup.exe", "/s ADDLOCAL=\"ToolsFeature,SourceFeature,PublicjreFeature\"", null, false);
        }

        private void ButtonAndroidStudio_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderDeveloper + androidStudio + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(androidStudio, "Setup.exe", "/S /Allusers", null, false);
        }

        private void ButtonGit_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderDeveloper + git + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(git, "Setup.exe", "/VERYSILENT /NORESTART /NOCANCEL /SP- /CLOSEAPPLICATIONS /RESTARTAPPLICATIONS /COMPONENTS=\"icons,icons\\desktop,ext\\reg,ext\\reg\\shellhere,assoc,assoc_sh,consolefont\"", null, false);
        }

        private void ButtonPython_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderDeveloper + python + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(python, "Setup.exe", "/passive InstallAllUsers=1 PrependPath=1 CompileAll=1", null, false);
        }

        private void ButtonGpg_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderDeveloper + gpg4Win + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(gpg4Win, "Setup.exe", "/S", null, false);
        }
    }
}
