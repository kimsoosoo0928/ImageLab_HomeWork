using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Window
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
            var saved_value = 0;
            
            textBox1.Text += text;
            int.TryParse(text, out saved_value);



            if (text=="+" && textBox2.Text =="")
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";       
                              
            }

            if (text == "+" && !(textBox2.Text == ""))
            {
                
                

                textBox2.Text += saved_value;
                textBox1.Text = "";

            }



        }

        
    }
}
