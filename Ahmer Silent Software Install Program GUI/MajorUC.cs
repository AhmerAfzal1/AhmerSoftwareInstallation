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
    public partial class MajorUC : UserControl
    {
        private const string adobeAcrobatProDC = "Adobe Acrobat Pro DC 2019.012.20035";
        private const string adobeAcrobatReaderDC = "Adobe Acrobat Reader DC 2019.012.20035";
        private const string adobePhotoshop = "Adobe Photoshop CC 2019 20.0.5.27259";
        private const string corelDraw = "CorelDRAW Graphics Suite 2019 21.2.0.706";
        private const string msDotNetFramework = "Microsoft .NET Framework 4.8";

        public MajorUC()
        {
            InitializeComponent();

            buttonAcrobatProDC.Text = adobeAcrobatProDC;
            buttonAcrobatReaderDC.Text = adobeAcrobatReaderDC;
            buttonAdobePhotoshop.Text = adobePhotoshop;
            buttonCorelDraw.Text = corelDraw;
            buttonDotNetFrameWork.Text = msDotNetFramework;
        }

        private void ButtonAcrobatProDC_Click(object sender, EventArgs e)
        {

        }
    }
}
