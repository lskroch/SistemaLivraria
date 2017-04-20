namespace Visao
{
    partial class frmAlterarExcluirLivros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarExcluirLivros));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);           
            this.idLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();         
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(40, 18);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(459, 19);
            this.lblMensagem.TabIndex = 14;
            this.lblMensagem.Text = "Selecione o registro e clique nos botões para alterar/excluir";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnVoltar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 341);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(544, 31);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtnVoltar
            // 
            this.tsbtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnVoltar.Image")));
            this.tsbtnVoltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnVoltar.Name = "tsbtnVoltar";
            this.tsbtnVoltar.Size = new System.Drawing.Size(66, 28);
            this.tsbtnVoltar.Text = "Voltar";
            this.tsbtnVoltar.Click += new System.EventHandler(this.tsbtnVoltar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoGenerateColumns = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLivroDataGridViewTextBoxColumn,
            this.nomeLivroDataGridViewTextBoxColumn,
            this.autorLivroDataGridViewTextBoxColumn,
            this.generoLivroDataGridViewTextBoxColumn,
            this.btnEditar,
            this.btnExcluir});
            this.dgvDados.DataSource = this.livrosBindingSource;
            this.dgvDados.Location = new System.Drawing.Point(12, 61);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(520, 268);
            this.dgvDados.TabIndex = 15;
            this.dgvDados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDados_CellMouseClick);
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";           
            // 
            // idLivroDataGridViewTextBoxColumn
            // 
            this.idLivroDataGridViewTextBoxColumn.DataPropertyName = "Id_Livro";
            this.idLivroDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idLivroDataGridViewTextBoxColumn.Name = "idLivroDataGridViewTextBoxColumn";
            this.idLivroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLivroDataGridViewTextBoxColumn.Width = 30;
            // 
            // nomeLivroDataGridViewTextBoxColumn
            // 
            this.nomeLivroDataGridViewTextBoxColumn.DataPropertyName = "Nome_Livro";
            this.nomeLivroDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeLivroDataGridViewTextBoxColumn.Name = "nomeLivroDataGridViewTextBoxColumn";
            this.nomeLivroDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeLivroDataGridViewTextBoxColumn.Width = 115;
            // 
            // autorLivroDataGridViewTextBoxColumn
            // 
            this.autorLivroDataGridViewTextBoxColumn.DataPropertyName = "Autor_Livro";
            this.autorLivroDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorLivroDataGridViewTextBoxColumn.Name = "autorLivroDataGridViewTextBoxColumn";
            this.autorLivroDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorLivroDataGridViewTextBoxColumn.Width = 110;
            // 
            // generoLivroDataGridViewTextBoxColumn
            // 
            this.generoLivroDataGridViewTextBoxColumn.DataPropertyName = "Genero_Livro";
            this.generoLivroDataGridViewTextBoxColumn.HeaderText = "Gênero";
            this.generoLivroDataGridViewTextBoxColumn.Name = "generoLivroDataGridViewTextBoxColumn";
            this.generoLivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 60;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "Excluir";
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ReadOnly = true;
            this.btnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseColumnTextForButtonValue = true;
            this.btnExcluir.Width = 60;
            // 
            // frmAlterarExcluirLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 372);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarExcluirLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar / Excluir Livros";
            this.Load += new System.EventHandler(this.frmAlterarExcluirLivros_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.BindingSource livrosBindingSource;      
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
    }
}