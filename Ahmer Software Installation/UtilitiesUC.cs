using System;
using System.IO;
using System.Windows.Forms;

namespace Ahmer_Software_Installation
{
    public partial class UtilitiesUC : UserControl
    {
        private static string aomeiPartition = Constants.AomeiPartition;
        private static string cCleaner = Constants.CCleaner;
        private static string cpuZ = Constants.CPUz;
        private static string engToUrduDic = Constants.EngToUrduDic;
        private static string hwInfo = Constants.HWInfo;
        private static string notepadPlusPlus = Constants.NotepadPlusPlus;
        private static string powerISO = Constants.PowerISO;
        private static string rufus = Constants.Rufus;
        private static string sevenZip = Constants.SevenZip;
        private static string vsRedistributable = Constants.VSRedistributable;
        private static string winRAR = Constants.WinRAR;

        public UtilitiesUC()
        {
            InitializeComponent();
            buttonAomeiPartition.Text = aomeiPartition;
            buttonCCleaner.Text = cCleaner;
            buttonCPUz.Text = cpuZ /*+ Constants.PortableButton*/;
            buttonEngToUrduDic.Text = engToUrduDic;
            buttonHWiNFO.Text = hwInfo + Constants.PortableButton;
            buttonNotepadPlusPlus.Text = notepadPlusPlus;
            buttonPowerISO.Text = powerISO;
            buttonRufus.Text = rufus + Constants.PortableButton;
            buttonSevenZip.Text = sevenZip;
            buttonVSRedistributable.Text = vsRedistributable;
            buttonWinRAR.Text = winRAR;

            //English dictionary not working properly so it is temporarily disabled
            buttonEngToUrduDic.Enabled = false;
        }

        private void ButtonCCleaner_Click(object sender, EventArgs e)
        {
            CCleaner();


        }

        private void ButtonHWiNFO_Click(object sender, EventArgs e)
        {
            HWiNFO();
        }

        private void ButtonRufus_Click(object sender, EventArgs e)
        {
            Rufus();
        }

        private void ButtonCPUz_Click(object sender, EventArgs e)
        {
            CPUz();
        }

        private void ButtonWinRAR_Click(object sender, EventArgs e)
        {
            WinRAR();
        }

        private void ButtonNotepadPlusPlus_Click(object sender, EventArgs e)
        {
            NotepadPlusPlus();
        }

        private void ButtonPowerISO_Click(object sender, EventArgs e)
        {
            PowerISO();
        }

        private void ButtonVSRedistributable_Click(object sender, EventArgs e)
        {
            VSRedistributable();
        }

        private void ButtonAomeiPartition_Click(object sender, EventArgs e)
        {
            AomeiPartition();
        }

        private void ButtonEngToUrduDic_Click(object sender, EventArgs e)
        {
            EngToUrduDic();
        }

        private void ButtonSevenZip_Click(object sender, EventArgs e)
        {
            SevenZip();
        }

        public static void CCleaner()
        {
            string zipFile = Constants.FolderUtilities + cCleaner + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(cCleaner, "Setup.exe", "/S /IB /TM", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void HWiNFO()
        {
            string zipFile = Constants.FolderUtilities + hwInfo + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(hwInfo, "HWiNFO64.exe", null, null, true);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void Rufus()
        {
            string zipFile = Constants.FolderUtilities + rufus + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(rufus, "Rufus.exe", null, null, true);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void CPUz()
        {
            string zipFile = Constants.FolderUtilities + cpuZ + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(cpuZ, "Setup.exe", "/SILENT", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void WinRAR()
        {
            string zipFile = Constants.SoftwareFolder + winRAR + "\\" + winRAR + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(winRAR, "Setup.exe", "/S /IEN", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void NotepadPlusPlus()
        {
            string zipFile = Constants.FolderUtilities + notepadPlusPlus + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(notepadPlusPlus, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void PowerISO()
        {
            string zipFile = Constants.FolderUtilities + powerISO + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(powerISO, "Setup.exe", "/S /Q", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void VSRedistributable()
        {
            string zipFile = Constants.FolderUtilities + vsRedistributable + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(vsRedistributable, "Setup_2008_x64.exe", "/lang 1033 /q", null, false);
                MainProgram.ProgressAsync(vsRedistributable, "Setup_2008_x86.exe", "/lang 1033 /q", null, false);
                MainProgram.ProgressAsync(vsRedistributable, "Setup_2010_x64.exe", "/lcid 1033 /norestart /passive", null, false);
                MainProgram.ProgressAsync(vsRedistributable, "Setup_2010_x86.exe", "/lcid 1033 /norestart /passive", null, false);
                MainProgram.ProgressAsync(vsRedistributable, "Setup_2012_x64.exe", "/install /passive /norestart", null, false);
                MainProgram.ProgressAsync(vsRedistributable, "Setup_2012_x86.exe", "/install /passive /norestart", null, false);
                MainProgram.ProgressAsync(vsRedistributable, "Setup_2013_x64.exe", "/install /passive /norestart", null, false);
                MainProgram.ProgressAsync(vsRedistributable, "Setup_2013_x86.exe", "/install /passive /norestart", null, false);
                MainProgram.ProgressAsync(vsRedistributable, "Setup_2015_17_19_x64.exe", "/install /passive /norestart", null, false);
                MainProgram.ProgressAsync(vsRedistributable, "Setup_2015_17_19_x86.exe", "/install /passive /norestart", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void AomeiPartition()
        {
            string zipFile = Constants.FolderUtilities + aomeiPartition + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(aomeiPartition, "Setup.exe", "/S /Q", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void EngToUrduDic()
        {
            string zipFile = Constants.FolderUtilities + engToUrduDic + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(engToUrduDic, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void SevenZip()
        {
            string zipFile = Constants.FolderUtilities + sevenZip + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(sevenZip, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
    }
}
