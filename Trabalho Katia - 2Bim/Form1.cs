using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Katia___2Bim;

namespace Trabalho_Katia___2Bim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForncedores_Click(object sender, EventArgs e)
        {
            TelaFornecedores t2 = new TelaFornecedores();
            t2.Show();
            this.Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            TelaProdutos t3 = new TelaProdutos();
            t3.Show();
            this.Hide();
        }

        private void btnAlimenticios_Click(object sender, EventArgs e)
        {
            TelaAlimenticios t4 = new TelaAlimenticios();
            t4.Show();
            this.Hide();
        }
    }
}
