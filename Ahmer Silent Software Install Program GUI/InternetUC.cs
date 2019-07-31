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
    public partial class InternetUC : UserControl
    {
        private const string adobeFlashPlayer = "Adobe Flash Player 32 Beta";
        private const string betterNetVPN = "Betternet VPN 5.0.5";
        private const string googleChrome = "Google Chrome 74.0.3729.108";
        private const string internetDownloadManager = "Internet Download Manager 6.33.3";
        private const string mozillaFirefox = "Mozilla Firefox 69 Beta 8";
        private const string netLimiter = "NetLimiter 4.0.49";
        private const string torBrowser = "Tor Browser 8.5.3";
        private const string uTorrent = "uTorrent 3.5.5.45311";

        public InternetUC()
        {
            InitializeComponent();

            buttonFlashPlayer.Text = adobeFlashPlayer;
            buttonBetternetVPN.Text = betterNetVPN;
            buttonGoogleChrome.Text = googleChrome;
            buttonIDM.Text = internetDownloadManager;
            buttonFireFox.Text = mozillaFirefox;
            buttonNetLimiter.Text = netLimiter;
            buttonTorBrowser.Text = torBrowser;
            buttonUTorrent.Text = uTorrent;
        }

        private void ButtonFireFox_Click(object sender, EventArgs e)
        {

        }
    }
}
