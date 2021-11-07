using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs85
{
    public partial class FormGraph : Form
    {
        private int[] values = new[] {100, 30, 50, 60, 70};

        private Dictionary<string, int> scales = new Dictionary<string, int>()
        {
            {"graphTop", 30},
            // {"graphBottom", 120},
            {"graphWidth", 20},
        };
        
        public FormGraph()
        {
            InitializeComponent();
            this.Text = "Drawing a graph";
            this.Width = 400;
            this.Height = 200;
            this.Paint += new PaintEventHandler(FmPaint);
        }

        public void FmPaint(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, scales["graphWidth"]);
            for (int i = 0; i < values.Length; i++)
            {
                g.DrawRectangle(
                    pen, 
                    (scales["graphWidth"] + 30) * i + 20, 
                    // scales["graphBottom"], 
                    scales["graphTop"] + (100 - values[i]), 
                    scales["graphWidth"],
                    values[i]
                    );
            }
        }
    }
}