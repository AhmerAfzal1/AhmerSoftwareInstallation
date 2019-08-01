using System;
using System.Windows.Forms;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public partial class UtilitiesUC : UserControl
    {
        private const string aomeiPartition = "AOMEI Partition Assistant 8.3.0";
        private const string cCleaner = "CCleaner 5.60.7307";
        private const string cpuZ = "CPUZ 1.89 (Portable)";
        private const string engToUrduDic = "Cleantouch English to Urdu Dictionary 7.0";
        private const string hwInfo = "HWiNFO 6.08 (Portable)";
        private const string notepadPlusPlus = "Notepad++ 7.7";
        private const string powerISO = "PowerISO 7.4";
        private const string rufus = "Rufus 3.5 (Portable)";
        private const string sevenZip = "7-Zip 19.00";
        private const string vsRedistributable = "Microsoft Visual C++ Redistributable";
        private const string winRAR = "WinRAR 5.71";

        public UtilitiesUC()
        {
            InitializeComponent();
            buttonAomeiPartition.Text = aomeiPartition;
            buttonCCleaner.Text = cCleaner;
            buttonCPUz.Text = cpuZ;
            buttonEngToUrduDic.Text = engToUrduDic;
            buttonHWiNFO.Text = hwInfo;
            buttonNotepadPlusPlus.Text = notepadPlusPlus;
            buttonPowerISO.Text = powerISO;
            buttonRufus.Text = rufus;
            buttonSevenZip.Text = sevenZip;
            buttonWinRAR.Text = winRAR;
            buttonVSRedistributable.Text = vsRedistributable;
        }

        private void ButtonCCleaner_Click(object sender, EventArgs e)
        {

        }

        private void ButtonHWiNFO_Click(object sender, EventArgs e)
        {
            MainProgram.GetSetShowProgramFile = "D:\\New\\New.zip";
        }
    }
}
