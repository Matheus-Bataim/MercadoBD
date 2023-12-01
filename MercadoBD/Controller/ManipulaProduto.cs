using MercadoBD.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoBD.Controller
{
    internal class ManipulaProduto
    {

        public void AddProduto()
        {
            //Instancia a classe ConexaoBanco
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());

            //Instancia a Procedure
            SqlCommand cmd = new SqlCommand("P_InserirProdutos", cn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            try
            {
                //pega o que esta pegando do .Cliente e colocando nas variaveis da Procedures
                cmd.Parameters.AddWithValue("@Nome", Cliente.NomeClientes);
                cmd.Parameters.AddWithValue("@EmailClientes", Cliente.EmailClientes);
                cmd.Parameters.AddWithValue("@FoneClientes", Cliente.FoneClientes);

                //Abre o Banco de Dados
                conect(cn);

                //Executa a Procedure "P_InserirClientes"
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Cadastrado com Sucesso");


            }
            catch
            {
                throw;
            }

            static void conect(SqlConnection cn)
            {
                cn.Open();
            }
        }

        public static BindingSource VisualizarProduto()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarCodigoProdutos", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Produtos", Produto.Id_Produtos);
            cn.Open();
            cmd.ExecuteNonQuery();

            
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);//os dados que vem do "cmd" é Adaptado/organizado em "sqlData
            DataTable table = new DataTable();//  cria/instância a tabela em "table"

            
            sqlData.Fill(table);//preenche a table com o que foi inserido em sqlData

            BindingSource dados = new BindingSource(); // instância BindingSource
            dados.DataSource = table; // Recebe table
            
            return dados;

        }
    }
}
