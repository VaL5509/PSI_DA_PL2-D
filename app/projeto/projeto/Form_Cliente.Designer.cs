﻿
namespace projeto
{
    partial class Form_Cliente
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestoresToolStripMenuItem
            // 
            this.gestoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.produtosVendidosToolStripMenuItem,
            this.escolasToolStripMenuItem,
            this.animadoresToolStripMenuItem});
            this.gestoresToolStripMenuItem.Name = "gestoresToolStripMenuItem";
            this.gestoresToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.gestoresToolStripMenuItem.Text = "Gestores";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produtosToolStripMenuItem.Text = "Venda de Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // produtosVendidosToolStripMenuItem
            // 
            this.produtosVendidosToolStripMenuItem.Name = "produtosVendidosToolStripMenuItem";
            this.produtosVendidosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produtosVendidosToolStripMenuItem.Text = "Produtos Vendidos";
            // 
            // escolasToolStripMenuItem
            // 
            this.escolasToolStripMenuItem.Name = "escolasToolStripMenuItem";
            this.escolasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.escolasToolStripMenuItem.Text = "Escolas";
            // 
            // animadoresToolStripMenuItem
            // 
            this.animadoresToolStripMenuItem.Name = "animadoresToolStripMenuItem";
            this.animadoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.animadoresToolStripMenuItem.Text = "Animadores";
            // 
            // Form_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_Cliente";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animadoresToolStripMenuItem;
    }
}