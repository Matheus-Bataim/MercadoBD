using MercadoBD.Controller;
using MercadoBD.Model;

namespace MercadoBD.View.TelaPedido
{
    public partial class TelaPDV : Form
    {

        public TelaPDV()
        {
            InitializeComponent();
        }

        private void btn_PdvBuscar_Click(object sender, EventArgs e)
        {
            Produto.Id_Produtos = Convert.ToInt32(btn_PdvBuscar.Text);
            grid_Itens.DataSource = ManipulaProduto.VisualizarProduto();

            tbx_PdvCod.Text = tbx_CodPdv.Text;
            tbx_PdvQuanti.Text = tbx_QuantiPdv.Text;

            Produto.NomeProdutos = tbx_PdvProd.Text;
            Produto.ValorProdutos = tbx_PdvValUni.Text;
            
        }
    }
}
