using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2RemoveCharFromString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] c = textBox1.Text.ToCharArray();
            char[] str = textBox2.Text.ToCharArray();

            RemoveCharFromString r = new RemoveCharFromString();

            label3.Text = r.remove(c,str);
        }
    }
}
