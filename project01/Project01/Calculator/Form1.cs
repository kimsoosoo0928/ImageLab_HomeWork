using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void ButtonClick(object sender, EventArgs e)
        {
            var text = ((Control)sender).Text;
            //if (text == "+" || text == "-")
            if (text is "+" or "-" or"/" or"*" or "=")
            {

                if(textBox2.Text is not "" && textBox2.Text is not "-")
                {
                    textBox1.Text += textBox2.Text + " " + text + " ";
                    textBox2.Text = "";
                    
                    
                }
                else
                {
                    if(text is "-")
                    {
                        textBox2.Text += text;
                    }

                    
                }
                if (text is "=")
                {
                    var formular = textBox1.Text + textBox2.Text;
                    var formularSplitted = formular.Split(" ");

                    double result = 0;
                    int temp = 0;
                    string exp = "";
                    foreach (var item in formularSplitted)
                    {
                        if(!int.TryParse(item, out temp))
                        {
                            exp = item;
                            continue;
                        }

                        if(exp is "")
                        {
                            result += temp;
                            continue;
                        }
                        switch (exp)
                        {
                            case "+":
                                result += temp;
                                break;
                            case "-":
                                result -= temp;
                                break;
                            case "/":
                                result /= temp;
                                break;
                            case "*":
                                result *= temp;
                                break;
                            default:
                                break;
                        }


                    }

                }

            }
            else
            { 
                textBox2.Text += text; 
            }
            
            
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
