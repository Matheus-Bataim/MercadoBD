using MercadoBD.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoBD.Controller
{
    internal class ManipulaFuncionario     
    {
        public void AddFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirFuncionarios", cn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            try
            {
                
                cmd.Parameters.AddWithValue("@NomeFuncionarios", Funcionario.NomeFuncionarios);
                cmd.Parameters.AddWithValue("@EmailFuncionarios", Funcionario.EmailFuncionarios);
                cmd.Parameters.AddWithValue("@FoneFuncionarios", Funcionario.FoneFuncionarios);

                
                cn.Open();


                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário Cadastrado com Sucesso");


            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
