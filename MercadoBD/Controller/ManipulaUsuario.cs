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
            SqlCommand cmd = new SqlCommand("P_DeletarUsuarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Id_Usuarios", Usuario.Id_Usuarios);
                cn.Open() ;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Excluido com Sucesso");
            }catch (Exception )
            {
                throw;
            }
            
        }
        public void VisualizarUsuario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarUsuarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            
            try//Tenta executar 
            {
                cmd.Parameters.AddWithValue("@Id_Funcionarios", Usuario.Id_Usuarios);
                cn.Open();
                var dr= cmd.ExecuteReader();//todo conteudo esta nesta var

                if (dr.Read())//se dr for lida 
                {
                    Usuario.Id_Usuarios = Convert.ToInt32(dr["Id_Usuarios"]);
                    Usuario.Tipo = dr["Tipo"].ToString();
                    Usuario.DataAcesso = dr["DataAcesso"].ToString();
                    Usuario.id_FuncionariosFK= Convert.ToInt32(dr["id_FuncionariosFK"]); 
                    Usuario.SenhaUsuarios = dr["SenhaUsuarios"].ToString();
                    Funcionario.NomeFuncionarios = dr["NomeFuncionarios"].ToString();
                    Funcionario.EmailFuncionarios = dr["EmailFuncionarios"].ToString();
                }

                else
                {
                    Usuario.Id_Usuarios=0;
                    Usuario.Tipo = "";
                    Usuario.DataAcesso = "";
                    Usuario.id_FuncionariosFK = 0;
                    Usuario.SenhaUsuarios = "";
                    MessageBox.Show("Tente novamente");
                }
            }
            catch (Exception ex )//Se não dar certo, mostra o erro 
            {
                MessageBox.Show(ex.Message);
            }

           
        }
        public void AlterarUsuario()
        {
            
        }
    }
}
