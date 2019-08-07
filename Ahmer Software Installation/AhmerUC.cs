using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ahmer_Software_Installation
{
    public partial class AhmerUC : UserControl
    {

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr font, uint ufont, IntPtr ptr, [In] ref uint myFonts);
        FontFamily fontFamily;
        Font font;

        public AhmerUC()
        {
            InitializeComponent();
        }

        private void LoadFont()
        {
            byte[] fontArray = Ahmer_Software_Installation.Properties.Resources.Ribbon_Heart;
            int dataLenght = Ahmer_Software_Installation.Properties.Resources.Ribbon_Heart.Length;

            IntPtr intPtr = Marshal.AllocCoTaskMem(dataLenght);
            Marshal.Copy(fontArray, 0, intPtr, dataLenght);
            uint uFonts = 0;

            AddFontMemResourceEx(intPtr, (uint)fontArray.Length, IntPtr.Zero, ref uFonts);
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddMemoryFont(intPtr, dataLenght);
            Marshal.FreeCoTaskMem(intPtr);
            fontFamily = privateFontCollection.Families[0];
            font = new Font(fontFamily, 15f, FontStyle.Bold);
        }

        private void AllocFont(Font f, Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            c.Font = new Font(fontFamily, size, fontStyle);
        }

        private void AhmerUC_Load(object sender, EventArgs e)
        {
            LoadFont();
            AllocFont(font, this.labelAhmerAfzal, 150);
        }
    }
}
