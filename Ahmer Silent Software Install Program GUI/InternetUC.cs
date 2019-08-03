using System;
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

            buttonBetternetVPN.Text = betterNetVPN;
            buttonFireFox.Text = mozillaFirefox;
            buttonFlashPlayer.Text = adobeFlashPlayer;
            buttonGoogleChrome.Text = googleChrome;
            buttonIDM.Text = internetDownloadManager;
            buttonNetLimiter.Text = netLimiter;
            buttonTorBrowser.Text = torBrowser;
            buttonUTorrent.Text = uTorrent;
        }

        private void ButtonFireFox_Click(object sender, EventArgs e)
        {
            Firefox();
        }

        private void ButtonGoogleChrome_Click(object sender, EventArgs e)
        {
            Chrome();
        }

        private void ButtonIDM_Click(object sender, EventArgs e)
        {
            IDM();
        }

        private void ButtonFlashPlayer_Click(object sender, EventArgs e)
        {
            FlashPlayer();
        }

        private void ButtonBetternetVPN_Click(object sender, EventArgs e)
        {
            BetterNet();
        }

        private void ButtonNetLimiter_Click(object sender, EventArgs e)
        {
            NetLimiter();
        }

        private void ButtonTorBrowser_Click(object sender, EventArgs e)
        {
            Tor();
        }

        private void ButtonUTorrent_Click(object sender, EventArgs e)
        {
            Torrent();
        }

        public static void Firefox()
        {
            string zipFile = Constants.FolderInternet + mozillaFirefox + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(mozillaFirefox, "Setup.exe", "-ms", null, false);
        }

        public static void Chrome()
        {
            string zipFile = Constants.FolderInternet + googleChrome + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(googleChrome, "Setup.exe", "/silent /install", null, false);
        }

        public static void IDM()
        {
            string zipFile = Constants.FolderInternet + internetDownloadManager + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            // If using original IDM setup than use argument for silent install  /skipdlgs
            MainProgram.ProgressAsync(internetDownloadManager, "Setup.exe", "/S /EN", null, false);
        }

        public static void FlashPlayer()
        {
            string zipFile = Constants.FolderInternet + adobeFlashPlayer + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(adobeFlashPlayer, "PPAPI.exe", "-INSTALL", null, false);
            MainProgram.ProgressAsync(adobeFlashPlayer, "NPAPI.exe", "-INSTALL", null, false);
        }

        public static void BetterNet()
        {
            string zipFile = Constants.FolderInternet + betterNetVPN + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(betterNetVPN, "Setup.exe", "/S", null, false);
        }

        public static void NetLimiter()
        {
            string zipFile = Constants.FolderInternet + netLimiter + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(netLimiter, "Setup.exe", "/S /I", null, false);
        }

        public static void Tor()
        {
            string zipFile = Constants.FolderInternet + torBrowser + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(torBrowser, "Setup.exe", "/S", null, false);
        }

        public static void Torrent()
        {
            string zipFile = Constants.FolderInternet + uTorrent + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(uTorrent, "Setup.exe", "/S /I", null, false);
        }
    }
}
