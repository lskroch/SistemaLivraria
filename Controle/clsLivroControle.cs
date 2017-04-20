using System;
using System.Data;
using Modelo;
using System.Data.SqlClient;
using Controle.dsSistemaLivrariaTableAdapters;
using System.Collections.Generic;


namespace Controle
{
    public class clsLivroControle
    { 
        private SqlConnection objConexao = null;
        private SqlCommand objCommand = null;
        string strConn = null;
        string strConnection = @"Data Source=PC-Lucas\SQLEXPRESS;Initial Catalog=SistemaLivraria;Integrated Security=True";
        private dsSistemaLivraria.LivrosDataTable objLivrosDataTable = null;
        private LivrosTableAdapter objLivrosTableAdapter = null;
        private dsSistemaLivraria dsSistemaLivraria;

        public clsLivroControle()
        {
            this.dsSistemaLivraria = new dsSistemaLivraria();
            objLivrosDataTable = new dsSistemaLivraria.LivrosDataTable();
            this.dsSistemaLivraria.DataSetName = "dsSistemaLivraria";
            this.dsSistemaLivraria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        }

        //Retorna a lista de livros vinda do banco
        public List<clsLivro> ListarLivro(string txtConsulta)
        {
            try
            {
                //Controle de acesso as informações do banco               
                objLivrosTableAdapter = new LivrosTableAdapter();
                List<clsLivro> listaLivro  = new List<clsLivro>();              

                //Verifico qual RadioButton o usuário checou e se o txtConsulta não está vazio para chamar o respectivo método
                if (!String.IsNullOrEmpty(txtConsulta))
                {
                    //Preencho o TableAdapter com o método FillByNome, passando o DataTable e o txtConsulta como parâmetros
                    objLivrosTableAdapter.FillByNome(objLivrosDataTable, "%" + txtConsulta + "%");                 
                }
                else
                {
                    //Preencho o TableAdapter com o método FillBy, passando o DataTable como parâmetro                    
                    objLivrosTableAdapter.FillBy(objLivrosDataTable);
                }

                //Uso o laço foreach para percorrer as linhas do ClientesDataTable e carregá-las em meu ListView
                foreach (DataRow objDataRow in objLivrosDataTable.Rows)
                {
                    clsLivro livro = new clsLivro();
                    livro.Id_Livro = Int32.Parse(objDataRow[0].ToString());
                    livro.Nome_Livro = objDataRow[1].ToString();
                    livro.Genero_Livro = objDataRow[2].ToString();
                    livro.Autor_Livro = objDataRow[3].ToString();
                    listaLivro.Add(livro);
                }

                return listaLivro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Retorna a lista de livros vinda do banco para grid
        public void ListarLivroGrid()
        {
            try
            { 
               //Controle de acesso as informações do banco             
                objLivrosTableAdapter = new LivrosTableAdapter();
                objLivrosTableAdapter.FillBy(dsSistemaLivraria.Livros);
           
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Grava o livro no banco
        public void GravarLivro(string NomeLivro, string AutorLivro, string GeneroLivro)
        {
           try
            {
                //Instancio a classe de conexão passando como parâmetro a string de conexão ao DataBase SistemaLivraria
                objConexao = new SqlConnection(strConnection);

                //Armazeno em uma variável do tipo string minha instrução SQL referente à inserção do registro,
                //concatenando os valores parametrizados, referentes aos campos que serão preenchidos no form
                strConn = @"INSERT INTO Livros (Nome_Livro, Autor_Livro, Genero_Livro) VALUES (@Nome, @Autor, @Genero)";

                //Uso o objeto instanciado passando como parâmetro a string criada anteriomente e o objeto de conexão ao banco
                objCommand = new SqlCommand(strConn, objConexao);

                objCommand.Parameters.AddWithValue("@Nome", NomeLivro);
                objCommand.Parameters.AddWithValue("@Autor", AutorLivro);
                objCommand.Parameters.AddWithValue("@Genero", GeneroLivro);

                //Abro a conexão
                objConexao.Open();

                //Uso o método ExecuteNonQuery para executar os comandos e realizar o Insert no banco
                objCommand.ExecuteNonQuery();

                //Fecho a conexão
                objConexao.Close();                    
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Altera o livro no banco
        public void AlterarLivro(string NomeLivro, string AutorLivro, string GeneroLivro, int codigo)
        {
            try
            {
                //Instancio a classe de conexão passando como parâmetro a string de conexão ao DataBase SistemaLivraria
                objConexao = new SqlConnection(strConnection);

                //Armazeno em uma variável do tipo string minha instrução SQL referente à altualização do registro,
                //concatenando os valores parametrizados, referentes aos campos que serão preenchidos no form
                strConn = @"UPDATE Livros SET Nome_Livro = @Nome, Autor_Livro = @Autor, Genero_Livro = @Genero WHERE Id_Livro = " + codigo;

                //Uso o objeto instanciado passando como parâmetro a string criada anteriomente e o objeto de conexão ao banco
                objCommand = new SqlCommand(strConn, objConexao);

                objCommand.Parameters.AddWithValue("@Nome", NomeLivro);
                objCommand.Parameters.AddWithValue("@Autor", AutorLivro);
                objCommand.Parameters.AddWithValue("@Genero", GeneroLivro);

                //Abro a conexão
                objConexao.Open();

                //Uso o método ExecuteNonQuery para executar os comandos e realizar o Insert no banco
                objCommand.ExecuteNonQuery();

                //Fecho a conexão
                objConexao.Close();                    
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //Exlclui o livro no banco
        public void ExcluirLivro(int codigo)
        {
            try
            {
                //Instancio a classe de conexão passando como parâmetro a string de conexão ao DataBase SistemaLivraria
                objConexao = new SqlConnection(strConnection);

                //Armazeno em uma variável do tipo string minha instrução SQL referente à exclusão do registro,
                //concatenando os valores parametrizados, referentes aos campos que serão preenchidos no form
                strConn = @"DELETE FROM Livros WHERE ID_LIVRO = @Codigo";

                //Uso o objeto instanciado passando como parâmetro a string criada anteriomente e o objeto de conexão ao banco
                objCommand = new SqlCommand(strConn, objConexao);

                objCommand.Parameters.AddWithValue("@Codigo", codigo);

                //Abro a conexão
                objConexao.Open();

                //Uso o método ExecuteNonQuery para executar os comandos e realizar o Insert no banco
                objCommand.ExecuteNonQuery();

                //Fecho a conexão
                objConexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public dsSistemaLivraria DsSistemaLivraria
        {
            get { return dsSistemaLivraria; }
            set { dsSistemaLivraria = value; }
        }
        
    }
}
