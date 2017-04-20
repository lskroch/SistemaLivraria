namespace Visao
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAlterarExcluir = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAlterarExcluir,
            this.tsbtnCadastrar,
            this.tsbtnConsultar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(556, 31);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAlterarExcluir
            // 
            this.tsbtnAlterarExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAlterarExcluir.Image")));
            this.tsbtnAlterarExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAlterarExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAlterarExcluir.Name = "tsbtnAlterarExcluir";
            this.tsbtnAlterarExcluir.Size = new System.Drawing.Size(115, 28);
            this.tsbtnAlterarExcluir.Text = "Alterar / Excluir";
            this.tsbtnAlterarExcluir.Click += new System.EventHandler(this.tsbtnAlterarExcluir_Click);
            // 
            // tsbtnCadastrar
            // 
            this.tsbtnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCadastrar.Image")));
            this.tsbtnCadastrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCadastrar.Name = "tsbtnCadastrar";
            this.tsbtnCadastrar.Size = new System.Drawing.Size(85, 28);
            this.tsbtnCadastrar.Text = "Cadastrar";
            this.tsbtnCadastrar.Click += new System.EventHandler(this.tsbtnCadastrar_Click);
            // 
            // tsbtnConsultar
            // 
            this.tsbtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConsultar.Image")));
            this.tsbtnConsultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConsultar.Name = "tsbtnConsultar";
            this.tsbtnConsultar.Size = new System.Drawing.Size(86, 28);
            this.tsbtnConsultar.Text = "Consultar";
            this.tsbtnConsultar.Click += new System.EventHandler(this.tsbtnConsultar_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSair});
            this.toolStrip2.Location = new System.Drawing.Point(0, 440);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(556, 31);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtnSair
            // 
            this.tsbtnSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSair.Image")));
            this.tsbtnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSair.Name = "tsbtnSair";
            this.tsbtnSair.Size = new System.Drawing.Size(54, 28);
            this.tsbtnSair.Text = "Sair";
            this.tsbtnSair.Click += new System.EventHandler(this.tsbtnSair_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 471);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Livraria";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;                
        public System.Windows.Forms.ToolStripButton tsbtnAlterarExcluir;
        public System.Windows.Forms.ToolStripButton tsbtnCadastrar;
        public System.Windows.Forms.ToolStripButton tsbtnConsultar;
        private System.Windows.Forms.ToolStripButton tsbtnSair;

    }
}

