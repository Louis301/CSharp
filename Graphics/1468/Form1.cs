using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _468
{
    public partial class Form1 : Form
    {
        double picB_down = 420, nk_x = 267.5, nk_y = 210, k = 50, grad, grad2,
        nk_x2 = 267.5, nk_y2 = 210, ch;
        int i2 = 10, i3, t = 1, j, kol_gr = 0;
        string s = "", s1 = "", s2 = "", s3 = "", s4 = "", color;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //inizialization koord
            nk_x2 = e.X;
            nk_y2 = e.Y;
            textBox2.Text = Convert.ToString(nk_x2);
            textBox3.Text = Convert.ToString(nk_y2);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //draw setka
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            grad = grad2 = k;
            if (k >= 20) ch = k / 20; else ch = 1;

            if (nk_x2 != nk_x || nk_y2 != nk_y) {
                g.FillRectangle(System.Drawing.Brushes.WhiteSmoke, 0, 0, 
                               Convert.ToInt32(pictureBox1.Right), 
                               Convert.ToInt32(430)); 
                nk_x = nk_x2;
                nk_y = nk_y2; 
             }
             double x = nk_x, y = nk_y;

            g.DrawLine(new Pen(Color.Black, 1), 0, Convert.ToInt32(nk_y), pictureBox1.Right,
                                                   Convert.ToInt32(nk_y));
            g.DrawLine(new Pen(Color.Black, 1), Convert.ToInt32(nk_x), 0,
                                                Convert.ToInt32(nk_x),
                                                Convert.ToInt32(picB_down));

            while (x <= pictureBox1.Right && x >= nk_x)
            {
                g.DrawLine(new Pen(Color.Black, 1), Convert.ToInt32(x + grad),
                                                    Convert.ToInt32(nk_y - ch),
                                                    Convert.ToInt32(x + grad),
                                                    Convert.ToInt32(nk_y + ch));
                x += grad;
            } x = nk_x;
            while (x >= 0 && x <= nk_x)
            {
                g.DrawLine(new Pen(Color.Black, 1),
                    Convert.ToInt32(x - grad),
                    Convert.ToInt32(nk_y - ch),
                    Convert.ToInt32(x - grad),
                    Convert.ToInt32(nk_y + ch));
                x -= grad;
            } x = nk_x;
            while (y >= 0 && y <= nk_y)
            {
                g.DrawLine(new Pen(Color.Black, 1),
                    Convert.ToInt32(nk_x - ch),
                    Convert.ToInt32(y - grad2),
                    Convert.ToInt32(nk_x + ch),
                    Convert.ToInt32(y - grad2));
                y -= grad2;
            } y = nk_y;
            while (y <= picB_down && y >= nk_y)
            {
                g.DrawLine(new Pen(Color.Black, 1),
                    Convert.ToInt32(nk_x - ch),
                    Convert.ToInt32(y + grad2),
                    Convert.ToInt32(nk_x + ch),
                    Convert.ToInt32(y + grad2));
                y += grad2;                                        
            }
            textBox1.Text = Convert.ToString(trackBar1.Value) + "   " + Convert.ToString(k);


           

                //draw graphics 
            double x1 = -nk_x, y1 = 0, x_n = x1 - 1, y_n = y1, y_k, x_k, predel1 = nk_x + Math.PI / 2; 

                for (j = 0; j <= kol_gr; j++)
                {
                    
                    
                    while (x1 >= -nk_x && x1 < pictureBox1.Right)
                    {
                        if (j == 0) { s = s1; color = "Blue"; }
                        if (j == 1) { s = s2; color = "Red"; }
                        if (j == 2) { s = s3; color = "Orange"; }
                        if (j == 3) { s = s4; color = "Green"; }
                        x1++;
                        if (s == "") break;
                        if (s == "sin x") y1 = Convert.ToDouble(Math.Sin(x1 / k));
                        if (s == "cos x") y1 = Convert.ToDouble(Math.Cos(x1 / k));
                        if (s == "tg x") y1 = Convert.ToDouble(Math.Tan(x1 / k));
                        if (s == "ctg x") y1 = Convert.ToDouble(1 / Math.Tan(x1 / k));
                        if (s == "log(x, 2)")
                        {
                            if (x1 <= 0) { x_n = x1 + 1; y_n = picB_down; continue; }
                            if (x1 > 0)
                            {
                                y1 = Convert.ToDouble(Math.Log(x1 / k, 2));
                                if (x1 == 1) { x_n = x1 + 1; y_n = y1 * -k; }
                            }
                        }
                        if (s == "lg(x)")
                        {
                            if (x1 <= 0) { x_n = x1 + 1; y_n = picB_down; continue; }
                            if (x1 > 0)
                            {
                                y1 = Convert.ToDouble(Math.Log(x1 / k, 10));
                                if (x1 == 1) { x_n = x1 + 1; y_n = y1 * -k; }
                            }
                        }
                        if (s == "ln(x)")
                        {
                            if (x1 <= 0) { x_n = x1 + 1; y_n = picB_down; continue; }
                            if (x1 > 0)
                            {
                                y1 = Convert.ToDouble(Math.Log(x1 / k, Math.E));
                                if (x1 == 1) { x_n = x1 + 1; y_n = y1 * -k; }
                            }
                        }
                        if (s == "1 / x" && x1 != 0) y1 = Convert.ToDouble(1 / (x1 / k));
                        if (s == "x^2") y1 = Convert.ToDouble(Math.Pow(x1 / k, 2));
                        if (s == "x^3") y1 = Convert.ToDouble(Math.Pow(x1 / k, 3));
                        if (s == "x") y1 = Convert.ToDouble(x1 / k);

                        y1 *= -k;
                        x_k = x1; y_k = y1;
                        if (x1 == -nk_x + 1 && y1 <= picB_down && x1 <= pictureBox1.Right &&
                            y1 >= -nk_y && x1 >= -nk_x) { x_n = x1 - 1; y_n = y1 - 1; }

                        if (y1 > -nk_y && y1 < picB_down)
                        {
                            g.DrawLine(new Pen(Color.FromName(color), 2), Convert.ToInt32(nk_x) + Convert.ToInt32(x_n),
                                                                Convert.ToInt32(nk_y) + Convert.ToInt32(y_n),
                                                                Convert.ToInt32(nk_x) + Convert.ToInt32(x_k),
                                                                Convert.ToInt32(nk_y) + Convert.ToInt32(y_k));
                            
                        }
                        x_n = x_k; y_n = y_k;
                    }
                    x1 = -nk_x; y1 = 0; x_n = x1 - 1; y_n = y1; 
                }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //delete setka
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            grad = grad2 = k;
            if (k >= 20) ch = k / 20; else ch = 1;

            if (nk_x2 != nk_x || nk_y2 != nk_y)
            {
                g.FillRectangle(System.Drawing.Brushes.WhiteSmoke, 0, 0,
                               Convert.ToInt32(pictureBox1.Right),
                               Convert.ToInt32(430));
                nk_x = nk_x2;
                nk_y = nk_y2;
            }
            double x = nk_x, y = nk_y;
            double x1 = -nk_x, y1 = 0, x_n = x1 - 1, y_n = y1, y_k, x_k;

            i2 = trackBar1.Value;
            if (trackBar1.Value == 0) i2 = i3;

            g.DrawLine(new Pen(Color.WhiteSmoke, 1), 0, Convert.ToInt32(nk_y), pictureBox1.Right,
                                                   Convert.ToInt32(nk_y));
            g.DrawLine(new Pen(Color.WhiteSmoke, 1), Convert.ToInt32(nk_x), 0,
                                                Convert.ToInt32(nk_x),
                                                Convert.ToInt32(picB_down));

            while (x <= pictureBox1.Right && x >= nk_x)
            {
                g.DrawLine(new Pen(Color.WhiteSmoke, 1), Convert.ToInt32(x + grad),
                                                    Convert.ToInt32(nk_y - ch),
                                                    Convert.ToInt32(x + grad),
                                                    Convert.ToInt32(nk_y + ch));
                x += grad;
            } x = nk_x;
            while (x >= 0 && x <= nk_x)
            {
                g.DrawLine(new Pen(Color.WhiteSmoke, 1),
                    Convert.ToInt32(x - grad),
                    Convert.ToInt32(nk_y - ch),
                    Convert.ToInt32(x - grad),
                    Convert.ToInt32(nk_y + ch));
                x -= grad;
            } x = nk_x;
            while (y >= 0 && y <= nk_y)
            {
                g.DrawLine(new Pen(Color.WhiteSmoke, 1),
                    Convert.ToInt32(nk_x - ch),
                    Convert.ToInt32(y - grad2),
                    Convert.ToInt32(nk_x + ch),
                    Convert.ToInt32(y - grad2));
                y -= grad2;
            } y = nk_y;
            while (y <= picB_down && y >= nk_y)
            {
                g.DrawLine(new Pen(Color.WhiteSmoke, 1),
                    Convert.ToInt32(nk_x - ch),
                    Convert.ToInt32(y + grad2),
                    Convert.ToInt32(nk_x + ch),
                    Convert.ToInt32(y + grad2));
                y += grad2;
            }
            
            //delete graphics
            for (j = 0; j <= kol_gr; j++)
            {


                while (x1 >= -nk_x && x1 < pictureBox1.Right)
                {
                    if (j == 0) { s = s1; }
                    if (j == 1) { s = s2; }
                    if (j == 2) { s = s3; }
                    if (j == 3) { s = s4; }
                    color = "WhiteSmoke";
                    x1++;
                    if (s == "") break;
                    if (s == "sin x") y1 = Convert.ToDouble(Math.Sin(x1 / k));
                    if (s == "cos x") y1 = Convert.ToDouble(Math.Cos(x1 / k));
                    if (s == "tg x") y1 = Convert.ToDouble(Math.Tan(x1 / k));
                    if (s == "ctg x") y1 = Convert.ToDouble(1 / Math.Tan(x1 / k));
                    if (s == "log(x, 2)")
                    {
                        if (x1 <= 0) { x_n = x1 + 1; y_n = picB_down; continue; }
                        if (x1 > 0)
                        {
                            y1 = Convert.ToDouble(Math.Log(x1 / k, 2));
                            if (x1 == 1) { x_n = x1 + 1; y_n = y1 * -k; }
                        }
                    }
                    if (s == "lg(x)")
                    {
                        if (x1 <= 0) { x_n = x1 + 1; y_n = picB_down; continue; }
                        if (x1 > 0)
                        {
                            y1 = Convert.ToDouble(Math.Log(x1 / k, 10));
                            if (x1 == 1) { x_n = x1 + 1; y_n = y1 * -k; }
                        }
                    }
                    if (s == "ln(x)")
                    {
                        if (x1 <= 0) { x_n = x1 + 1; y_n = picB_down; continue; }
                        if (x1 > 0)
                        {
                            y1 = Convert.ToDouble(Math.Log(x1 / k, Math.E));
                            if (x1 == 1) { x_n = x1 + 1; y_n = y1 * -k; }
                        }
                    }
                    if (s == "1 / x" && x1 != 0) y1 = Convert.ToDouble(1 / (x1 / k));
                    if (s == "x^2") y1 = Convert.ToDouble(Math.Pow(x1 / k, 2));
                    if (s == "x^3") y1 = Convert.ToDouble(Math.Pow(x1 / k, 3));
                    if (s == "x") y1 = Convert.ToDouble(x1 / k);

                    y1 *= -k;
                    x_k = x1; y_k = y1;
                    if (x1 == -nk_x + 1 && y1 <= picB_down && x1 <= pictureBox1.Right &&
                        y1 >= -nk_y && x1 >= -nk_x) { x_n = x1 - 1; y_n = y1 - 1; }

                    if (y1 > -nk_y && y1 < picB_down)
                    {
                        g.DrawLine(new Pen(Color.FromName(color), 2), Convert.ToInt32(nk_x) + Convert.ToInt32(x_n),
                                                            Convert.ToInt32(nk_y) + Convert.ToInt32(y_n),
                                                            Convert.ToInt32(nk_x) + Convert.ToInt32(x_k),
                                                            Convert.ToInt32(nk_y) + Convert.ToInt32(y_k));

                    }
                    x_n = x_k; y_n = y_k;
                }
                x1 = -nk_x; y1 = 0; x_n = x1 - 1; y_n = y1;
            }
            k = i2 * 5;
            i3 = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = "";
            if (t == 1)
            {
                if (textBox5.Text == "sin x") s1 = s = textBox5.Text;
                if (textBox5.Text == "cos x") s1 = s = textBox5.Text;
                if (textBox5.Text == "tg x")  s1 = s = textBox5.Text;
                if (textBox5.Text == "ctg x") s1 = s = textBox5.Text;
                if (textBox5.Text == "log(x, 2)") s1 = s = textBox5.Text;
                if (textBox5.Text == "lg(x)") s1 = s = textBox5.Text;
                if (textBox5.Text == "ln(x)") s1 = s = textBox5.Text;
                if (textBox5.Text == "1 / x") s1 = s = textBox5.Text;
                if (textBox5.Text == "x") s1 = s = textBox5.Text;
                if (textBox5.Text == "x^2") s1 = s = textBox5.Text;
                if (textBox5.Text == "x^3") s1 = s = textBox5.Text;
            }
            if (t == 2)
            {
                if (textBox6.Text == "sin x") s2 = s = textBox6.Text;
                if (textBox6.Text == "cos x") s2 = s = textBox6.Text;
                if (textBox6.Text == "tg x") s2= s = textBox6.Text;
                if (textBox6.Text == "ctg x") s2 = s = textBox6.Text;
                if (textBox6.Text == "log(x, 2)") s2 = s = textBox6.Text;
                if (textBox6.Text == "lg(x)") s2 = s = textBox6.Text;
                if (textBox6.Text == "ln(x)") s2 = s = textBox6.Text;
                if (textBox6.Text == "1 / x") s2 = s = textBox6.Text;
                if (textBox6.Text == "x") s2 = s = textBox6.Text;
                if (textBox6.Text == "x^2") s2 = s = textBox6.Text;
                if (textBox6.Text == "x^3") s2 = s = textBox6.Text;
            }
            if (t == 3)
            {
                if (textBox7.Text == "sin x") s3 = s = textBox7.Text;
                if (textBox7.Text == "cos x") s3 = s = textBox7.Text;
                if (textBox7.Text == "tg x") s3 = s = textBox7.Text;
                if (textBox7.Text == "ctg x") s3 = s = textBox7.Text;
                if (textBox7.Text == "log(x, 2)") s3 = s = textBox7.Text;
                if (textBox7.Text == "lg(x)") s3 = s = textBox7.Text;
                if (textBox7.Text == "ln(x)") s3 = s = textBox7.Text;
                if (textBox7.Text == "1 / x") s3 = s = textBox7.Text;
                if (textBox7.Text == "x") s3 = s = textBox7.Text;
                if (textBox7.Text == "x^2") s3 = s = textBox7.Text;
                if (textBox7.Text == "x^3") s3 = s = textBox7.Text;
            }
            if (t == 4)
            {
                if (textBox8.Text == "sin x") s4 = s = textBox8.Text;
                if (textBox8.Text == "cos x") s4 = s = textBox8.Text;
                if (textBox8.Text == "tg x") s4 = s = textBox8.Text;
                if (textBox8.Text == "ctg x") s4 = s = textBox8.Text;
                if (textBox8.Text == "log(x, 2)") s4 = s = textBox8.Text;
                if (textBox8.Text == "lg(x)") s4 = s = textBox8.Text;
                if (textBox8.Text == "ln(x)") s4 = s = textBox8.Text;
                if (textBox8.Text == "1 / x") s4 = s = textBox8.Text;
                if (textBox8.Text == "x") s4 = s = textBox8.Text;
                if (textBox8.Text == "x^2") s4 = s = textBox8.Text;
                if (textBox8.Text == "x^3") s4 = s = textBox8.Text;
            }
            if (s != "")
            {
                if (t >= 1 && t <= 4) ++t;
                if (t == 2) { label2.Text = "2"; kol_gr = 1; }
                if (t == 3) { label3.Text = "3"; kol_gr = 2; }
                if (t == 4) { label4.Text = "4"; kol_gr = 3; }
                if (t == 5) { label4.Text = "4"; kol_gr = 4; }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            timer1.Enabled = false;

            if (kol_gr == 1)
            {
                textBox5.Text = "";
                s1 = "";
                label2.Text = "                                 ";
                t = 1;
            }
            if (kol_gr == 2)
            {
                textBox6.Text = "";
                s2 = "";
                kol_gr = 1;
                label3.Text = "                                 ";
                t = 2;
            }
            if (kol_gr == 3)
            {
                textBox7.Text = "";
                s3 = "";
                kol_gr = 2;
                label4.Text = "                                 ";
                t = 3;
            }
            if (kol_gr == 4)
            {
                if (s != "")
                {
                    textBox8.Text = "";
                    s4 = "";
                    kol_gr = 3;
                    t = 4;
                }
                if (s == "")
                {
                    t = 3;
                    label4.Text = "                                 ";
                }
            }

            double x = nk_x, y = nk_y;

            g.FillRectangle(System.Drawing.Brushes.WhiteSmoke, 0, 0, Convert.ToInt32(pictureBox1.Right), 
                Convert.ToInt32(picB_down));

            double x1 = -nk_x, y1 = 0, x_n = x1 - 1, y_n = y1, y_k, x_k;
            while (x1 >= -nk_x && x1 < pictureBox1.Right)
            {
                x1++;
                if (s == "sin x") y1 = Convert.ToDouble(Math.Sin(x1 / k));
                if (s == "cos x") y1 = Convert.ToDouble(Math.Cos(x1 / k));
                if (s == "tg x") y1 = Convert.ToDouble(Math.Tan(x1 / k));
                if (s == "ctg x") y1 = Convert.ToDouble(1 / Math.Tan(x1 / k));
                if (s == "") break;
                if (s == "log(x, 2)")
                {
                    if (x1 <= 0) { x_n = x1 + 1; y_n = picB_down; continue; }
                    if (x1 > 0)
                    {
                        y1 = Convert.ToDouble(Math.Log(x1 / k, 2));
                        if (x1 == 1) { x_n = x1 + 1; y_n = y1 * -k; }
                    }
                }
                if (s == "lg(x)")
                {
                    if (x1 <= 0) { x_n = x1 + 1; y_n = picB_down; continue; }
                    if (x1 > 0)
                    {
                        y1 = Convert.ToDouble(Math.Log(x1 / k, 10));
                        if (x1 == 1) { x_n = x1 + 1; y_n = y1 * -k; }
                    }
                }
                if (s == "ln(x)")
                {
                    if (x1 <= 0) { x_n = x1 + 1; y_n = picB_down; continue; }
                    if (x1 > 0)
                    {
                        y1 = Convert.ToDouble(Math.Log(x1 / k, Math.E));
                        if (x1 == 1) { x_n = x1 + 1; y_n = y1 * -k; }
                    }
                }
                if (s == "1 / x" && x1 != 0) y1 = Convert.ToDouble(1 / (x1 / k));
                if (s == "x^2") y1 = Convert.ToDouble(Math.Pow(x1 / k, 2));
                if (s == "x^3") y1 = Convert.ToDouble(Math.Pow(x1 / k, 3));
                if (s == "x") y1 = Convert.ToDouble(x1 / k);
                y1 *= -k;
                x_k = x1; y_k = y1;
                if (x1 == -nk_x + 1 && y1 <= picB_down && x1 <= pictureBox1.Right && y1 >= -nk_y && x1 >= -nk_x) { x_n = x1 - 1; y_n = y1 - 1; }

                if (y1 > -nk_y && y1 < picB_down)
                {
                    g.DrawLine(new Pen(Color.WhiteSmoke, 2), Convert.ToInt32(nk_x) + Convert.ToInt32(x_n),
                                                        Convert.ToInt32(nk_y) + Convert.ToInt32(y_n),
                                                        Convert.ToInt32(nk_x) + Convert.ToInt32(x_k),
                                                        Convert.ToInt32(nk_y) + Convert.ToInt32(y_k));
                }
                x_n = x_k; y_n = y_k;
            }
            
            g.DrawLine(new Pen(Color.Black, 1), 0, Convert.ToInt32(nk_y), pictureBox1.Right,
                                                   Convert.ToInt32(nk_y));
            g.DrawLine(new Pen(Color.Black, 1), Convert.ToInt32(nk_x), 0,
                                                Convert.ToInt32(nk_x),
                                                Convert.ToInt32(picB_down));

            while (x <= pictureBox1.Right && x >= nk_x)
            {
                g.DrawLine(new Pen(Color.Black, 1), Convert.ToInt32(x + grad),
                                                    Convert.ToInt32(nk_y - ch),
                                                    Convert.ToInt32(x + grad),
                                                    Convert.ToInt32(nk_y + ch));
                x += grad;
            } x = nk_x;
            while (x >= 0 && x <= nk_x)
            {
                g.DrawLine(new Pen(Color.Black, 1),
                    Convert.ToInt32(x - grad),
                    Convert.ToInt32(nk_y - ch),
                    Convert.ToInt32(x - grad),
                    Convert.ToInt32(nk_y + ch));
                x -= grad;
            } x = nk_x;
            while (y >= 0 && y <= nk_y)
            {
                g.DrawLine(new Pen(Color.Black, 1),
                    Convert.ToInt32(nk_x - ch),
                    Convert.ToInt32(y - grad2),
                    Convert.ToInt32(nk_x + ch),
                    Convert.ToInt32(y - grad2));
                y -= grad2;
            } y = nk_y;
            while (y <= picB_down && y >= nk_y)
            {
                g.DrawLine(new Pen(Color.Black, 1),
                    Convert.ToInt32(nk_x - ch),
                    Convert.ToInt32(y + grad2),
                    Convert.ToInt32(nk_x + ch),
                    Convert.ToInt32(y + grad2));
                y += grad2;
            }
            s = "";
            timer1.Enabled = true; 
            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t == 1) textBox5.Text = "sin x";
            if (t == 2) textBox6.Text = "sin x";
            if (t == 3) textBox7.Text = "sin x";
            if (t == 4) textBox8.Text = "sin x";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (t == 1) textBox5.Text = "cos x";
            if (t == 2) textBox6.Text = "cos x";
            if (t == 3) textBox7.Text = "cos x";
            if (t == 4) textBox8.Text = "cos x";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (t == 1) textBox5.Text = "tg x";
            if (t == 2) textBox6.Text = "tg x";
            if (t == 3) textBox7.Text = "tg x";
            if (t == 4) textBox8.Text = "tg x";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (t == 1) textBox5.Text = "ctg x";
            if (t == 2) textBox6.Text = "ctg x";
            if (t == 3) textBox7.Text = "ctg x";
            if (t == 4) textBox8.Text = "ctg x";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (t == 1) textBox5.Text = "log(x, 2)";
            if (t == 2) textBox6.Text = "log(x, 2)";
            if (t == 3) textBox7.Text = "log(x, 2)";
            if (t == 4) textBox8.Text = "log(x, 2)";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (t == 1) textBox5.Text = "lg(x)";
            if (t == 2) textBox6.Text = "lg(x)";
            if (t == 3) textBox7.Text = "lg(x)";
            if (t == 4) textBox8.Text = "lg(x)";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (t == 1) textBox5.Text = "ln(x)";
            if (t == 2) textBox6.Text = "ln(x)";
            if (t == 3) textBox7.Text = "ln(x)";
            if (t == 4) textBox8.Text = "ln(x)";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (t == 1) textBox5.Text = "1 / x";
            if (t == 2) textBox6.Text = "1 / x";
            if (t == 3) textBox7.Text = "1 / x";
            if (t == 4) textBox8.Text = "1 / x";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (t == 1) textBox5.Text = "x^2";
            if (t == 2) textBox6.Text = "x^2";
            if (t == 3) textBox7.Text = "x^2";
            if (t == 4) textBox8.Text = "x^2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (t == 1) textBox5.Text = "x^3";
            if (t == 2) textBox6.Text = "x^3";
            if (t == 3) textBox7.Text = "x^3";
            if (t == 4) textBox8.Text = "x^3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (t == 1) textBox5.Text = "x";
            if (t == 2) textBox6.Text = "x";
            if (t == 3) textBox7.Text = "x";
            if (t == 4) textBox8.Text = "x";
        }

           
   }
}