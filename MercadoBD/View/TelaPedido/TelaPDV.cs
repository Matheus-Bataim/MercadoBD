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

        private void btn_PdvConfirmar_Click(object sender, EventArgs e)
        {   
            Produto.Id_Produtos=Convert.ToInt32(btn_PdvConfirmar.Text);
            dataGridView1.DataSource = ManipulaProduto.VisualizarProduto();

            dataGridView1.Columns[0].HeaderCell.Value = "Código";
            dataGridView1.Columns[1].HeaderCell.Value = "Produto";
            dataGridView1.Columns[2].HeaderCell.Value = "Marca";
            dataGridView1.Columns[3].HeaderCell.Value = "Valor";
            dataGridView1.Rows.Add();

        }
    }
}
