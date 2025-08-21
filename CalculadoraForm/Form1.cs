using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        //Variáveis globais:
        bool operadorClicado = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //implementar depois..
        }
        private void numero_Click(object sender, EventArgs e)
        {
           //Obter um botão que está chamando esse evento:
           Button botaoClicado = (Button)sender;
            //adicionar o text do botão criado no TextBox:
            txbTela.Text += botaoClicado.Text;
            //Deixar selecionar o operador novamente após selecionar o número
            operadorClicado = false;
        }
        private void operador_Click(object sender, EventArgs e)
        {
            //Verificar se o operador ainda não foi clicado
            if(operadorClicado == false)
            {
                //Obter um botão que está chamando esse evento:
                Button botaoClicado = (Button)sender;
                //adicionar o text do botão criado no TextBox:
                txbTela.Text += botaoClicado.Text;
                //mudar o operadorClicado para true:
                operadorClicado = true;

            }
            
        }
    }
}
