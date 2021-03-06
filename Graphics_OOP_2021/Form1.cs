using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Graphics_OOP_2021
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }
        List<Figure> figure = new List<Figure>();
        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 0; 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;

            if (buttonr.Checked)
            {
                int rw = Math.Abs(x2 - x1);
                int rh = Math.Abs(y2 - y1);
                Rect r = new Rect(x1, y1, rh, rw);
                r.Draw(g);
                figure.Add(r);
            } 
            else if (buttonc.Checked)
            {
                double r = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)); 
                Circle c = new Circle(x1, y1, (int)r);
                c.Draw(g);
                figure.Add(c);
            }
            else //if (buttoncart.Checked)
            {
                int rw = Math.Abs(x2 - x1);
                int rh = Math.Abs(y2 - y1);
                Cart cart = new Cart(x1, y1, rh, rw);
                cart.Draw(g);
                figure.Add(cart);
            }
        }       
        private void Clear_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}
