using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Modelo;
using Controle;

namespace Visao
{
    public partial class frmCadastrarLivros : Form
    {
        private const int WS_SYSMENU = 0x80000;
        private clsLivroControle objLivroControlador = new clsLivroControle(); 
        public Principal principalControler;

        public frmCadastrarLivros(Principal parentControler)
        {            
            InitializeComponent();
            objLivroControlador = new clsLivroControle();
            this.principalControler = parentControler;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }

        #region Botões

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar e cancelar o cadastro?", "Mensagem do Sistema",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                //abre a tela de consulta
                this.principalControler.OpenWindowConsultar();
            }
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            //abre a tela de consulta
            this.principalControler.OpenWindowConsultar();       
        }

        #endregion

        #region Métodos

        private void Gravar()
        {
            //Crio uma variável booleana que irá verificar se os campos estão validados
            bool camposValidados = false;

            try
            {                
                #region Validações dos Campos                

                //Nome do Livro
                if (!String.IsNullOrEmpty(txtNomeLivro.Text))
                {
                    camposValidados = true;
                }
                else
                {
                    epErro.SetError(txtNomeLivro, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }

                //Autor
                if (!String.IsNullOrEmpty(txtAutor.Text))
                {
                    camposValidados = true;
                }
                else
                {
                    epErro.SetError(txtAutor, "O campo Autor é obrigatório!");
                    camposValidados = false;
                }
         
                //Gênero
                if (!String.IsNullOrEmpty(txtGenero.Text))
                {
                    camposValidados = true;
                }
                else
                {
                    epErro.SetError(txtGenero, "O campo Gênero é obrigatório!");
                    camposValidados = false;
                }

                #endregion

                //Verifico se o retorno de minha variável camposValidados é true
                if (camposValidados)
                {
                    
                    //Se os campos foram validados, chama o controlador para gravação dos dados
                    objLivroControlador.GravarLivro(txtNomeLivro.Text, txtAutor.Text, txtGenero.Text);

                    //Exibo a mensagem ao usuário de confirmação da inserção no banco
                    MessageBox.Show("Registro inserido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Chamo o método para limpar os campos e dou o foco ao txtNome
                    LimparCampos();
                    txtNomeLivro.Focus();

                    //Habilito o botão Voltar para o usuário
                    tsbtnVoltar.Enabled = true;
                }
                else
                {
                    //Exibo a mensagem ao usuário de erro
                    MessageBox.Show("Preencha os campos corretamente tente novamente",
                        "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtNomeLivro.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtGenero.Text = string.Empty;
        }

        #endregion
    }
}