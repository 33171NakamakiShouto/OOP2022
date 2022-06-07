using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bcRandom_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            nudNum1.Value = rand.Next(minValue:(int)nudMin.Value, maxValue:(int)nudMax.Value+1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
