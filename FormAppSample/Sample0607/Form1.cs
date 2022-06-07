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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nudNum2.Text == 0.ToString())
            {
                MessageBox.Show("0じゃ割れないよ？","え？？",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.None);
            }
            else
            {
                //tbAns.Text = (int.Parse(nudNum1.Text) / int.Parse(nudNum2.Text)).ToString();
                //tbmod.Text = (int.Parse(nudNum1.Text) % int.Parse(nudNum2.Text)).ToString();
                nudAns.Value = nudNum1.Value / nudNum2.Value;
                nudMod.Value = nudNum1.Value % nudNum2.Value;
            }
            
        }
    }
}
