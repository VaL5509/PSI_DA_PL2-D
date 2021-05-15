using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void gestãoDeClientesESeusFilhosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clientes = new FormClientes();

            clientes.Show();
        }

        private void gestãoDeVendasDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vendaProdutos = new FormVendaProdutos();

            vendaProdutos.Show();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eventos = new FormEventos();

            eventos.Show();
        }

        private void produtosVendidosPelaLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vendaProdutosLoja = new FormVendaProdutosLoja();

            vendaProdutosLoja.Show();
        }

        private void gestãoDeEscolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var escolas = new FormEscolas();

            escolas.Show();
        }

        private void animadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var animadores = new FormAnimadores();

            animadores.Show();
        }
    }
}
