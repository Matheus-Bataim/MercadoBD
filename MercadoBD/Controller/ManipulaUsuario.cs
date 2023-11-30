using MercadoBD.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MercadoBD.Controller
{
    internal class ManipulaUsuario
    {

        public void AddUsuario() 
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirUsuarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Tipo", Usuario.Tipo);
                cmd.Parameters.AddWithValue("@SenhaUsuarios", Usuario.SenhaUsuarios);
                cmd.Parameters.AddWithValue("@Id_FuncionariosFK", Funcionario.Id_Funcioarios);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário incluido com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
            
        }

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

        
        public void VisualizarUsuarios()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarUsuarios", cn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                cn.Open();
                cmd.Parameters.AddWithValue("@Id_Funcionarios", Usuario.Id_Usuarios);
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Usuario.Id_Usuarios = Convert.ToInt32(dr["Id_Usuarios"]);
                    Usuario.Tipo = dr["Tipo"].ToString();
                    Usuario.Id_FuncionariosFK = Convert.ToInt32(dr["id_FuncionariosFK"]);
                    Usuario.SenhaUsuarios = dr["SenhaUsuarios"].ToString();
                    Funcionario.NomeFuncionarios = dr["NomeFuncionarios"].ToString();
                    Funcionario.EmailFuncionarios = dr["EmailFuncinarios"].ToString();
                }
                else
                {
                    Usuario.Id_FuncionariosFK = 0;
                    Usuario.Tipo = "";
                    Usuario.DataAcesso = "";
                    Usuario.Id_FuncionariosFK = 0;
                    Usuario.SenhaUsuarios = "";
                    MessageBox.Show("Busca não Executada..");

                }
            }
            catch (Exception ex)
            {

              
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
        public static BindingSource VisualizarTipoUsuario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarTipoUsuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TipoUsuarios", Usuario.Tipo);        
            cn.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            BindingSource dados = new BindingSource();
            dados.DataSource = table;
             
            return dados;
           
        }
    }
}





