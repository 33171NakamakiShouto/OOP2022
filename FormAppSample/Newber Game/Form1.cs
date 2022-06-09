using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newber_Game
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getRandom();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (Bef.TabIndex == nudNum1.Value)
            {
                Ans.Text = "大正解!!君は天才だ!!";
            }
            else if (Bef.TabIndex < nudNum1.Value)
            {
                Ans.Text = "残念…大きいぞ";
            }
            else if (Bef.TabIndex > nudNum1.Value)
            {
                Ans.Text = "残念…小さいぞ";
            }
            //Ans.Text = Bef.Tag.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            getRandom();
        }

        private void getRandom()
        {
            Bef.TabIndex = rand.Next(1, (int)nudNum2.Value);
        }
    }
}
