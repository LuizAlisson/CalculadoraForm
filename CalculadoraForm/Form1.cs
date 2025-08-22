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
            try
            {
                // 1️⃣ Pega a expressão completa que o usuário digitou no TextBox
                string expressao = txbTela.Text;

                // 2️⃣ Calcula a expressão usando DataTable().Compute
                //     Isso permite calcular múltiplos operadores e respeitar a ordem correta (* e / antes de + e -)
                var resultado = new System.Data.DataTable().Compute(expressao, "").ToString();

                // 3️⃣ Mostra o resultado no TextBox
                if (double.IsInfinity(Convert.ToDouble(resultado)))
                {
                    MessageBox.Show("Deu ruim parsa!");
                    txbTela.Text = "";
                }
                else
                {
                    txbTela.Text = resultado; // já é string
                }



            }
            catch
            {
                // Caso a expressão esteja inválida (ex: "2++3"), mostra uma mensagem de erro
                MessageBox.Show("Expressão inválida!");
            }
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

        private void btnC_Click(object sender, EventArgs e)
        {
            //Limpar a tela: 
            txbTela.Text = "";
            //Voltar o operador clicado para true:
            operadorClicado = true;

        }

    }
}
