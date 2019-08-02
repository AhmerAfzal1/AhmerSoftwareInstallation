using System;
using System.IO;
using System.Windows.Forms;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public partial class UtilitiesUC : UserControl
    {
        private const string aomeiPartition = "AOMEI Partition Assistant 8.3.0";
        private const string cCleaner = "CCleaner 5.60.7307";
        private const string cpuZ = "CPUZ 1.89";
        private const string engToUrduDic = "Cleantouch English to Urdu Dictionary 7.0";
        private const string hwInfo = "HWiNFO 6.08";
        private const string notepadPlusPlus = "Notepad++ 7.7";
        private const string powerISO = "PowerISO 7.4";
        private const string rufus = "Rufus 3.5";
        private const string sevenZip = "7-Zip 19.00";
        private const string vsRedistributable = "Microsoft Visual C++ Redistributable";
        private const string winRAR = "WinRAR 5.71";

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
            string zipFile = Constants.FolderUtilities + cCleaner + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(cCleaner, "Setup.exe", "/S /IB /TM", null, false);
        }

        private void ButtonHWiNFO_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderUtilities + hwInfo + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(hwInfo, "HWiNFO64.exe", null, null, true);
        }

        private void ButtonRufus_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderUtilities + rufus + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(rufus, "Rufus.exe", null, null, true);
        }

        private void ButtonCPUz_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderUtilities + cpuZ + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(cpuZ, "Setup.exe", "/SILENT", null, false);
        }

        private void ButtonWinRAR_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.SoftwareFolder + winRAR + "\\" + winRAR + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(winRAR, "Setup.exe", "/S /IEN", null, false);
        }

        private void ButtonNotepadPlusPlus_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderUtilities + notepadPlusPlus + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(notepadPlusPlus, "Setup.exe", "/S", null, false);
        }

        private void ButtonPowerISO_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderUtilities + powerISO + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(powerISO, "Setup.exe", "/S /Q", null, false);
        }

        private void ButtonVSRedistributable_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderUtilities + vsRedistributable + Constants.ZipExtension;
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

        private void ButtonAomeiPartition_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderUtilities + aomeiPartition + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(aomeiPartition, "Setup.exe", "/S /Q", null, false);
        }

        private void ButtonEngToUrduDic_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderUtilities + engToUrduDic + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(engToUrduDic, "Setup.exe", "/S", null, false);
        }

        private void ButtonSevenZip_Click(object sender, EventArgs e)
        {
            string zipFile = Constants.FolderUtilities + sevenZip + Constants.ZipExtension;
            MainProgram.GetSetShowProgramFile = zipFile;
            MainProgram.ProgressAsync(sevenZip, "Setup.exe", "/S", null, false);
        }
    }
}
