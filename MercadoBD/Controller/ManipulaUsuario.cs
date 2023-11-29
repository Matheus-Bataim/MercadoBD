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


        public void InserirUsuario() { }

        public void DeletarUsuario()
        {
            using (SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar()))
            {
                using (SqlCommand cmd = new SqlCommand("P_DeletarUsuarios", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário excluido com sucesso");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public void VisualizarCodigoUsuario()
        {
            using (SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar()))
            {
                using (SqlCommand cmd = new SqlCommand("P_BuscarCodigoUsuario", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    try
                    {
                        cn.Open();
                        cmd.Parameters.AddWithValue(" @Id_Funcionario", Usuario.Id_Usuarios);
                        var dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Usuario.Id_Usuarios = Convert.ToInt32(dr["Id_Usuario"]);
                            Usuario.Tipo.DataAcesso = dr["DataAcesso"].ToString();
                        }
                        else
                        {
                            Usuario.id_FuncionariosFK = Convert.ToInt32(dr["Id_FuncionarioFk"]);
                            Usuario.SenhaUsuarios = dr["senha"].ToString();
                            Funcionario.NomeFuncionarios = Funcionario.EmailFuncionarios = dr["Nome Funcionario"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {

                        Usuario.SenhaUsuarios = Usuario.Id_Usuarios = Usuario.Tipo.DataAcesso = string.Empty;
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        public void AlterarUsuario()
        {
            using (SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar()))
            {
                using (SqlCommand cmd = new SqlCommand("P_AlterarUsuario", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    try
                    {
                        cn.Open();
                        cmd.Parameters.AddWithValue(" @id_Usuario", Usuario.Id_Usuarios);
                        cmd.Parameters.AddWithValue(" @Tipo", Usuario.Tipo.ToString());
                        cmd.Parameters.AddWithValue(" @senha", Usuario.SenhaUsuarios);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario Alterado com sucesso");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Usuario não alterado");
                    }
                }
            }
        }

    }
}
}
