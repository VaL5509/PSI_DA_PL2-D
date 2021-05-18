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
    public partial class FormClienteseFilhos : Form
    {
        private ModelContainer loja;
        public FormClienteseFilhos()
        {
            InitializeComponent();
            
        }
        private void FormClienteseFilhos_Load(object sender, EventArgs e)
        {
            loja = new ModelContainer();
            LerDados();
        }

        private void buttonInserirCliente_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length == 0 || textBoxTelefone.Text.Length == 0 || textBoxMail.Text.Length == 0)
            {
                return;
            }
            else
            {
                //Criar Cliente
                listBoxClientes.Items.Add(new Cliente(textBoxNome.Text, textBoxTelefone.Text, textBoxTelemovel.Text,
                    textBoxMorada.Text, textBoxMorada.Text, textBoxLocalidade.Text, textBoxCodPostal.Text, textBoxMail.Text));

                loja.SaveChanges();
            }
        }


        private void LerDados()
        {
            listBoxClientes.DataSource = loja.Cliente.ToList<Cliente>;
        }
    }
}
