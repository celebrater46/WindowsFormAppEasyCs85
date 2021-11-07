using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs85
{
    public partial class Form1 : Form
    {
        private Label lb;
        private Button bt1, bt2;
        
        private Dictionary<string, int> scales = new Dictionary<string, int>(){
            {"top", 10},
            {"right", 10},
            {"bottom", 10},
            {"left", 10},
            {"lineHeight", 10},
            {"btWidth", 150},
            {"btHeight", 30},
        };
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Midterm Exam";
            this.Width = 400;
            this.Height = 300;

            lb = new Label();
            lb.Text = "This is a midterm exam.\nPlease push either button";
            this.Width = 200;
            this.Height = 100;


            bt1 = new Button();
            bt1.Text = "Graph";
            bt1.Width = scales["btWidth"];
            bt1.Height = scales["btHeight"];
            bt1.Top = lb.Bottom;
            
            bt2 = new Button();
            bt2.Text = "FadeIn a picture";
            bt2.Width = scales["btWidth"];
            bt2.Height = scales["btHeight"];
            bt2.Top = bt1.Bottom;
            
            lb.Parent = this;
            bt1.Parent = this;
            bt2.Parent = this;
            
        }
    }
}