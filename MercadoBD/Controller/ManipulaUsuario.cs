using MercadoBD.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MercadoBD.Controller
{
    internal class ManipulaUsuario
    {
        // SqlConnection cn = new(ConexaoBanco.Conectar());
        // SqlCommand cmd = new SqlCommand();
       
       
        public void DeletarUsuario()
        {
            SqlConnection cn = new(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarProdutos", cn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            try
            {
                cmd.Parameters.AddWithValue("@Id_Usuarios", Usuario.Id_Usuarios);
                conect(cn) ;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido Excluido com Sucesso");
            }catch (Exception )
            {
                throw;
            }
            static void conect(SqlConnection cn)
            {
                cn.Open();
            }
        }
        public void VisualizarUsuario(SqlConnection cnr)
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarUsuarios", cn)
            {
                CommandType=System.Data.CommandType.StoredProcedure 
            };
            try//Tenta executar 
            {
                cmd.Parameters.AddWithValue("id_FuncionariosFK", Usuario.Id_Usuarios);
              conect(cn);
               var dr= cmd.ExecuteReader();//todo conteudo esta nesta var

                if (dr.Read())//se dr for lida 
                {
                    Usuario.Id_Usuarios = Convert.ToInt32(dr["Id_Usuarios"]);
                    Usuario.Tipo=dr["Tipo"].ToString();
                    Usuario.DataAcesso=dr["DataAcesso"].ToString();
                    Usuario.id_FuncionariosFK= Convert.ToInt32(dr["DataAcesso"]); 
                    Usuario.SenhaUsuarios=dr["DataAcesso"].ToString();
                    Funcionario.NomeFuncionarios = dr["NomeFuncionario"].ToString();
                    Funcionario.EmailFuncionarios = dr["EmailFuncionario"].ToString();
                }

                else
                {
                    Usuario.Id_Usuarios=0;
                    Usuario.Tipo = string.Empty;
                    Usuario.DataAcesso = string.Empty;
                    Usuario.id_FuncionariosFK = 0;
                    Usuario.SenhaUsuarios = "";
                    Funcionario.NomeFuncionarios= string.Empty;
                    Funcionario.EmailFuncionarios= string.Empty;
                    MessageBox.Show("Tente novamente");
                }
            }
            catch (Exception )//Se não dar certo, mostra o erro 
            {
                throw;
            }
            static void conect(SqlConnection cn)
            {
                cn.Open();
            }
        }
        public void AlterarUsuario()
        {

        }

        internal void VisualizarUsuario()
        {
            
        }
    }
}
