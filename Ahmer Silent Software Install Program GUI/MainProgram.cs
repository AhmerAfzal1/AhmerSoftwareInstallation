using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using Ionic.Zip;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public partial class MainProgram : Form
    {
        private const string titleHeading = "Ahmer's Automatically And Silently Softwares Installation Program";
        private const string titleAutoInstall = "Auto Install Drivers And Recommended Softwares";
        private const string titleDeveloper = "Developer Softwares";
        private const string titleInternet = "Internet Softwares";
        private const string titleMajor = "Major Softwares";
        private const string titleMobile = "Mobile Softwares";
        private const string titleMultimedia = "Multimedia Softwares";
        private const string titlePDF = "PDF Softwares";
        private const string titleUtilities = "Utilities Softwares";

        private static BackgroundWorker extractBackgroundWorker = null;
        private static BackgroundWorker installBackgroundWorker = null;
        private static bool portable = false;
        private static Label programFileLabel = null;
        private static Label tempFolderLabel = null;
        private static long zipCompressedSize = 0;
        private static long zipExtractedTotalSize = 0;
        private static long zipFileSize = 0;
        private static string exeArguments = null;
        private static string exeSoftware = null;
        private static string nameSoftware = null;
        private static string tempfolder = null;
        private static string zipFileName = null;
        private static string zipPassword = null;

        public MainProgram()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(Load_Assembly);

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
            programFileLabel = labelShowProgramFile;
            GetSetShowShowDestination = null;

            progressBarIndividual.Maximum = int.MaxValue;
            progressBarTotal.Maximum = int.MaxValue;

            extractBackgroundWorker = new BackgroundWorker();
            extractBackgroundWorker.DoWork += ExtractFile_DoWork;
            extractBackgroundWorker.ProgressChanged += ExtractFile_ProgressChanged;
            extractBackgroundWorker.RunWorkerCompleted += ExtractFile_RunWorkerCompleted;
            extractBackgroundWorker.WorkerReportsProgress = true;

            installBackgroundWorker = new BackgroundWorker();
            installBackgroundWorker.DoWork += InstallBackgroundWorker_DoWork;
            installBackgroundWorker.ProgressChanged += InstallBackgroundWorker_ProgressChanged;
            installBackgroundWorker.RunWorkerCompleted += InstallBackgroundWorker_RunWorkerCompleted;
            installBackgroundWorker.WorkerReportsProgress = true;
        }
        private void ButtonAutoInstall_Click(object sender, EventArgs e)
        {
            DeveloperUC.JavaJDK8();
            DeveloperUC.Git();
            InternetUC.IDM();
            InternetUC.Firefox();
            MultimediaUC.KLiteMegaCodecPack();
            UtilitiesUC.CCleaner();
            UtilitiesUC.NotepadPlusPlus();
            UtilitiesUC.WinRAR();
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

        static Assembly Load_Assembly(object sender, ResolveEventArgs args)
        {
            String dllName = new AssemblyName(args.Name).Name + ".dll";
            var assembly = Assembly.GetExecutingAssembly();
            String resourceName = assembly.GetManifestResourceNames().FirstOrDefault(rn => rn.EndsWith(dllName));
            if (resourceName == null) return null; // Not found, maybe another handler will find it
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                Byte[] assemblyData = new Byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }

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
            labelShowExtractingPath.Text = zipFileName;
            progressBarIndividual.Value = e.ProgressPercentage;

            //Calculate the totalPercent
            long totalPercent = ((long)e.ProgressPercentage * zipCompressedSize + zipExtractedTotalSize * int.MaxValue) / zipFileSize;
            if (totalPercent > int.MaxValue) totalPercent = int.MaxValue;
            progressBarTotal.Value = (int)totalPercent;
            GetSetShowShowDestination = tempfolder;
        }

        private void ExtractFile_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (portable)
            {
                case true:
                    tempfolder = Constants.TempFolderPortable;
                    break;

                case false:
                    tempfolder = Constants.TempFolder;
                    break;
            }

            try
            {
                string fileName = GetSetShowProgramFile;

                //Get the size of the zip file
                FileInfo fileInfo = new FileInfo(fileName);
                zipFileSize = fileInfo.Length;
                using (ZipFile zipFile = ZipFile.Read(fileName))
                {
                    //Reset the bytes total extracted to 0
                    zipExtractedTotalSize = 0;
                    int fileAmount = zipFile.Count;
                    int fileIndex = 0;
                    zipFile.Password = zipPassword;
                    zipFile.ExtractProgress += Zip_ExtractProgress;
                    foreach (ZipEntry ZipEntry in zipFile)
                    {
                        fileIndex++;
                        zipFileName = "(" + fileIndex.ToString() + "\\" + fileAmount + "): " + ZipEntry.FileName;
                        //Get the size of a single compressed file
                        zipCompressedSize = ZipEntry.CompressedSize;
                        ZipEntry.Extract(tempfolder, ExtractExistingFileAction.OverwriteSilently);
                        //Calculate the bytes total extracted
                        zipExtractedTotalSize += zipCompressedSize;
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
            string makeNewPath = tempfolder + nameSoftware + "\\" + exeSoftware;

            try
            {
                using (Process exeFile = new Process())
                {
                    exeFile.StartInfo.FileName = makeNewPath;
                    exeFile.StartInfo.Arguments = exeArguments;
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
                extractBackgroundWorker.ReportProgress((int)percent);
            }
        }

        public static string GetSetShowProgramFile
        {
            get { return programFileLabel.Text; }
            set { programFileLabel.Text = value; }
        }

        public static string GetSetShowShowDestination
        {
            get { return tempFolderLabel.Text; }
            set { tempFolderLabel.Text = value; }
        }

        public static void ProgressAsync(string softwareName, string softwareExe,
            string argument = null, string password = null, bool isPortable = false)
        {
            nameSoftware = softwareName;
            exeSoftware = softwareExe;
            exeArguments = argument;
            zipPassword = password;
            portable = isPortable;
            extractBackgroundWorker.RunWorkerAsync();
        }
    }
}
