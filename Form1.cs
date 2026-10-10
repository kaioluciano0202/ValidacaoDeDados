using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValicacaoDeDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar)) // Se não for precionada as teclas
            {
                e.Handled = true; // Verifica as telcas pressionadas
                MessageBox.Show("SÓ PERMITE LETRAS", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensagem de erro
            }

            if (e.KeyChar == 13) // A tecla enter 13 Foi Precionada
            {
                if (Txt_Nome.Text != "") // Verifica se o Text esta vazio
                {
                    Txt_Idade.Focus(); // Passa e vai para o proximo campo TXT idade
                }
                else
                {
                    MessageBox.Show("O NOME NÃO FOI DIGITADO...", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Txt_Idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)
            {
                e.Handled = true;
                MessageBox.Show("So Permite númeor", "AVISO!!");
            }

            if (e.KeyChar == 13)
            {
                if (Txt_Idade.Text != "")
                {
                    Txt_CPF.Focus();
                }
                else
                {
                    MessageBox.Show("A idade não foi Digitado...", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 
    }
}
