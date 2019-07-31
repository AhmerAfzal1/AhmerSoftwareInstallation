using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            buttonJavaJDK8.Text = javaJDK8;
            buttonJavaJDK12.Text = javaJDK12;
            buttonPython.Text = python;
        }

        private void ButtonJavaJDK8_Click(object sender, EventArgs e)
        {

        }
    }
}
