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
    public partial class image : Form
    {
        public image()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:/all photos/Santa Banta/sunrise-63a.jpg");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:/all photos/Santa Banta/Cars HD/2300x1533 Vehicles Ford Mustang.jpg");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:/all photos/Santa Banta/Seashells-22121.jpg");
        }
    }
}
