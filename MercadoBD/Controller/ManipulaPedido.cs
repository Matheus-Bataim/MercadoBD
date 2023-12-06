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
    internal class ManipulaPedido
    {
        public void CadastrarPedido()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirItensProdutos", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Id_ProdutosFk", Pedido.Id_itensProdutosFK);
                cmd.Parameters.AddWithValue("@QtdProdutos", Pedido.QtdProdutos);
                cmd.Parameters.AddWithValue("@TotalItens", Pedido.TotalIntens);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Itens Cadastrados com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }

            
    }
}
