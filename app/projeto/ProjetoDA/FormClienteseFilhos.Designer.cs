
namespace ProjetoDA
{
    partial class FormClienteseFilhos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.buttonInserirCliente = new System.Windows.Forms.Button();
            this.textBoxCodPostal = new System.Windows.Forms.TextBox();
            this.textBoxLocalidade = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTelemovel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonApagarCliente = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonApagarDadosFilhos = new System.Windows.Forms.Button();
            this.buttonAlterarDadosFilhos = new System.Windows.Forms.Button();
            this.buttonApagarDadosClientes = new System.Windows.Forms.Button();
            this.listBoxDadosFilhos = new System.Windows.Forms.ListBox();
            this.buttonAlterarDadosCliente = new System.Windows.Forms.Button();
            this.listBoxDadosClientes = new System.Windows.Forms.ListBox();
            this.groupBoxClientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.buttonInserirCliente);
            this.groupBoxClientes.Controls.Add(this.textBoxCodPostal);
            this.groupBoxClientes.Controls.Add(this.textBoxLocalidade);
            this.groupBoxClientes.Controls.Add(this.textBoxMorada);
            this.groupBoxClientes.Controls.Add(this.label7);
            this.groupBoxClientes.Controls.Add(this.label6);
            this.groupBoxClientes.Controls.Add(this.label5);
            this.groupBoxClientes.Controls.Add(this.label4);
            this.groupBoxClientes.Controls.Add(this.label3);
            this.groupBoxClientes.Controls.Add(this.textBoxMail);
            this.groupBoxClientes.Controls.Add(this.textBoxTelemovel);
            this.groupBoxClientes.Controls.Add(this.label2);
            this.groupBoxClientes.Controls.Add(this.label1);
            this.groupBoxClientes.Controls.Add(this.textBoxTelefone);
            this.groupBoxClientes.Controls.Add(this.textBoxNome);
            this.groupBoxClientes.Location = new System.Drawing.Point(22, 12);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(379, 297);
            this.groupBoxClientes.TabIndex = 0;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Inserir Clientes";
            // 
            // buttonInserirCliente
            // 
            this.buttonInserirCliente.Location = new System.Drawing.Point(155, 247);
            this.buttonInserirCliente.Name = "buttonInserirCliente";
            this.buttonInserirCliente.Size = new System.Drawing.Size(161, 32);
            this.buttonInserirCliente.TabIndex = 14;
            this.buttonInserirCliente.Text = "Adicionar";
            this.buttonInserirCliente.UseVisualStyleBackColor = true;
            this.buttonInserirCliente.Click += new System.EventHandler(this.buttonInserirCliente_Click);
            // 
            // textBoxCodPostal
            // 
            this.textBoxCodPostal.Location = new System.Drawing.Point(155, 214);
            this.textBoxCodPostal.Name = "textBoxCodPostal";
            this.textBoxCodPostal.Size = new System.Drawing.Size(161, 22);
            this.textBoxCodPostal.TabIndex = 13;
            // 
            // textBoxLocalidade
            // 
            this.textBoxLocalidade.Location = new System.Drawing.Point(155, 186);
            this.textBoxLocalidade.Name = "textBoxLocalidade";
            this.textBoxLocalidade.Size = new System.Drawing.Size(161, 22);
            this.textBoxLocalidade.TabIndex = 12;
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(155, 157);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(161, 22);
            this.textBoxMorada.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Codigo Postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Localidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Morada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telemovel";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(155, 129);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(161, 22);
            this.textBoxMail.TabIndex = 5;
            // 
            // textBoxTelemovel
            // 
            this.textBoxTelemovel.Location = new System.Drawing.Point(155, 101);
            this.textBoxTelemovel.Name = "textBoxTelemovel";
            this.textBoxTelemovel.Size = new System.Drawing.Size(161, 22);
            this.textBoxTelemovel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(155, 73);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(161, 22);
            this.textBoxTelefone.TabIndex = 1;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(155, 45);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(161, 22);
            this.textBoxNome.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonApagarCliente);
            this.groupBox1.Controls.Add(this.listBoxClientes);
            this.groupBox1.Location = new System.Drawing.Point(22, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 503);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Clientes";
            // 
            // buttonApagarCliente
            // 
            this.buttonApagarCliente.Location = new System.Drawing.Point(250, 365);
            this.buttonApagarCliente.Name = "buttonApagarCliente";
            this.buttonApagarCliente.Size = new System.Drawing.Size(111, 32);
            this.buttonApagarCliente.TabIndex = 6;
            this.buttonApagarCliente.Text = "Apagar";
            this.buttonApagarCliente.UseVisualStyleBackColor = true;
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 16;
            this.listBoxClientes.Location = new System.Drawing.Point(20, 35);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(341, 324);
            this.listBoxClientes.TabIndex = 0;
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.labelCliente);
            this.groupBoxCliente.Controls.Add(this.groupBox2);
            this.groupBoxCliente.Location = new System.Drawing.Point(428, 32);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(778, 796);
            this.groupBoxCliente.TabIndex = 2;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.BackColor = System.Drawing.SystemColors.Control;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(48, 53);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(256, 25);
            this.labelCliente.TabIndex = 15;
            this.labelCliente.Text = "Sem Cliente Selecionado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonApagarDadosFilhos);
            this.groupBox2.Controls.Add(this.buttonAlterarDadosFilhos);
            this.groupBox2.Controls.Add(this.buttonApagarDadosClientes);
            this.groupBox2.Controls.Add(this.listBoxDadosFilhos);
            this.groupBox2.Controls.Add(this.buttonAlterarDadosCliente);
            this.groupBox2.Controls.Add(this.listBoxDadosClientes);
            this.groupBox2.Location = new System.Drawing.Point(27, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 605);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // buttonApagarDadosFilhos
            // 
            this.buttonApagarDadosFilhos.Location = new System.Drawing.Point(518, 492);
            this.buttonApagarDadosFilhos.Name = "buttonApagarDadosFilhos";
            this.buttonApagarDadosFilhos.Size = new System.Drawing.Size(149, 32);
            this.buttonApagarDadosFilhos.TabIndex = 9;
            this.buttonApagarDadosFilhos.Text = "Apagar";
            this.buttonApagarDadosFilhos.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarDadosFilhos
            // 
            this.buttonAlterarDadosFilhos.Location = new System.Drawing.Point(362, 492);
            this.buttonAlterarDadosFilhos.Name = "buttonAlterarDadosFilhos";
            this.buttonAlterarDadosFilhos.Size = new System.Drawing.Size(149, 32);
            this.buttonAlterarDadosFilhos.TabIndex = 8;
            this.buttonAlterarDadosFilhos.Text = "Alterar";
            this.buttonAlterarDadosFilhos.UseVisualStyleBackColor = true;
            // 
            // buttonApagarDadosClientes
            // 
            this.buttonApagarDadosClientes.Location = new System.Drawing.Point(180, 492);
            this.buttonApagarDadosClientes.Name = "buttonApagarDadosClientes";
            this.buttonApagarDadosClientes.Size = new System.Drawing.Size(149, 32);
            this.buttonApagarDadosClientes.TabIndex = 7;
            this.buttonApagarDadosClientes.Text = "Apagar";
            this.buttonApagarDadosClientes.UseVisualStyleBackColor = true;
            // 
            // listBoxDadosFilhos
            // 
            this.listBoxDadosFilhos.FormattingEnabled = true;
            this.listBoxDadosFilhos.ItemHeight = 16;
            this.listBoxDadosFilhos.Location = new System.Drawing.Point(362, 61);
            this.listBoxDadosFilhos.Name = "listBoxDadosFilhos";
            this.listBoxDadosFilhos.Size = new System.Drawing.Size(305, 420);
            this.listBoxDadosFilhos.TabIndex = 3;
            // 
            // buttonAlterarDadosCliente
            // 
            this.buttonAlterarDadosCliente.Location = new System.Drawing.Point(24, 492);
            this.buttonAlterarDadosCliente.Name = "buttonAlterarDadosCliente";
            this.buttonAlterarDadosCliente.Size = new System.Drawing.Size(149, 32);
            this.buttonAlterarDadosCliente.TabIndex = 4;
            this.buttonAlterarDadosCliente.Text = "Alterar";
            this.buttonAlterarDadosCliente.UseVisualStyleBackColor = true;
            // 
            // listBoxDadosClientes
            // 
            this.listBoxDadosClientes.FormattingEnabled = true;
            this.listBoxDadosClientes.ItemHeight = 16;
            this.listBoxDadosClientes.Location = new System.Drawing.Point(24, 61);
            this.listBoxDadosClientes.Name = "listBoxDadosClientes";
            this.listBoxDadosClientes.Size = new System.Drawing.Size(305, 420);
            this.listBoxDadosClientes.TabIndex = 0;
            // 
            // FormClienteseFilhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 857);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxClientes);
            this.Name = "FormClienteseFilhos";
            this.Text = "Gestão de Clientes e Filhos";
            this.Load += new System.EventHandler(this.FormClienteseFilhos_Load);
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxClientes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodPostal;
        private System.Windows.Forms.TextBox textBoxLocalidade;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTelemovel;
        private System.Windows.Forms.Button buttonInserirCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonApagarCliente;
        private System.Windows.Forms.Button buttonAlterarDadosCliente;
        private System.Windows.Forms.ListBox listBoxDadosFilhos;
        private System.Windows.Forms.ListBox listBoxDadosClientes;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Button buttonApagarDadosFilhos;
        private System.Windows.Forms.Button buttonAlterarDadosFilhos;
        private System.Windows.Forms.Button buttonApagarDadosClientes;
    }
}