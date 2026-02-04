using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Secand_Screen SC=new Secand_Screen();
            SC.Show();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Image temp=pictureBox1.Image;
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image=temp;

        }
    }
}
