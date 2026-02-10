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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Double.Parse(textBox1.Text);
            double n2 = Double.Parse(textBox2.Text);
            label1.Text = $"{n1 + n2}";
        }
    }
}
