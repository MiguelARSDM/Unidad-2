using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios___Unidad_2
{
    public partial class Form17 : Form
    {

        //VARIABLES
        string operador = "";
        double num1 = 0;
        double num2 = 0;

        public Form17()
        {

            InitializeComponent();
            txtPantalla.Text = "0";

        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "";
            }
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void buttonAllClear_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            num1 = 0;
            num2 = 0;
        }

        private void buttonClearError_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length <= 1)
            {
                txtPantalla.Text = "0";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "";
            }
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "";
            }
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "";
            }
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "";
            }
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "";
            }
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "";
            }
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "";
            }
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "";
            }
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ".";
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "";
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "x";
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "";
        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "";
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "";
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {

            num2 = Convert.ToDouble(txtPantalla.Text);

            switch (operador) 
            {
                case "+":
                    txtPantalla.Text = $"{num1 + num2}";
                        break;
                case "-":
                    txtPantalla.Text = $"{num1 - num2}";
                    break;
                case "x":
                    txtPantalla.Text = $"{num1 * num2}";
                    break;
                case "/":
                    txtPantalla.Text = $"{num1 / num2}";
                    break;


            }

        }
    }
}
