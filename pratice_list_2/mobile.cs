using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pratice_list_2
{
    public partial class mobile : Form
    {
        public mobile()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("samsung j7");
            listBox1.Items.Add("smasung j2");
            listBox1.Items.Add("samsung s6 edge");
            listBox1.Items.Add("samsung s8");
            listBox1.Items.Add("samsung note 4");
            listBox1.Items.Add("samsung j7 prime");
            listBox1.Items.Add("samsung j7 max ");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("iphone x");
            listBox1.Items.Add("iphone 8");
            listBox1.Items.Add("iphone 7plus");
            listBox1.Items.Add("iphone 6s");
            listBox1.Items.Add("iphone 6");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("xperia");
            listBox1.Items.Add("xperia M");
            listBox1.Items.Add("xperia L");
            listBox1.Items.Add("xperia A");
        }
    }
}
