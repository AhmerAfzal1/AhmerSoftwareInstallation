using System;
using System.IO;
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
            FoxitAdvPDFEditor();
        }

        private void ButtonInfixPDFEditor_Click(object sender, EventArgs e)
        {
            InfixPDFEditor();
        }

        private void ButtonPdfCreator_Click(object sender, EventArgs e)
        {
            PdfCreator();
        }

        private void ButtonPdfToJPG_Click(object sender, EventArgs e)
        {
            PdfToJPG();
        }

        private void ButtonPdfToJPGConverter_Click(object sender, EventArgs e)
        {
            PdfToJPGConverter();
        }

        private void ButtonPdfShaper_Click(object sender, EventArgs e)
        {
            PdfShaper();
        }

        public static void FoxitAdvPDFEditor()
        {
            string zipFile = Constants.FolderPDF + foxitAdvPDFEditor + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(foxitAdvPDFEditor, "Setup.exe", "/S", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void InfixPDFEditor()
        {
            string zipFile = Constants.FolderPDF + infixPDFEditor + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(infixPDFEditor, "Setup.exe", "/S /EN", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
        public static void PdfToJPG()
        {
            string zipFile = Constants.FolderPDF + pdfToJPG + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(pdfToJPG, "Setup.exe", "/silent", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void PdfToJPGConverter()
        {
            string zipFile = Constants.FolderPDF + pdfToJPGConverter + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(pdfToJPGConverter, "Setup.exe", "/silent", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void PdfShaper()
        {
            string zipFile = Constants.FolderPDF + pdfShaper + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(pdfShaper, "Setup.exe", "/silent", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }

        public static void PdfCreator()
        {
            string zipFile = Constants.FolderPDF + pdfCreator + Constants.ZipExtension;
            if (File.Exists(zipFile))
            {
                MainProgram.GetSetShowProgramFile = zipFile;
                MainProgram.ProgressAsync(pdfCreator, "Setup.exe", "/SILENT /NORESTART /NOCLOSEAPPLICATIONS /NORESTARTAPPLICATIONS", null, false);
            }
            else
            {
                Constants.MessageBoxExceptionFileExist(zipFile);
            }
        }
    }
}
