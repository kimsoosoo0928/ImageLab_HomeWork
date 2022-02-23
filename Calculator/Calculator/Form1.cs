using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var text = ((Control)sender).Text;
            double saved_value = 0;
            double new_value = 0;
            double result = 0;
            int last = textBox2.Text.Length;


            if (text is "+" or "-" or "*" or "/")
            {
                // - 연산자 // 
                if (text == "-")
                {
                    if (textBox2.Text == "")
                    {
                        textBox2.Text += text;
                    }

                    else if (textBox2.Text == "-")
                    {

                    }

                    else if (!(textBox2.Text == "") && !(textBox2.Text.Substring(last) == "-"))
                    {
                        if (textBox1.Text == "")
                        {
                            textBox1.Text = textBox2.Text;
                            textBox2.Text = text;
                        }
                        else if (!(textBox1.Text == ""))
                        {
                            saved_value = double.Parse(textBox1.Text);
                            new_value = double.Parse(textBox2.Text);

                            result = saved_value + new_value;
                            textBox1.Text = result.ToString();
                            textBox2.Text = "";


                        }
                    }
                }

                // + 연산자 // 

                if (text == "+")
                {
                    if (textBox2.Text == "")
                    {
                        textBox2.Text += text;
                    }
                    else if (textBox2.Text == "+")
                    {

                    }

                    else if (!(textBox2.Text == "") && textBox1.Text == "")
                    {
                        textBox1.Text = textBox2.Text;
                        textBox2.Text = "";
                    }
                    else if (!(textBox2.Text == "") && !(textBox1.Text == ""))
                    {
                        saved_value = double.Parse(textBox1.Text);
                        new_value = double.Parse(textBox2.Text);

                        result = saved_value + new_value;
                        textBox1.Text = result.ToString();
                        textBox2.Text = "";
                    }
                }

                // * 연산자 //
                if (text == "*")
                {
                    if (textBox2.Text == "")
                    {
                        textBox2.Text += text;
                    }

                    else if (textBox2.Text == "*")
                    {

                    }

                    else if (!(textBox2.Text == "") && textBox1.Text == "")
                    {
                        textBox1.Text = textBox2.Text;
                        textBox2.Text = "";
                    }
                    else if (!(textBox2.Text == "") && !(textBox1.Text == ""))
                    {
                        saved_value = double.Parse(textBox1.Text);
                        new_value = double.Parse(textBox2.Text);

                        result = saved_value * new_value;
                        textBox1.Text = result.ToString();
                        textBox2.Text = "";
                    }
                }
                // / 연산자 //
                if (text == "/")
                {
                    if (textBox2.Text == "")
                    {
                        textBox2.Text += text;
                    }

                    else if (textBox2.Text == "/")
                    {

                    }

                    else if (!(textBox2.Text == "") && textBox1.Text == "")
                    {
                        textBox1.Text = textBox2.Text;
                        textBox2.Text = "";
                    }
                    else if (!(textBox2.Text == "") && !(textBox1.Text == ""))
                    {
                        saved_value = double.Parse(textBox1.Text);
                        new_value = double.Parse(textBox2.Text);

                        result = saved_value / new_value;
                        textBox1.Text = result.ToString();
                        textBox2.Text = "";
                    }

                }

            }

            // 사칙연산 제외한 모든 숫자 출력하기

            if (!(text is "+" or "-" or "*" or "/"))
            {
                textBox2.Text += text;
            }
            
            // 소수점 중복 방지 - error!!

            else if (text is "." && (textBox2.Text.Substring(last) == "."))
            {
                
            }
            
            // = - error!!

            if (text is "=")
            {
                if (textBox2.Text.StartsWith("+"))
                {
                    saved_value = double.Parse(textBox1.Text);
                    new_value = double.Parse(textBox2.Text);

                    result = saved_value + new_value;
                    textBox1.Text = result.ToString();
                    textBox2.Text = "";
                }
            }

        }


    }
}



