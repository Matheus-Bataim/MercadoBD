using MercadoBD.View.TelaCliente;
using MercadoBD.View.TelaFuncionarios;
using MercadoBD.View.TelaProduto;
using MercadoBD.View.TelaUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoBD.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios();
            cadastroFuncionarios.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarCliente_ alterarCliente = new();
            alterarCliente.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletarCliente deletarCliente = new DeletarCliente();
            deletarCliente.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarCliente pesquisarCliente = new PesquisarCliente();
            pesquisarCliente.Show();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlterarFuncionario alterarFuncionario = new();
            alterarFuncionario.Show();
        }

        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeletarFuncionario deletarFuncionario = new();
            deletarFuncionario.Show();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisarFuncionario pesquisarFuncionario = new();
            pesquisarFuncionario.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadastrarProduto = new CadastrarProduto();
            cadastrarProduto.Show();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AlterarProduto alterarFuncionario = new();
            alterarFuncionario.Show();
        }

        private void deletarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeletarFuncionario delarFuncionario = new();
            delarFuncionario.Show();
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PesquisarFuncionario pesquisarFuncionario = new();
            pesquisarFuncionario.Show();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cadastrarUsuario = new CadastrarUsuario();
            cadastrarUsuario.Show();
        }

        private void alterarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AlterarUsuario alterarUsuario = new AlterarUsuario();
            alterarUsuario.Show();
        }

        private void deletarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeletarUsuario deletarUsuario = new DeletarUsuario();
            deletarUsuario.Show();
        }

        private void pesquisarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PesquisarUsuario pesquisarUsuario = new();
            pesquisarUsuario.Show();
        }
    }
}
