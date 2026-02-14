using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios___Unidad_2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String color = comboBox1.SelectedItem as String;

            if (color == "Azul") 
            {
                this.BackColor = Color.Blue;
            }
            else if (color == "Verde")
            {
                this.BackColor = Color.Green;
            }
            else if (color == "Rojo")
            {
                this.BackColor = Color.Red;
            }

        }
    }
}
