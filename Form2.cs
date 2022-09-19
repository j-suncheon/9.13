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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !=""&&treeView1.SelectedNode !=null)
            {
                treeView1.SelectedNode.Nodes.Add(new TreeNode(textBox1.Text,1,0));
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }
    }
}
