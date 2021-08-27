using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

       

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void textResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textResultado.Text += ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                textResultado.Text = Convert.ToString(valor1 + valor2); //vai converter de numero para string
            }
            else if (operacao == "SUB")
            {
                textResultado.Text = Convert.ToString(valor1 - valor2); //vai converter de numero para string


            }
            else if (operacao == "MULT")
            {
                textResultado.Text = Convert.ToString(valor1 * valor2); //vai converter de numero para string


            }
            else 
            {
                textResultado.Text = Convert.ToString(valor1 / valor2); //vai converter de numero para string


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = ""; //limpar o texto
            operacao = "SUB";
            lblOperacao.Text = "-";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = ""; //limpar o texto
            operacao = "MULT";
            lblOperacao.Text = "x";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = ""; //limpar o texto
            operacao = "DIV";
            lblOperacao.Text = "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            lblOperacao.Text = "";       
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (textResultado.Text != "")
            {



                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = ""; //limpar o texto
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
        }
    }
}
