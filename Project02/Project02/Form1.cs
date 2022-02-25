using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Image_Btn(object sender, EventArgs e)
        {
            Image newImage = Image.FromFile("D:\\data\\test_image\\Lenna.png");
        }
    }
}
