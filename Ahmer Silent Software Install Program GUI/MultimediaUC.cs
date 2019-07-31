using System;
using System.Windows.Forms;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public partial class MultimediaUC : UserControl
    {
        private const string kLiteCodecPack = "K-Lite Mega Codec Pack 15.0.0";
        private const string mpcHC = "Media Player Classic Home Cinema 1.8.7";
        private const string mirillisSplash = "Mirillis Splash 2.7.0";
        private const string mp3Tag = "Mp3Tag 2.96";

        public MultimediaUC()
        {
            InitializeComponent();
            buttonKLiteMegaCodecPack.Text = kLiteCodecPack;
            buttonMirillisSplash.Text = mirillisSplash;
            buttonMP3Tag.Text = mp3Tag;
            buttonMPCHC.Text = mpcHC;
        }

        private void ButtonKLiteMegaCodecPack_Click(object sender, EventArgs e)
        {

        }
    }
}
