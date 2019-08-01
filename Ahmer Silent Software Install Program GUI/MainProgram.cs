using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Threading;
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

        private static Label programFileLabel = null;
        private static Label tempFolderLabel = null;

        private static BackgroundWorker installBackgroundWorker = null;
        private static BackgroundWorker extractFile = null;
        private long fileSize = 0;
        private long extractedSizeTotal = 0;
        private long compressedSize = 0;
        private string compressedFileName = null;

        private static string newPath = null;
        private static string arguments = null;
        private static string zipPassword = null;

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

            progressBarIndividual.Maximum = int.MaxValue;
            progressBarTotal.Maximum = int.MaxValue;

            extractFile = new BackgroundWorker();
            extractFile.DoWork += ExtractFile_DoWork;
            extractFile.ProgressChanged += ExtractFile_ProgressChanged;
            extractFile.RunWorkerCompleted += ExtractFile_RunWorkerCompleted;
            extractFile.WorkerReportsProgress = true;

            installBackgroundWorker = new BackgroundWorker();
            installBackgroundWorker.DoWork += InstallBackgroundWorker_DoWork;
            installBackgroundWorker.ProgressChanged += InstallBackgroundWorker_ProgressChanged;
            installBackgroundWorker.RunWorkerCompleted += InstallBackgroundWorker_RunWorkerCompleted;
            installBackgroundWorker.WorkerReportsProgress = true;

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

        private void ExtractFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarIndividual.Value = int.MaxValue;
            progressBarTotal.Value = int.MaxValue;
            if (e.Error == null)
            {
                installBackgroundWorker.RunWorkerAsync();
            }
            //Constants.MessageBoxInformation("Extraction completed!");
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
                    zipFile.Password = zipPassword;
                    zipFile.ExtractProgress += Zip_ExtractProgress;
                    foreach (ZipEntry ZipEntry in zipFile)
                    {
                        fileIndex++;
                        compressedFileName = "(" + fileIndex.ToString() + "\\" + fileAmount + "): " + ZipEntry.FileName;
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

        private void InstallBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Constants.MessageBoxInformation("Installation completed!");
        }

        private void InstallBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InstallBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (Process exeFile = new Process())
                {
                    exeFile.StartInfo.FileName = newPath;
                    exeFile.StartInfo.Arguments = arguments;
                    exeFile.StartInfo.Verb = "runas";
                    exeFile.StartInfo.UseShellExecute = true;
                    exeFile.Start();
                    exeFile.WaitForExit();
                }
            }
            catch (InvalidOperationException i)
            {
                Constants.MessageBoxException("InvalidOperationException: " + i.Message);
            }
            catch (ArgumentNullException a)
            {
                Constants.MessageBoxException("ArgumentNullException: " + a.Message);
            }
            catch (PlatformNotSupportedException p)
            {
                Constants.MessageBoxException("PlatformNotSupportedException: " + p.Message);
            }
            catch (FileNotFoundException f)
            {
                Constants.MessageBoxException("FileNotFoundException: " + f.Message);
            }
            catch (Win32Exception ex)
            {
                Constants.MessageBoxException("Win32Exception: " + ex.Message);
            }
        }

        private void Zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer > 0)
            {
                long percent = e.BytesTransferred * int.MaxValue / e.TotalBytesToTransfer;
                extractFile.ReportProgress((int)percent);
            }
        }

        public static string GetSetShowProgramFile
        {
            get { return programFileLabel.Text; }
            set { programFileLabel.Text = value; }
        }

        public static void ProgressAsync(string path, string argument = null, string password = null)
        {
            newPath = path;
            arguments = argument;
            zipPassword = password;
            extractFile.RunWorkerAsync();
        }
    }
}
