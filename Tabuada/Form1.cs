using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerarTabuada_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o número digitado
                int numero = Convert.ToInt32(txtNumero.Text);

                // Limpa a lista antes de exibir a nova tabuada
                lstTabuada.Items.Clear();

                // Gera a tabuada de 1 a 10
                for (int i = 1; i <= 10; i++)
                {
                    lstTabuada.Items.Add($"{numero} x {i} = {numero * i}");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
