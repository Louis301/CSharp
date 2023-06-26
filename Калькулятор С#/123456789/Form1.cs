using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _23456789
{
    public partial class Form1 : Form
    {
        int ro = 10;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            radioButton1.Checked = true;
            label3.Text = "ON";
            label1.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string x;
            int x1;

            if (radioButton1.Checked == true)
            {
                x = textBox1.Text;
                if (x.Length > 0)
                {
                    x1 = x.Length - 1;
                    x = x.Remove(x1);
                    textBox1.Text = Convert.ToString(x);
                }
            }

            if (radioButton2.Checked == true)
            {
                x = textBox2.Text;
                if (x.Length > 0)
                {
                    x1 = x.Length - 1;
                    x = x.Remove(x1);
                    textBox2.Text = Convert.ToString(x);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "1";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "2";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "0";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = true;
        }


        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "3";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "4";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "4";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "5";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "6";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "7";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "8";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "8";
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "9";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "9";
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + ",";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + ",";
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string s;

            if (radioButton1.Checked == true)
            {
                s = textBox1.Text;
                if (s[0] == '-') { s = s.Remove(0, 1); textBox1.Text = s; }
                else { textBox1.Text = "-" + textBox1.Text; }
            }

            if (radioButton2.Checked == true)
            {
                s = textBox2.Text;
                if (s[0] == '-') { s = s.Remove(0, 1); textBox2.Text = s; }
                else { textBox2.Text = "-" + textBox2.Text; }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double a = Convert.ToSingle (textBox1.Text);
            double b = Convert.ToSingle (textBox2.Text);
            double c;
            c = Math.Pow (a, b);
            radioButton1.Checked = true;
            textBox3.Text = Convert.ToString(c);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double a;
            double c;
            if (radioButton1.Checked == true)
            {
                a = Convert.ToSingle(textBox1.Text);
                c = Math.Pow(a, 2);
                
                textBox3.Text = Convert.ToString(c);
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                c = Math.Pow(a, 2);
             
                textBox3.Text = Convert.ToString(c);
            }
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double a;
            double c;
            if (radioButton1.Checked == true)
            {
                a = Convert.ToSingle(textBox1.Text);
                c = Math.Pow(a, 3);
                
                textBox3.Text = Convert.ToString(c);
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                c = Math.Pow(a, 3);
       
                textBox3.Text = Convert.ToString(c);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double a;
            double c;

            if (radioButton1.Checked == true)
            {
                a = Convert.ToSingle(textBox1.Text);
                c = Math.Abs(a);
                radioButton1.Checked = true;
                textBox3.Text = Convert.ToString(c);
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                c = Math.Abs(a);
                radioButton1.Checked = true;
                textBox3.Text = Convert.ToString(c);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double a = Convert.ToSingle(textBox1.Text);;
            double b = Convert.ToSingle(textBox2.Text);;
            double c;
            b = 1 / b;
            c = Math.Pow(a, b);
            radioButton1.Checked = true;
            textBox3.Text = Convert.ToString(c);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double a;
            double c;
            

            if (radioButton1.Checked == true)
            {
                a = Convert.ToSingle(textBox1.Text);
                c = Math.Sqrt(a);
               
                textBox3.Text = Convert.ToString(c);
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                c = Math.Sqrt(a);
               
                textBox3.Text = Convert.ToString(c);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double a;
            double c;
            
            double b = 0.333333333333333333333333;

            if (radioButton1.Checked == true)
            {
                a = Convert.ToSingle(textBox1.Text);
                c = Math.Pow(a, b);
     
                textBox3.Text = Convert.ToString(c);
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                c = Math.Pow(a, b);
             
                textBox3.Text = Convert.ToString(c);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            if (radioButton1.Checked == true)
            {
                a = Convert.ToSingle(textBox1.Text);
                b = (Math.PI * a) / 180;
                textBox3.Text = Convert.ToString(Math.Sin(b));
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                b = (Math.PI * a) / 180;
                textBox3.Text = Convert.ToString(Math.Sin(b));
            }
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            if (radioButton1.Checked == true)
            {
                a = Convert.ToSingle(textBox1.Text);
                b = (Math.PI * a) / 180;
                textBox3.Text = Convert.ToString(Math.Cos(b));
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                b = (Math.PI * a) / 180;
                textBox3.Text = Convert.ToString(Math.Cos(b));
            }
          
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            if (radioButton1.Checked == true)
            {
                a = Convert.ToSingle(textBox1.Text);
                b = (Math.PI * a) / 180;
                textBox3.Text = Convert.ToString(Math.Tan(b));
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                b = (Math.PI * a) / 180;
                textBox3.Text = Convert.ToString(Math.Tan(b));
            }
            
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double a;
            double b;

            if (radioButton1.Checked == true)
            {
                a = Convert.ToSingle(textBox1.Text);
                b = Math.Asin(a);
                b = (180 * b) / Math.PI;
                b = Math.Round(b);
                textBox3.Text = Convert.ToString(b);
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                b = Math.Asin(a);
                b = (180 * b) / Math.PI;
                b = Math.Round(b);
                textBox3.Text = Convert.ToString(b);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double a;
            double b;

            if (radioButton1.Checked == true)
            {
                a = Convert.ToSingle(textBox1.Text);
                b = Math.Acos(a);
                b = (180 * b) / Math.PI;
                b = Math.Round(b);
                textBox3.Text = Convert.ToString(b);
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                b = Math.Acos(a);
                b = (180 * b) / Math.PI;
                b = Math.Round(b);
                textBox3.Text = Convert.ToString(b);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double a;
            double b;

            if (radioButton1.Checked == true)
            {
                a = Convert.ToSingle(textBox1.Text);
                b = Math.Atan(a);
                b = (180 * b) / Math.PI;
                b = Math.Round(b);
                textBox3.Text = Convert.ToString(b);
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                b = Math.Atan(a);
                b = (180 * b) / Math.PI;
                b = Math.Round(b);
                textBox3.Text = Convert.ToString(b);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true) textBox1.Text = Convert.ToString(Math.E);
            if (radioButton2.Checked == true) textBox2.Text = Convert.ToString(Math.E);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = Convert.ToString(Math.PI);
            if (radioButton2.Checked == true) textBox2.Text = Convert.ToString(Math.PI);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            double a = Convert.ToSingle(textBox1.Text);
            double b = Convert.ToSingle(textBox2.Text); ;
            double c  = Math.Log(a, b);
            textBox3.Text = Convert.ToString(c);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double a;
            double c;
            if(radioButton1.Checked == true) 
            {
                a = Convert.ToSingle(textBox1.Text);
                c = Math.Log(a, 10);
                textBox3.Text = Convert.ToString(c);
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                c = Math.Log(a, 10);
                textBox3.Text = Convert.ToString(c);
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double a;
            double c;
            if (radioButton1.Checked == true)
            {
                a = Convert.ToSingle(textBox1.Text);
                c = Math.Log(a, Math.E);
                textBox3.Text = Convert.ToString(c);
            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToSingle(textBox2.Text);
                c = Math.Log(a, Math.E);
                textBox3.Text = Convert.ToString(c);
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "a";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "a";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "b";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "b";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "c";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "c";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "d";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "d";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "e";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "e";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) textBox1.Text = textBox1.Text + "f";
            if (radioButton2.Checked == true) textBox2.Text = textBox2.Text + "f";
        }


        //System Of Numbers---------------------------------------------------------    
        
        
        private void button4_Click(object sender, EventArgs e)
        {
        
            float a; int a1; string s = textBox1.Text;
            float b; int b1; string s1 = textBox2.Text;
            float c; int c1;

            if (ro == 10)
            {
                a = Convert.ToSingle(textBox1.Text);
                b = Convert.ToSingle(textBox2.Text);
                textBox3.Text = Convert.ToString(a + b);
            }
            if (ro != 10)
            {
                a1 = Convert.ToInt32(plasDec(s, ro));
                b1 = Convert.ToInt32(plasDec(s1, ro));
                c1 = a1 + b1;
                textBox3.Text = Convert.ToString(c1, ro);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            float a; int a1; string s = textBox1.Text;
            float b; int b1; string s1 = textBox2.Text;
            float c; int c1;

            if (ro == 10)
            {
                a = Convert.ToSingle(textBox1.Text);
                b = Convert.ToSingle(textBox2.Text);
                textBox3.Text = Convert.ToString(a - b);
            }
            if (ro != 10)
            {
                a1 = Convert.ToInt32(plasDec(s, ro));
                b1 = Convert.ToInt32(plasDec(s1, ro));
                c1 = a1 - b1;
                textBox3.Text = Convert.ToString(c1, ro);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            float a; int a1; string s = textBox1.Text;
            float b; int b1; string s1 = textBox2.Text;
            float c; int c1;

            if (ro == 10)
            {
                a = Convert.ToSingle(textBox1.Text);
                b = Convert.ToSingle(textBox2.Text);
                textBox3.Text = Convert.ToString(a * b);
            }
            if (ro != 10)
            {
                a1 = Convert.ToInt32(plasDec(s, ro));
                b1 = Convert.ToInt32(plasDec(s1, ro));
                c1 = a1 * b1;
                textBox3.Text = Convert.ToString(c1, ro);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
      
            float a; int a1; string s = textBox1.Text;
            float b; int b1; string s1 = textBox2.Text;
            float c; int c1;

            if (ro == 10)
            {
                a = Convert.ToSingle(textBox1.Text);
                b = Convert.ToSingle(textBox2.Text);
                textBox3.Text = Convert.ToString(a / b);
            }
            if (ro != 10)
            {
                a1 = Convert.ToInt32(plasDec(s, ro));
                b1 = Convert.ToInt32(plasDec(s1, ro));
                c1 = a1 / b1;
                textBox3.Text = Convert.ToString(c1, ro);
            }
        }


        //16----------------------------------------------------------------
        private void button43_Click(object sender, EventArgs e)
        {
            label1.Text = "ON";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            string s = textBox1.Text;
            string s1 = textBox2.Text;
            string s3 = textBox3.Text;
            string s2;
            int a;
            if (s.Length > 0)
            {
                if (ro == 16) textBox1.Text = s;
                if (ro == 10)
                {
                    a = Convert.ToInt32(s);
                    textBox1.Text = Convert.ToString(a, 16);
                }
                if (ro == 2)
                {
                    s2 = Convert.ToString(plasDec(s, 2));
                    a = Convert.ToInt32(s2);
                    textBox1.Text = Convert.ToString(a, 16);
                }
                if (ro == 8)
                {
                    s2 = Convert.ToString(plasDec(s, 8));
                    a = Convert.ToInt32(s2);
                    textBox1.Text = Convert.ToString(a, 16);
                }
            }

            if (s1.Length > 0)
            {
                if (ro == 16) textBox2.Text = s1;
                if (ro == 10)
                {
                    a = Convert.ToInt32(s1);
                    textBox2.Text = Convert.ToString(a, 16);
                }
                if (ro == 2)
                {
                    s2 = Convert.ToString(plasDec(s1, 2));
                    a = Convert.ToInt32(s2);
                    textBox2.Text = Convert.ToString(a, 16);
                }
                if (ro == 8)
                {
                    s2 = Convert.ToString(plasDec(s1, 8));
                    a = Convert.ToInt32(s2);
                    textBox2.Text = Convert.ToString(a, 16);
                }
            }

            if (s3.Length > 0)
            {
                if (ro == 16) textBox3.Text = s3;
                if (ro == 10)
                {
                    a = Convert.ToInt32(s3);
                    textBox3.Text = Convert.ToString(a, 16);
                }
                if (ro == 2)
                {
                    s2 = Convert.ToString(plasDec(s3, 2));
                    a = Convert.ToInt32(s2);
                    textBox3.Text = Convert.ToString(a, 16);
                }
                if (ro == 8)
                {
                    s2 = Convert.ToString(plasDec(s3, 8));
                    a = Convert.ToInt32(s2);
                    textBox3.Text = Convert.ToString(a, 16);
                }
            }

            ro = 16;
        }

        //10----------------------------------------------------------------
        private void button44_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label3.Text = "ON";
            label4.Text = "";
            label5.Text = "";
            string s = textBox1.Text;
            string s1 = textBox2.Text;
            string s3 = textBox3.Text;

            if (s.Length > 0)
            {
                if (ro == 10) textBox1.Text = s;
                if (ro == 8)
                {
                    textBox1.Text = Convert.ToString(plasDec(s, 8));
                }
                if (ro == 2)
                {
                    textBox1.Text = Convert.ToString(plasDec(s, 2));
                }
                if (ro == 16)
                {
                    textBox1.Text = Convert.ToString(plasDec(s, 16));
                }
            }

            if (s1.Length > 0)
            {
                if (ro == 10) textBox2.Text = s1;
                if (ro == 8)
                {
                    textBox2.Text = Convert.ToString(plasDec(s1, 8));
                }
                if (ro == 2)
                {
                    textBox2.Text = Convert.ToString(plasDec(s1, 2));
                }
                if (ro == 16)
                {
                    textBox2.Text = Convert.ToString(plasDec(s1, 16));
                }
            }

            if (s3.Length > 0)
            {
                if (ro == 10) textBox3.Text = s3;
                if (ro == 8)
                {
                    textBox3.Text = Convert.ToString(plasDec(s3, 8));
                }
                if (ro == 2)
                {
                    textBox3.Text = Convert.ToString(plasDec(s3, 2));
                }
                if (ro == 16)
                {
                    textBox3.Text = Convert.ToString(plasDec(s3, 16));
                }
            }
            ro = 10;
        }


        //8----------------------------------------------------------------
        private void button45_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label3.Text = "";
            label4.Text = "ON";
            label5.Text = "";
            string s = textBox1.Text;
            string s1 = textBox2.Text;
            string s3 = textBox3.Text;
            string s2;
            int a;

            if (s.Length > 0)
            {
                if (ro == 8) textBox1.Text = s;
                if (ro == 10)
                {
                    a = Convert.ToInt32(s);
                    textBox1.Text = Convert.ToString(a, 8);

                }
                if (ro == 2)
                {
                    s2 = Convert.ToString(plasDec(s, 2));
                    a = Convert.ToInt32(s2);
                    textBox1.Text = Convert.ToString(a, 8);

                }
                if (ro == 16)
                {
                    s2 = Convert.ToString(plasDec(s, 16));
                    a = Convert.ToInt32(s2);
                    textBox1.Text = Convert.ToString(a, 8);
                }
            }

            if (s1.Length > 0)
            {
                if (ro == 8) textBox2.Text = s1;
                if (ro == 10)
                {
                    a = Convert.ToInt32(s1);
                    textBox2.Text = Convert.ToString(a, 8);

                }
                if (ro == 2)
                {
                    s2 = Convert.ToString(plasDec(s1, 2));
                    a = Convert.ToInt32(s2);
                    textBox2.Text = Convert.ToString(a, 8);

                }
                if (ro == 16)
                {
                    s2 = Convert.ToString(plasDec(s1, 16));
                    a = Convert.ToInt32(s2);
                    textBox2.Text = Convert.ToString(a, 8);
                }
            }

            if (s3.Length > 0)
            {
                if (ro == 8) textBox3.Text = s3;
                if (ro == 10)
                {
                    a = Convert.ToInt32(s3);
                    textBox3.Text = Convert.ToString(a, 8);

                }
                if (ro == 2)
                {
                    s2 = Convert.ToString(plasDec(s3, 2));
                    a = Convert.ToInt32(s2);
                    textBox3.Text = Convert.ToString(a, 8);

                }
                if (ro == 16)
                {
                    s2 = Convert.ToString(plasDec(s3, 16));
                    a = Convert.ToInt32(s2);
                    textBox3.Text = Convert.ToString(a, 8);
                }
            }
            ro = 8;
        }

        //2----------------------------------------------------------------
        private void button46_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "ON";
            string s = textBox1.Text;
            string s1 = textBox2.Text;
            string s3 = textBox3.Text;
            string s2;
            int a;

            if (s.Length > 0)
            {
                if (ro == 2) textBox1.Text = s;
                if (ro == 10)
                {
                    a = Convert.ToInt32(s);
                    textBox1.Text = Convert.ToString(a, 2);

                }
                if (ro == 8)
                {
                    s2 = Convert.ToString(plasDec(s, 8));
                    a = Convert.ToInt32(s2);
                    textBox1.Text = Convert.ToString(a, 2);

                }
                if (ro == 16)
                {
                    s2 = Convert.ToString(plasDec(s, 16));
                    a = Convert.ToInt32(s2);
                    textBox1.Text = Convert.ToString(a, 2);

                }
            }

            if (s1.Length > 0)
            {
                if (ro == 2) textBox2.Text = s1;
                if (ro == 10)
                {
                    a = Convert.ToInt32(s1);
                    textBox2.Text = Convert.ToString(a, 2);

                }
                if (ro == 8)
                {
                    s2 = Convert.ToString(plasDec(s1, 8));
                    a = Convert.ToInt32(s2);
                    textBox2.Text = Convert.ToString(a, 2);

                }
                if (ro == 16)
                {
                    s2 = Convert.ToString(plasDec(s1, 16));
                    a = Convert.ToInt32(s2);
                    textBox2.Text = Convert.ToString(a, 2);

                }
            }

            if (s3.Length > 0)
            {
                if (ro == 2) textBox3.Text = s3;
                if (ro == 10)
                {
                    a = Convert.ToInt32(s3);
                    textBox3.Text = Convert.ToString(a, 2);

                }
                if (ro == 8)
                {
                    s2 = Convert.ToString(plasDec(s3, 8));
                    a = Convert.ToInt32(s2);
                    textBox3.Text = Convert.ToString(a, 2);

                }
                if (ro == 16)
                {
                    s2 = Convert.ToString(plasDec(s3, 16));
                    a = Convert.ToInt32(s2);
                    textBox3.Text = Convert.ToString(a, 2);

                }
            }
            ro = 2;
        }

        //toDEC----------------------------------------------------------------
        double plasDec(string a, int b)
        {
            int sizebin = a.Length;
            double dec = 0, doubleSimbol;
            int i;
            char simbol;
            int intSimbol;


            if (ro != 16)
            {
                for (i = 0; i <= a.Length - 1; i++)
                {
                    simbol = Convert.ToChar(a[i]);
                    intSimbol = simbol - '0';
                    doubleSimbol = Convert.ToInt32(intSimbol) * Math.Pow(b, sizebin - 1);
                    dec = dec + doubleSimbol;
                    sizebin--;
                }
            }
            if (ro == 16)
            {
                string hexValue = a;
                Int64 intSim = Convert.ToInt64(hexValue, 16);
                dec = Convert.ToDouble(intSim);
            }

            return dec;
        }

        
       

    }
}