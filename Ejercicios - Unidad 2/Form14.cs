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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                timer1.Stop();
            }

        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
