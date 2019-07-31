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
        private const string button1 = "Auto Drivers And Recommended Softwares";
        private const string button2 = "Developer Softwares";
        private const string button3 = "Internet Softwares";
        private const string button4 = "Major Softwares";
        private const string button5 = "Mobile Softwares";
        private const string button6 = "Multimedia Softwares";
        private const string button7 = "PDF Softwares";
        private const string button8 = "Utilities Softwares";

        public MainProgram()
        {
            InitializeComponent();

            buttonAutoInstall.Text = button1;
            buttonDeveloper.Text = button2;
            buttonInternet.Text = button3;
            buttonMajor.Text = button4;
            buttonMobile.Text = button5;
            buttonMultimedia.Text = button6;
            buttonPDF.Text = button7;
            buttonUtilities.Text = button8;

            labelTitle.Text = titleHeading;
        }
    }
}
