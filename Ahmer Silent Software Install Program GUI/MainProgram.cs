﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

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

        private static BackgroundWorker extractFile;
        private long fileSize;
        private long extractedSizeTotal;
        private long compressedSize;
        private string compressedFileName;

        private static Label programFileLabel = null;
        private static Label tempFolderLabel = null;

        private static ProgressBar individual = null;
        private static ProgressBar total = null;

        public MainProgram()
        {
            InitializeComponent();

            labelSoftwareCategory.Text = "";
            this.ahmerUC1.BringToFront();

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

            individual = progressBarIndividual;
            total = progressBarTotal;

            progressBarIndividual.Maximum = int.MaxValue;
            progressBarTotal.Maximum = int.MaxValue;

            extractFile = new BackgroundWorker();
            extractFile.DoWork += ExtractFile_DoWork;
            extractFile.ProgressChanged += ExtractFile_ProgressChanged;
            extractFile.RunWorkerCompleted += ExtractFile_RunWorkerCompleted;
            extractFile.WorkerReportsProgress = true;
        }

        private void ButtonDeveloper_Click(object sender, EventArgs e)
        {
            labelSoftwareCategory.Text = titleDeveloper;
            this.developerUC1.BringToFront();
        }

        private void ButtonInternet_Click(object sender, EventArgs e)
        {
            labelSoftwareCategory.Text = titleInternet;
            this.internetUC1.BringToFront();
        }

        private void ButtonMajor_Click(object sender, EventArgs e)
        {
            labelSoftwareCategory.Text = titleMajor;
            this.majorUC1.BringToFront();
        }

        private void ButtonMobile_Click(object sender, EventArgs e)
        {
            labelSoftwareCategory.Text = titleMobile;
            this.mobileUC1.BringToFront();
        }

        private void ButtonMultimedia_Click(object sender, EventArgs e)
        {
            labelSoftwareCategory.Text = titleMultimedia;
            this.multimediaUC1.BringToFront();
        }

        private void ButtonPDF_Click(object sender, EventArgs e)
        {
            labelSoftwareCategory.Text = titlePDF;
            this.pdfUC1.BringToFront();
        }

        private void ButtonUtilities_Click(object sender, EventArgs e)
        {
            labelSoftwareCategory.Text = titleUtilities;
            this.utilitiesUC1.BringToFront();
        }

        private void ButtonAhmer_Click(object sender, EventArgs e)
        {
            labelSoftwareCategory.Text = "";
            this.ahmerUC1.BringToFront();
        }

        public static string GetSetShowProgramFile
        {
            get { return programFileLabel.Text; }
            set { programFileLabel.Text = value; }
        }

        private void ExtractFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarIndividual.Value = int.MaxValue;
            progressBarTotal.Value = int.MaxValue;
            Constants.MessageBoxInformation("Extraction completed!");
        }

        private void ExtractFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelShowExtractingPath.Text = compressedFileName;
            progressBarIndividual.Value = e.ProgressPercentage;

            //Calculate the totalPercent
            long totalPercent = ((long)e.ProgressPercentage * compressedSize + extractedSizeTotal * int.MaxValue) / fileSize;
            if (totalPercent > int.MaxValue) totalPercent = int.MaxValue;
            progressBarTotal.Value = (int)totalPercent;
        }

        private void ExtractFile_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string fileName = GetSetShowProgramFile;
                string extractPath = Constants.TempFolder;

                //Get the size of the zip file
                FileInfo fileInfo = new FileInfo(fileName);
                fileSize = fileInfo.Length;
                using (ZipFile zipFile = ZipFile.Read(fileName))
                {
                    //Reset the bytes total extracted to 0
                    extractedSizeTotal = 0;
                    int fileAmount = zipFile.Count;
                    int fileIndex = 0;
                    zipFile.ExtractProgress += Zip_ExtractProgress;
                    foreach (ZipEntry ZipEntry in zipFile)
                    {
                        fileIndex++;
                        compressedFileName = "(" + fileIndex.ToString() + "/" + fileAmount + "): " + ZipEntry.FileName;
                        //Get the size of a single compressed file
                        compressedSize = ZipEntry.CompressedSize;
                        ZipEntry.Extract(extractPath, ExtractExistingFileAction.OverwriteSilently);
                        //Calculate the bytes total extracted
                        extractedSizeTotal += compressedSize;
                    }
                }
            }
            catch (ArgumentNullException a)
            {
                Constants.MessageBoxException(a.Message);
            }
            catch (SecurityException s)
            {
                Constants.MessageBoxException(s.Message);
            }
            catch (ArgumentException ar)
            {
                Constants.MessageBoxException(ar.Message);
            }
            catch (UnauthorizedAccessException u)
            {
                Constants.MessageBoxException(u.Message);
            }
            catch (PathTooLongException p)
            {
                Constants.MessageBoxException(p.Message);
            }
            catch (NotSupportedException n)
            {
                Constants.MessageBoxException(n.Message);
            }
            catch (IOException io)
            {
                Constants.MessageBoxException(io.Message);
            }
            catch (Exception ex)
            {
                Constants.MessageBoxException(ex.Message);
            }
        }

        private void Zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer > 0)
            {
                long percent = e.BytesTransferred * int.MaxValue / e.TotalBytesToTransfer;
                //Console.WriteLine("Indivual: " + percent);
                extractFile.ReportProgress((int)percent);
            }
        }

        public static void ProgressAsync()
        {
            extractFile.RunWorkerAsync();
        }
    }
}
