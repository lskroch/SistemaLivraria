namespace Visao
{
    partial class frmAlterarLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarLivros));
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNomeLivro.Location = new System.Drawing.Point(13, 45);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(103, 16);
            this.lblNomeLivro.TabIndex = 33;
            this.lblNomeLivro.Text = "Nome do Livro:";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(122, 44);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(348, 20);
            this.txtNomeLivro.TabIndex = 32;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAutor.Location = new System.Drawing.Point(13, 76);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(46, 16);
            this.lblAutor.TabIndex = 35;
            this.lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(122, 76);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(348, 20);
            this.txtAutor.TabIndex = 34;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Arial", 10F);
            this.lblGenero.Location = new System.Drawing.Point(13, 110);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(60, 16);
            this.lblGenero.TabIndex = 40;
            this.lblGenero.Text = "Gênero:";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(122, 108);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(260, 20);
            this.txtGenero.TabIndex = 45;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnGravar,
            this.tsbtnCancelar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(517, 31);
            this.toolStrip2.TabIndex = 27;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtnGravar
            // 
            this.tsbtnGravar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGravar.Image")));
            this.tsbtnGravar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGravar.Name = "tsbtnGravar";
            this.tsbtnGravar.Size = new System.Drawing.Size(69, 28);
            this.tsbtnGravar.Text = "Gravar";
            this.tsbtnGravar.Click += new System.EventHandler(this.tsbtnGravar_Click);
            // 
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancelar.Image")));
            this.tsbtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(81, 28);
            this.tsbtnCancelar.Text = "Cancelar";
            this.tsbtnCancelar.Click += new System.EventHandler(this.tsbtnCancelar_Click);
            // 
            // epErro
            // 
            this.epErro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epErro.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnVoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 221);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(517, 31);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
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
            // frmAlterarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 252);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblNomeLivro);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.toolStrip2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Livros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAlterarLivros_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeLivro;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripButton tsbtnGravar;
        public System.Windows.Forms.ToolStripButton tsbtnCancelar;        
        private System.Windows.Forms.ErrorProvider epErro;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
    }
}