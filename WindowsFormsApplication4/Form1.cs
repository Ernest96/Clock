using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{ 
     public partial class Form1 : Form
     {
          int x11 = 227, y11 = 145, x12 = 227, y12 = 170, x13 = 227, y13 = 195;
          int xs1 = 227, ys1 = 145, xs2 = 227, ys2 = 170, xs3 = 227, ys3 = 195;

     

          int cx = 227, cy = 290;
          Pen p = new Pen(Color.FromArgb(255, 255, 0, 0), 3);
          Pen p2 = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
          Pen p3 = new Pen(Color.FromArgb(255, 0, 0, 0), 7);

        
          public Form1()
          {
               InitializeComponent();
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               this.DoubleBuffered = true;
               this.Paint += new PaintEventHandler(Form1_Paint);
          }
          private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
          {
               e.Graphics.DrawImage(Properties.Resources.cl, 0, 0);
               e.Graphics.DrawLine(p, cx, cy, x11, y11);
               e.Graphics.DrawLine(p2, cx, cy, x12, y12);
               e.Graphics.DrawLine(p3, cx, cy, x13, y13);
          }

          private void timer1_Tick(object sender, EventArgs e)
          {
               double u1 = ((6 * DateTime.Now.Second) * 3.14159265 / 180);
               double u2 = ((6 * DateTime.Now.Minute) * 3.14159265 / 180);
               double u3 = ((30 * DateTime.Now.Hour + 0.5 * DateTime.Now.Minute) * 3.14159265 / 180);

              
               x11 = (int)(xs1 * Math.Cos(u1) - ys1 * Math.Sin(u1) + cx - cx * Math.Cos(u1) + cy * Math.Sin(u1));
               y11 = (int)(xs1 * Math.Sin(u1) + ys1 * Math.Cos(u1) + cy - cx * Math.Sin(u1) - cy * Math.Cos(u1));
               x12 = (int)(xs2 * Math.Cos(u2) - ys2 * Math.Sin(u2) + cx - cx * Math.Cos(u2) + cy * Math.Sin(u2));
               y12 = (int)(xs2 * Math.Sin(u2) + ys2 * Math.Cos(u2) + cy - cx * Math.Sin(u2) - cy * Math.Cos(u2));
               x13 = (int)(xs3 * Math.Cos(u3) - ys3 * Math.Sin(u3) + cx - cx * Math.Cos(u3) + cy * Math.Sin(u3));
               y13 = (int)(xs3 * Math.Sin(u3) + ys3 * Math.Cos(u3) + cy - cx * Math.Sin(u3) - cy * Math.Cos(u3));
               this.Refresh();
          }
     }
}
