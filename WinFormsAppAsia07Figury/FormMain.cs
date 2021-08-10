using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppAsia07Figury
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red);
            Graphics gr;
            gr = this.CreateGraphics();
            Rectangle re = new Rectangle(10, 10, 50, 60);
            gr.DrawRectangle(pen, re);
            Rectangle re2 = new Rectangle(0, 0, 80, 80);
            gr.DrawRectangle(pen, re2);
            Point po1 = new Point(5, 8);
            Point po2 = new Point(180,150);
            Pen pen1 = new Pen(Color.Blue,5);
            gr.DrawLine(pen1, po1, po2);
            Rectangle re3 = new Rectangle(200, 200, 100, 150);
            gr.DrawEllipse(pen, re3);
            int nMax = 50;
            Random rnd = new Random();
            for (int i = 0; i <= nMax; i++)
            {
                re3.X = rnd.Next(300);
                re3.Y = rnd.Next(300);
                re3.Width = rnd.Next(300);
                re3.Height = rnd.Next(300);
                gr.DrawEllipse(pen, re3);


            }
        }
    }
}
