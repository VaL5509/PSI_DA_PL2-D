using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class Main_app : Form
    {
        public Main_app()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clientes = new Form_Cliente();

            clientes.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var produtosVendidos = new Form_Produtos_Vendidos();

            produtosVendidos.Show();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eventos = new Form_Eventos();

            eventos.Show();
        }

        private void produtosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vendasProdutos = new Form_Vendas_Produtos();

            vendasProdutos.Show();
        }

        private void escolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var escolas = new Form_Escolas();

            escolas.Show();
        }

        private void animadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var animadores = new Form_Animadores();

            animadores.Show();
        }
    }
}
