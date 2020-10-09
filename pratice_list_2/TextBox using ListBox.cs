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
    public partial class TextBox_using_ListBox : Form
    {
        public TextBox_using_ListBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (String str in listBox1.SelectedItems)
                textBox1.Text += str.ToString();
        }
    }
}
