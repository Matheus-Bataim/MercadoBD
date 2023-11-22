using MercadoBD.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MercadoBD.Controller
{
    internal class ManipulaCliente
    {
        public void AddCliente()
        { 
            //Instancia a classe ConexaoBanco
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());

            //Instancia a Procedure
            SqlCommand cmd = new SqlCommand("P_InserirClientes ", cn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                //pega o que esta pegando do .Cliente e colocando nas variaveis da Procedures
                cmd.Parameters.AddWithValue("@NomeClientes", Cliente.NomeClientes);
                cmd.Parameters.AddWithValue("@EmailClientes", Cliente.EmailClientes);
                cmd.Parameters.AddWithValue("@FoneClientes", Cliente.FoneClientes);

                //Abre o Banco de Dados
                cn.Open();

                //Executa a Procedure "P_InserirClientes"
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Cadastrado com Sucesso");


            }catch (Exception ex)
            {

            }
        }
    }
}
