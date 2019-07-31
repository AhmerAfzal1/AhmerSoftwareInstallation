using System;
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

        }
    }
}
