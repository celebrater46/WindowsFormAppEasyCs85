using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs85
{
    public partial class FormFadeInPicture : Form
    {
        private Image im;
        private int i;
        
        public FormFadeInPicture()
        {
            InitializeComponent();
            this.Text = "Fade In Picture";
            // this.Width = 400
            this.ClientSize = new Size(400, 300);
            this.BackColor = Color.Black;
            this.DoubleBuffered = true;

            im = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppEasyCs85\\WindowsFormsAppEasyCs85\\img\\sample.jpg");
            i = 0;
            
            Timer tm = new Timer();
            // tm.Interval = 50;
            tm.Start();

            tm.Tick += new EventHandler(TmTick);
            this.Paint += new PaintEventHandler(FmPaint);
        }

        public void FmPaint(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();
            
            // gp.AddEllipse(new Rectangle(0, 0, 400, 300));
            gp.AddEllipse(new Rectangle(0, 0, i * 4, i * 3));
            Region rg = new Region(gp);
            g.Clip = rg;
            
            // g.DrawImage(im, 0, 0, 400, 300);
            g.DrawImage(im, 0, 0, 400, 300);
        }

        public void TmTick(Object sender, EventArgs e)
        {
            Timer tm = (Timer) sender;
            if (i > (im.Width + 200) / 12)
            {
                // i = 0;
                tm.Stop();
            }
            else
            {
                i += 10;
            }
            this.Invalidate();
        }
    }
}