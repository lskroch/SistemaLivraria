using System.ComponentModel;
namespace Visao
{
    partial class frmConsultarLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarLivros));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.lsvDados = new System.Windows.Forms.ListView();
            this.CodigoLivro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeLivro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AutorLivro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GeneroLivro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.toolStrip2.SuspendLayout();
            this.gpbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnVoltar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 341);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(544, 31);
            this.toolStrip2.TabIndex = 6;
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
            // lsvDados
            // 
            this.lsvDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodigoLivro,
            this.NomeLivro,
            this.AutorLivro,
            this.GeneroLivro});
            this.lsvDados.FullRowSelect = true;
            this.lsvDados.GridLines = true;
            this.lsvDados.Location = new System.Drawing.Point(19, 80);
            this.lsvDados.MultiSelect = false;
            this.lsvDados.Name = "lsvDados";
            this.lsvDados.Size = new System.Drawing.Size(502, 249);
            this.lsvDados.TabIndex = 12;
            this.lsvDados.UseCompatibleStateImageBehavior = false;
            this.lsvDados.View = System.Windows.Forms.View.Details;
            // 
            // CodigoLivro
            // 
            this.CodigoLivro.Text = "Código";
            this.CodigoLivro.Width = 0;
            // 
            // NomeLivro
            // 
            this.NomeLivro.Text = "Nome do Livro";
            this.NomeLivro.Width = 204;
            // 
            // AutorLivro
            // 
            this.AutorLivro.Text = "Autor";
            this.AutorLivro.Width = 153;
            // 
            // GeneroLivro
            // 
            this.GeneroLivro.Text = "Gênero";
            this.GeneroLivro.Width = 142;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(411, 33);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(109, 34);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(285, 20);
            this.txtConsulta.TabIndex = 8;
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbtNome);
            this.gpbOpcoes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOpcoes.ForeColor = System.Drawing.Color.Black;
            this.gpbOpcoes.Location = new System.Drawing.Point(21, 12);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(82, 62);
            this.gpbOpcoes.TabIndex = 7;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Filtro:";
            // 
            // rbtNome
            // 
            this.rbtNome.AutoSize = true;
            this.rbtNome.Checked = true;
            this.rbtNome.Location = new System.Drawing.Point(7, 21);
            this.rbtNome.Name = "rbtNome";
            this.rbtNome.Size = new System.Drawing.Size(63, 20);
            this.rbtNome.TabIndex = 0;
            this.rbtNome.TabStop = true;
            this.rbtNome.Text = "Nome";
            this.rbtNome.UseVisualStyleBackColor = true;
            this.rbtNome.CheckedChanged += new System.EventHandler(this.rbtNome_CheckedChanged);
            // 
            // frmConsultarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 372);
            this.Controls.Add(this.lsvDados);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.gpbOpcoes);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Livros";
            this.Load += new System.EventHandler(this.frmConsultarLivros_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        private System.Windows.Forms.ColumnHeader CodigoLivro;
        private System.Windows.Forms.ColumnHeader NomeLivro;
        private System.Windows.Forms.ColumnHeader AutorLivro;
        private System.Windows.Forms.ColumnHeader GeneroLivro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbtNome;
        public System.Windows.Forms.ListView lsvDados;
    }
}