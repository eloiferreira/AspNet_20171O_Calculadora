using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        string op = " ";
        double valor = 0;
        bool operacao =false; 

        public Form1()
        {
            InitializeComponent();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            

        }

        private void digito(object sender, EventArgs e)
        {


            if ((operacao) || (result.Text == "0")) 
                result.Clear();
            
                
            //converter o objeto em botao
            Button b = (Button)sender;

            result.Text = result.Text + b.Text;


        



        }

        private void limpar(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operacoes(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            op = b.Text;
            valor = Double.Parse(result.Text);
            operacao= true;


        }

        private void igual(object sender, EventArgs e)
        {

            switch (op)
            {
                case "+":
                    result.Text = (valor + Double.Parse(result.Text)).ToString();

                    break;

                case "-":
                    result.Text = (valor - Double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (valor * Double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (valor / Double.Parse(result.Text)).ToString();
                    break;

                default:

                    break;
            }

                    operacao = false;
            
        }
    }
}
