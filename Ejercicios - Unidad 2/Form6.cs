using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios___Unidad_2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(radioButton1.Checked) 
            {
                label1.Text = radioButton1.Text;
                return;
            }

            if (radioButton2.Checked)
            {
                label1.Text = radioButton2.Text;
                return;
            }

            if (radioButton3.Checked)
            {
                label1.Text = radioButton3.Text;
                return;
            }

        }
    }
}
