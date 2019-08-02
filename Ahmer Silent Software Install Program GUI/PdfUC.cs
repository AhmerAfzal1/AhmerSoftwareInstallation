using System;
using System.Windows.Forms;

namespace Ahmer_Silent_Software_Install_Program_GUI
{
    public partial class PdfUC : UserControl
    {
        private const string foxitAdvPDFEditor = "Foxit Advanced PDF Editor 3.10";
        private const string infixPDFEditor = "Infix PDF Editor Pro 7.4.0";
        private const string pdfCreator = "PDFCreator 3.4.1";
        private const string pdfShaper = "PDF Shaper Pro 8.9";
        private const string pdfToJPG = "PDF to JPG 2.9.10";
        private const string pdfToJPGConverter = "PDF To JPG Converter 4.3.1";

        public PdfUC()
        {
            InitializeComponent();

            buttonFoxitAdvPDFEditor.Text = foxitAdvPDFEditor;
            buttonInfixPDFEditor.Text = infixPDFEditor;
            buttonPdfCreator.Text = pdfCreator;
            buttonPdfShaper.Text = pdfShaper;
            buttonPdfToJPG.Text = pdfToJPG;
            buttonPdfToJPGConverter.Text = pdfToJPGConverter;
        }

        private void ButtonFoxitAdvPDFEditor_Click(object sender, EventArgs e)
        {

        }
    }
}
