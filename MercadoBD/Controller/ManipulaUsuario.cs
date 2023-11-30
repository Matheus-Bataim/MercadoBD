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

        public void InserirUsuario() { }

        public void DeletarUsuario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarUsuarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Id_Usuarios", Usuario.Id_Usuarios);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário excluido com sucesso");
            }
            catch (Exception)
            {
                throw;
            }

        }

        //Lembrar de Corrigir o formato do P_Usuario.DataAcesso (date) para (int)
        public void VisualizarUsuarios()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarCodigoUsuario", cn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cn.Open();
                cmd.Parameters.AddWithValue(" @Id_Funcionario", Usuario.Id_Usuarios);
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Usuario.Id_Usuarios = Convert.ToInt32(dr["Id_Usuario"]);
                    Usuario.DataAcesso = dr["DataAcesso"].ToString();
                }
                else
                {
                    Usuario.id_FuncionariosFK = Convert.ToInt32(dr["Id_FuncionarioFk"]);
                    Usuario.SenhaUsuarios = dr["SenhaUsuarios"].ToString();
                    Funcionario.NomeFuncionarios = Funcionario.EmailFuncionarios = dr["Nome Funcionario"].ToString();
                }
            }
            catch (Exception ex)
            {

                Usuario.SenhaUsuarios = Usuario.DataAcesso = string.Empty;
                Usuario.Id_Usuarios = 0;
                MessageBox.Show(ex.Message);
            }
        }

        public void AlterarUsuario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarUsuario", cn);

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





