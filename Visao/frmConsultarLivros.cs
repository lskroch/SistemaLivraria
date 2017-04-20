using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Controle;

namespace Visao
{
    public partial class frmConsultarLivros : Form
    {
        private const int WS_SYSMENU = 0x80000; 
        private clsLivroControle objLivroControlador = new clsLivroControle(); 

        public frmConsultarLivros()
        {
            InitializeComponent();
            objLivroControlador = new clsLivroControle();
            Consultar();
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

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        #endregion

        #region Eventos

        private void frmConsultarLivros_Load(object sender, EventArgs e)
        {
            txtConsulta.Focus();
        }

        private void rbtNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNome.Checked)
            {
                txtConsulta.Text = string.Empty;
                txtConsulta.Focus();
            }
        }

        #endregion

        private void Consultar()
        {
            try
            { 
                lsvDados.Items.Clear();
                
                //Verifico qual RadioButton o usuário checou e se o txtConsulta não está vazio para chamar o respectivo método
                string query = "";
                if (rbtNome.Checked && !String.IsNullOrEmpty(txtConsulta.Text))
                {
                    query = txtConsulta.Text;                    
                }

                //Uso o laço foreach para percorrer as linhas do LivroDataTable e carregá-las em meu ListView
                List<clsLivro> listaLivros = objLivroControlador.ListarLivro(query);                    
                foreach (clsLivro liv in listaLivros)
                {
                    //Instancio a classe ListViewItem e vou adicionando o item e subitens
                    ListViewItem objListViewItem = new ListViewItem();
                    objListViewItem.Text = liv.Id_Livro.ToString();
                    objListViewItem.SubItems.Add(liv.Nome_Livro);
                    objListViewItem.SubItems.Add(liv.Genero_Livro);
                    objListViewItem.SubItems.Add(liv.Autor_Livro);                        

                    //No final adiciono os itens em meu ListView, passando como parâmetro o objListViewItem carregado
                    lsvDados.Items.Add(objListViewItem);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
