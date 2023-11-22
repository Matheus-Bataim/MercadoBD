
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

namespace MercadoBD.View.TelaCliente
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btn_CadastrarCli_Click(object sender, EventArgs e)
        {
            // oque o usuario digita e guarda nessas caixas
            Cliente.NomeClientes = tbx_NomeCli.Text;
            Cliente.EmailClientes = tbx_EmailCli.Text;
            Cliente.FoneClientes = foneArea.Text;

            ManipulaCliente manipulaCliente = new ManipulaCliente();
            manipulaCliente.AddCliente();
        }
    }
}
