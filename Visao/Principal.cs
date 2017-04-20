using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visao
{
    public partial class Principal : Form
    {
        public EventArgs e { get; set; }
        public object sender { get; set; }

        public Principal()
        {
            InitializeComponent();            
            this.tsbtnConsultar_Click(sender, e);
        }

        #region Botões       

        private void tsbtnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrarLivros objFrmCadastrarLivros = new frmCadastrarLivros(this);

            //Informo a aplicação que o frmCadastrarLivros é o form filho do frmLivros
            objFrmCadastrarLivros.MdiParent = this;

            //Chamo o método que desativa os botões do formulário pai
            this.DesabilitaBotoes();

            //Vinculo ao botão Cancelar Cadastro, do form filho o método para ativar os botões do formulário pai, por meio de delegate
            objFrmCadastrarLivros.tsbtnCancelar.Click += new EventHandler(this.HabilitaBotoes);

            //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo
            if (objFrmCadastrarLivros.Visible == false)
            {
                objFrmCadastrarLivros.Show();
            }           
        }

        private void tsbtnAlterarExcluir_Click(object sender, EventArgs e)
        {
            frmAlterarExcluirLivros objFrmAlterarExcluirLivros = new frmAlterarExcluirLivros(this);

            //Informo a aplicação que o frmCadastrarLivros é o form filho do frmLivros
            objFrmAlterarExcluirLivros.MdiParent = this;

            //Chamo o método que desativa os botões do formulário pai
            this.DesabilitaBotoes();

            //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo
            if (objFrmAlterarExcluirLivros.Visible == false)
            {
                objFrmAlterarExcluirLivros.Show();
            }
        }

        private void tsbtnConsultar_Click(object sender, EventArgs e)
        {
            OpenWindowConsultar();            
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja sair do sistema?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        #region Métodos

        private void DesabilitaBotoes()
        {
            tsbtnAlterarExcluir.Enabled = false;
            tsbtnCadastrar.Enabled = false;
            tsbtnConsultar.Enabled = false;
            tsbtnSair.Enabled = false;
        } 

        private void HabilitaBotoes(object sender, EventArgs e)
        {
            tsbtnAlterarExcluir.Enabled = true;
            tsbtnCadastrar.Enabled = true;
            tsbtnConsultar.Enabled = true;
            tsbtnSair.Enabled = true;
        }

        public void OpenWindowConsultar()
        {
            frmConsultarLivros objFrmConsultarLivros = new frmConsultarLivros();

            //Informo a aplicação que o frmConsultarLivros é o form filho do frmLivros
            objFrmConsultarLivros.MdiParent = this;

            //Chamo o método que desativa os botões do formulário pai
            this.DesabilitaBotoes();

            //Vinculo ao botão Voltar, do form filho o método para ativar os botões do formulário pai, usando delegates
            objFrmConsultarLivros.tsbtnVoltar.Click += new EventHandler(this.HabilitaBotoes);

            //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo e exibo uma mensagem ao usuário
            if (objFrmConsultarLivros.Visible == false)
            {
                objFrmConsultarLivros.Show();
            }
        }

        #endregion             
    }
}
