using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Modelo;
using Controle;

namespace Visao
{
    public partial class frmAlterarLivros : Form
    {
        private const int WS_SYSMENU = 0x80000;
        private clsLivroControle objLivroControlador = new clsLivroControle();

        public frmAlterarLivros()
        {
            InitializeComponent();
            objLivroControlador = new clsLivroControle();
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

        #region Variáveis Públicas

        public int codigo;
        public string nome, autor, genero;        

        #endregion

        #region Botões / Eventos

        private void frmAlterarLivros_Load(object sender, EventArgs e)
        {
            CarregarDados();                  
        }        

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            AlterarDados();                     
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            CancelarAlteracoes();
        }

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos

        private void AlterarDados()
        {
            bool camposValidados = false;

            try
            {                
                #region Validações dos Campos

                if (!String.IsNullOrEmpty(txtNomeLivro.Text))
                {
                    camposValidados = true;
                }
                else
                {
                    epErro.SetError(txtNomeLivro, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(txtAutor.Text))
                {
                    camposValidados = true;
                }
                else
                {
                    epErro.SetError(txtAutor, "O campo Autor é obrigatório!");
                    camposValidados = false;
                }         

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

                if (camposValidados)
                {
                    //Se os campos foram validados, chama o controlador para a atualização das informações
                    objLivroControlador.AlterarLivro(txtNomeLivro.Text, txtAutor.Text, txtGenero.Text, codigo);

                    //Exibo a mensagem ao usuário de confirmação da atualização no banco
                    MessageBox.Show("Registro alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Limpa os campos
                    LimparCampos();

                    //Fecha o formulário
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelarAlteracoes()
        {
            if (MessageBox.Show("Deseja cancelar as alterações?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimparCampos();
                this.Close();
            }
        }

        private void CarregarDados()
        {
            try
            {
                txtNomeLivro.Text = nome;
                txtAutor.Text = autor;
                txtGenero.Text = genero;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparCampos()
        {
            try
            {
                txtNomeLivro.Text = string.Empty;
                txtAutor.Text = string.Empty;                
                txtGenero.Text = string.Empty;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion               
    }
}
