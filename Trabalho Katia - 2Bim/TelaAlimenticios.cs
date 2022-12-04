using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Katia___2Bim
{
    public partial class TelaAlimenticios : Form
    {
        public TelaAlimenticios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 t1 = new Form1();
            t1.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excluído com Sucesso!");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inserido com Sucesso!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alterado com Sucesso!");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
        }
    }
}
