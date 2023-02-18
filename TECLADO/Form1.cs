using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECLADO
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                    param.ClassStyle |= 0x08000000;
                return param;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("(");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendKeys.Send(")");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("[");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("]");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("¡");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("!");
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
