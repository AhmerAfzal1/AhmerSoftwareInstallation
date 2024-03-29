﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Ahmer_Software_Installation
{
    public partial class InternetUC : UserControl
    {
        private static string adobeFlashPlayer = Constants.AdobeFlashPlayer;
        private static string betterNetVPN = Constants.BetterNetVPN;
        private static string googleChrome = Constants.GoogleChrome;
        private static string internetDownloadManager = Constants.InternetDownloadManager;
        private static string mozillaFirefox = Constants.MozillaFirefox;
        private static string netLimiter = Constants.NetLimiter;
        private static string torBrowser = Constants.TorBrowser;
        private static string uTorrent = Constants.UTorrent;

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
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(mozillaFirefox, "Setup.exe", "-ms", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void Chrome()
        {
            string zipFile = Constants.FolderInternet + googleChrome + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(googleChrome, "Setup.exe", "/silent /install", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void IDM()
        {
            string zipFile = Constants.FolderInternet + internetDownloadManager + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                // If using original IDM setup than use argument for silent install  /skipdlgs
                MainProgram.ProgressAsync(internetDownloadManager, "Setup.exe", "/S /EN", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void FlashPlayer()
        {
            string zipFile = Constants.FolderInternet + adobeFlashPlayer + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(adobeFlashPlayer, "PPAPI.exe", "-INSTALL", null, false);
                MainProgram.ProgressAsync(adobeFlashPlayer, "NPAPI.exe", "-INSTALL", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void BetterNet()
        {
            string zipFile = Constants.FolderInternet + betterNetVPN + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(betterNetVPN, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void NetLimiter()
        {
            string zipFile = Constants.FolderInternet + netLimiter + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(netLimiter, "Setup.exe", "/S /I", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void Tor()
        {
            string zipFile = Constants.FolderInternet + torBrowser + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(torBrowser, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void Torrent()
        {
            string zipFile = Constants.FolderInternet + uTorrent + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(uTorrent, "Setup.exe", "/S /I", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
    }
}
