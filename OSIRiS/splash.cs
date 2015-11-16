using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OSIRiS
{
    public partial class splash : Form
    {
        public splash()
        {

            InitializeComponent();
        }
        #region CUSTOM PAINT METHODS ----------------------------------------------
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00080000; // Required: set WS_EX_LAYERED extended style
                return cp;
            }
        }

        //Updates the Form's display using API calls
        public void UpdateFormDisplay(Image backgroundImage)
        {
            IntPtr screenDc = API.GetDC(IntPtr.Zero);
            IntPtr memDc = API.CreateCompatibleDC(screenDc);
            IntPtr hBitmap = IntPtr.Zero;
            IntPtr oldBitmap = IntPtr.Zero;

            try
            {
                //Display-image
                Bitmap bmp = new Bitmap(backgroundImage);
                hBitmap = bmp.GetHbitmap(Color.FromArgb(0));  //Set the fact that background is transparent
                oldBitmap = API.SelectObject(memDc, hBitmap);

                //Display-rectangle
                Size size = bmp.Size;
                Point pointSource = new Point(0, 0);
                Point topPos = new Point(this.Left, this.Top);

                //Set up blending options
                API.BLENDFUNCTION blend = new API.BLENDFUNCTION();
                blend.BlendOp = API.AC_SRC_OVER;
                blend.BlendFlags = 0;
                blend.SourceConstantAlpha = 255;
                blend.AlphaFormat = API.AC_SRC_ALPHA;

                API.UpdateLayeredWindow(this.Handle, screenDc, ref topPos, ref size, memDc, ref pointSource, 0, ref blend, API.ULW_ALPHA);

                //Clean-up
                bmp.Dispose();
                API.ReleaseDC(IntPtr.Zero, screenDc);
                if (hBitmap != IntPtr.Zero)
                {
                    API.SelectObject(memDc, oldBitmap);
                    API.DeleteObject(hBitmap);
                }
                API.DeleteDC(memDc);
            }
            catch (Exception)
            {
            }
        }
        #endregion

        private void splash_Load(object sender, EventArgs e)
        {
            UpdateFormDisplay(this.BackgroundImage);
            // Interval of 0,1 seconds

            if (File.Exists(@"resources\version.remote.txt"))
            {
                File.Delete(@"resources\version.remote.txt");
            }
            if (File.Exists(@"gpl.bak.txt"))
            {
                File.Delete(@"gpl.bak.txt");
            }
            if (File.Exists(@"OSIRiS_Manual.docx.bak"))
            {
                File.Delete(@"OSIRiS_Manual.docx.bak");
            }
            if (File.Exists(@"OSIRiS_Manual.pdf.bak"))
            {
                File.Delete(@"OSIRiS_Manual.pdf.bak");
            }
            if (File.Exists(@"latest.zip"))
            {
                File.Delete(@"latest.zip");
            }
            if (Directory.Exists(@"resources.bak"))
            {
                Directory.Delete(@"resources.bak", true);
            }
            if (Directory.Exists(@"backup"))
            {
                Directory.Delete(@"backup", true);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //Call our drawing function
            UpdateFormDisplay(this.BackgroundImage);
        } 

        
      }
    internal class API
    {
        public const byte AC_SRC_OVER = 0x00;
        public const byte AC_SRC_ALPHA = 0x01;
        public const Int32 ULW_ALPHA = 0x00000002;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;
        }

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pprSrc, Int32 crKey, ref BLENDFUNCTION pblend, Int32 dwFlags);


        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        [DllImport("user32.dll", ExactSpelling = true)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern bool DeleteDC(IntPtr hdc);


        [DllImport("gdi32.dll", ExactSpelling = true)]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern bool DeleteObject(IntPtr hObject);
    }

               
}




