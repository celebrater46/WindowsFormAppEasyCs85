using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs85
{
    public partial class FormFadeInPicture : Form
    {
        private Image im;
        
        public FormFadeInPicture()
        {
            InitializeComponent();
            this.Text = "Fade In Picture";
            // this.Width = 400
            this.ClientSize = new Size(400, 300);
            this.BackColor = Color.Black;
            
            im = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppEasyCs85\\WindowsFormsAppEasyCs85\\img\\sample.jpg");

            this.Paint += new PaintEventHandler(FmPaint);
        }

        public void FmPaint(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();
            
            gp.AddEllipse(new Rectangle(0, 0, 400, 300));
            Region rg = new Region(gp);
            g.Clip = rg;
            
            g.DrawImage(im, 0, 0, 400, 300);
        }
    }
}