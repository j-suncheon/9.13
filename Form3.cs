using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._13
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal d=numericUpDown1.Value;
            label1.Text = "Log " + d + "=";
            textBox1.Text = System.Math.Log10((double)d).ToString();
            label2.Text = d + "*" + d + "=";
            textBox2.Text = System.Math.Pow((double)d, 2).ToString();
            label3.Text = "루트" + d + "=";
            textBox3.Text = System.Math.Sqrt((double)d).ToString();
        }
    }
}
