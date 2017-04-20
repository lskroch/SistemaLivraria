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
    public partial class frmAlterarExcluirLivros : Form
    {
        private const int WS_SYSMENU = 0x80000;
        public Principal principalControler;
        private clsLivroControle objLivroControlador;

        public frmAlterarExcluirLivros(Principal parentControler)
        {            
            InitializeComponent();
            this.principalControler = parentControler;
            objLivroControlador = new clsLivroControle();
            this.livrosBindingSource.DataSource = objLivroControlador.DsSistemaLivraria;
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

        private void dgvDados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Se a célula que o usuário clicou for a do botão Editar atribuo para as variáveis
            //publicas o valor de cada célula do Grid, referente ao respectivo registro
            if (dgvDados.CurrentCell.Value.ToString() == "Editar")
            {
                //Passo o ID do registro que será útil em meu UPDATE no outro form
                codigo = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].FormattedValue);
                nome = dgvDados.CurrentRow.Cells[1].FormattedValue.ToString();
                autor = dgvDados.CurrentRow.Cells[2].FormattedValue.ToString();               
                genero = dgvDados.CurrentRow.Cells[3].FormattedValue.ToString();                

                //Chamo o método Editar, passando as variáveis como parâmetros
                EditarRegistro(codigo, nome, autor, genero);
            }
            
            //Se a célula que o usuário clicou for a do botão Excluir chamo o método Excluir, passando como parâmetro 
            //a linha selecionada + a primeira célula, que contém meu ID com o valor formatado, convertido para Int32
            if (dgvDados.CurrentCell.Value.ToString() == "Excluir")
            {
                ExcluirRegistro(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].FormattedValue));
            }
        }

        public void frmAlterarExcluirLivros_Load(object sender, EventArgs e)
        {                       
            objLivroControlador.ListarLivroGrid();
        }

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            principalControler.OpenWindowConsultar();
        }

        private void frmAlterarExcluirLivros_FormClosing(object sender, FormClosingEventArgs e)
        {         
            this.Close();
        }

        void form_EditClosing(object sender, FormClosingEventArgs e)
        {
            this.objLivroControlador.ListarLivroGrid();
        }

        #endregion

        #region Métodos

        private void EditarRegistro(int codigo, string nome, string autor, string genero)
        {
            //Instancio o frmAlterar e atribuo ao valor de suas variáveis o valor das variáveis
            //pertencentes a assinatura deste método e abro o form, por meio do método ShowDialog
            frmAlterarLivros objFrmAlterar = new frmAlterarLivros();
            objFrmAlterar.codigo = codigo;
            objFrmAlterar.nome = nome;
            objFrmAlterar.autor = autor;
            objFrmAlterar.genero = genero;
            objFrmAlterar.FormClosing += form_EditClosing;
            objFrmAlterar.ShowDialog();
        }

        private void ExcluirRegistro(int codigo)
        {
            //Se o usuário confirmar a exclusão, crio a conexão com o banco e excluo o respectivo registro
            if (MessageBox.Show("Tem certeza que deseja excluir o registro?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //Se os confirmado, chama o controlador para a exclusão do registro
                    objLivroControlador.ExcluirLivro(codigo);

                    //Exibo a mensagem ao usuário de confirmação da exclusão no banco
                    MessageBox.Show("Registro excluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizo as informações em tela                  
                    this.objLivroControlador.ListarLivroGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion 

    }
}
