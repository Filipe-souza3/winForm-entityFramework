﻿namespace winfromNet
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewCarro = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCar = new System.Windows.Forms.Button();
            this.inputCor = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewPessoa = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.inputIdade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPessoa = new System.Windows.Forms.Button();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarro)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.dataGridViewCarro);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.inputPlaca);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnCar);
            this.tabPage1.Controls.Add(this.inputCor);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 252);
            this.tabPage1.TabIndex = 10;
            this.tabPage1.Text = "Carro";
            // 
            // dataGridViewCarro
            // 
            this.dataGridViewCarro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarro.Location = new System.Drawing.Point(193, 42);
            this.dataGridViewCarro.Name = "dataGridViewCarro";
            this.dataGridViewCarro.ReadOnly = true;
            this.dataGridViewCarro.RowHeadersWidth = 51;
            this.dataGridViewCarro.RowTemplate.Height = 24;
            this.dataGridViewCarro.Size = new System.Drawing.Size(262, 146);
            this.dataGridViewCarro.TabIndex = 10;
            this.dataGridViewCarro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCarro_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Placa";
            // 
            // inputPlaca
            // 
            this.inputPlaca.Location = new System.Drawing.Point(50, 120);
            this.inputPlaca.Name = "inputPlaca";
            this.inputPlaca.Size = new System.Drawing.Size(100, 22);
            this.inputPlaca.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cor";
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(50, 158);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(100, 30);
            this.btnCar.TabIndex = 8;
            this.btnCar.Text = "Cadastrar";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click_1);
            // 
            // inputCor
            // 
            this.inputCor.Location = new System.Drawing.Point(50, 61);
            this.inputCor.Name = "inputCor";
            this.inputCor.Size = new System.Drawing.Size(100, 22);
            this.inputCor.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.dataGridViewPessoa);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.inputIdade);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnPessoa);
            this.tabPage2.Controls.Add(this.inputNome);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pessoa";
            // 
            // dataGridViewPessoa
            // 
            this.dataGridViewPessoa.AllowUserToAddRows = false;
            this.dataGridViewPessoa.AllowUserToDeleteRows = false;
            this.dataGridViewPessoa.AllowUserToResizeRows = false;
            this.dataGridViewPessoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPessoa.Location = new System.Drawing.Point(193, 42);
            this.dataGridViewPessoa.Name = "dataGridViewPessoa";
            this.dataGridViewPessoa.ReadOnly = true;
            this.dataGridViewPessoa.RowHeadersWidth = 51;
            this.dataGridViewPessoa.RowTemplate.Height = 24;
            this.dataGridViewPessoa.Size = new System.Drawing.Size(262, 146);
            this.dataGridViewPessoa.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Idade";
            // 
            // inputIdade
            // 
            this.inputIdade.Location = new System.Drawing.Point(50, 120);
            this.inputIdade.Name = "inputIdade";
            this.inputIdade.Size = new System.Drawing.Size(100, 22);
            this.inputIdade.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome";
            // 
            // btnPessoa
            // 
            this.btnPessoa.Location = new System.Drawing.Point(50, 158);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Size = new System.Drawing.Size(100, 30);
            this.btnPessoa.TabIndex = 13;
            this.btnPessoa.Text = "Cadastrar";
            this.btnPessoa.UseVisualStyleBackColor = true;
            this.btnPessoa.Click += new System.EventHandler(this.btnPessoa_Click);
            // 
            // inputNome
            // 
            this.inputNome.Location = new System.Drawing.Point(50, 61);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(100, 22);
            this.inputNome.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            this.contextMenuStrip1.Text = "Editar";
            this.contextMenuStrip1.UseWaitCursor = true;
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.editarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 330);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.TextBox inputCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputIdade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPessoa;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.DataGridView dataGridViewCarro;
        private System.Windows.Forms.DataGridView dataGridViewPessoa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}

