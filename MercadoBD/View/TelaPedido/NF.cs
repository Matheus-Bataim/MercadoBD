using MercadoBD.Controller;
using MercadoBD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoBD.View.TelaPedido
{
    public partial class NF : Form
    {
        decimal valorFinal = 0;
        TelaPDV telaPDV;
        public void BuscadoDatagrid()
        {


        }
       
        public NF(TelaPDV tela)
        {
            telaPDV = tela;

            InitializeComponent();
         
            
            for (int i = 0; i < tela.grid_Itens.RowCount - 1; i++)
            {
                nf_itens.Text += "Produto :" + tela.grid_Itens.Rows[i].Cells[1].Value.ToString() + "\n";
                nf_itens.Text += "Valor  :" + tela.grid_Itens.Rows[i].Cells[2].Value.ToString() + "\n";
                nf_itens.Text += "Qtde  :" + tela.grid_Itens.Rows[i].Cells[3].Value.ToString() + "\n";
                nf_itens.Text += " " + "R$" + tela.grid_Itens.Rows[i].Cells[4].Value.ToString() + ",00" + "\n";
                valorFinal += Convert.ToInt32(tela.grid_Itens.Rows[i].Cells[4].Value);
            }

            lbl_valorTotal.Text = "R$ " + valorFinal + ",00".ToString();
        }

        private void NF_Load(object sender, EventArgs e)
        {

            lbl_Data.Text = DateTime.Now.ToString();

        }

        private void Finalizar_NF_Click(object sender, EventArgs e)
        { 

            for (int i = 0; i < telaPDV.grid_Itens.RowCount - 1; i++)
            {
                Pedido.Id_PedutosFk = (int)telaPDV.grid_Itens.Rows[i].Cells[1].Value.ToString();
               Pedido.QtdProdutos = (int)telaPDV.grid_Itens.Rows[i].Cells[2].Value;
                Pedido.TotalPedido = (decimal)telaPDV.grid_Itens.Rows[i].Cells[2].Value;

                ManipulaPedido manipulaPedido = new();
                manipulaPedido.CadastrarPedido();
            }

            lbl_valorTotal.Text = "R$ " + valorFinal + ",00".ToString();

        }
    }
}
