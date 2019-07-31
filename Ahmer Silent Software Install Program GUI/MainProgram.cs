using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public partial class MainProgram : Form
    {
        private const string titleHeading = "Ahmer's Automatically And Silently Softwares Installation Program GUI";
        private const string titleAutoInstall = "Auto Install Drivers And Recommended Softwares";
        private const string titleDeveloper = "Developer Softwares";
        private const string titleInternet = "Internet Softwares";
        private const string titleMajor = "Major Softwares";
        private const string titleMobile = "Mobile Softwares";
        private const string titleMultimedia = "Multimedia Softwares";
        private const string titlePDF = "PDF Softwares";
        private const string titleUtilities = "Utilities Softwares";

        private static Label programFileLabel = null;
        private static Label tempFolderLabel = null;

        public MainProgram()
        {
            InitializeComponent();

            labelSoftwareCategory.Text = "";

            buttonAutoInstall.Text = titleAutoInstall;
            buttonDeveloper.Text = titleDeveloper;
            buttonInternet.Text = titleInternet;
            buttonMajor.Text = titleMajor;
            buttonMobile.Text = titleMobile;
            buttonMultimedia.Text = titleMultimedia;
            buttonPDF.Text = titlePDF;
            buttonUtilities.Text = titleUtilities;

            labelTitle.Text = titleHeading;

            tempFolderLabel = labelShowDestination;
            tempFolderLabel.Text = Constants.TempFolder;
            programFileLabel = labelShowProgramFile;
        }

        public static string GetSetShowProgramFile
        {
            get { return programFileLabel.Text; }
            set { programFileLabel.Text = value; }
        }

        private void ButtonDeveloper_Click(object sender, EventArgs e)
        {
            labelSoftwareCategory.Text = titleDeveloper;
            this.developerUC1.BringToFront();
        }
    }
}
