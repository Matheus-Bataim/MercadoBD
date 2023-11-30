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

namespace MercadoBD.View.TelaUsuario
{
    public partial class PesquisarUsuario : Form
    {
        public PesquisarUsuario()
        {
            InitializeComponent();
        }

        private void btn_PesquTipoUser_Click(object sender, EventArgs e)
        {
            Usuario.Tipo = cbox_PesquBuscaTipo.Text;
            dataGridView1.DataSource = ManipulaUsuario.VisualizarTipoUsuario();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderCell.Value = "Código do Usuário";
            dataGridView1.Columns[4].HeaderCell.Value = "Função";
            dataGridView1.Columns[5].HeaderCell.Value = "Data Acesso";
            dataGridView1.Columns[6].HeaderCell.Value = "Matrícula Funcinário";

        }

        private void btn_PesquCodUser_Click(object sender, EventArgs e)
        {
            Usuario.Id_Usuarios = Convert.ToInt32(tbx_PesquBuscaCodUser.Text);
            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.VisualizarUsuarios();
            cbox_PesquTipoCodUser.Text=Usuario.Tipo;
            tbx_PesquNomeCodUser.Text = Funcionario.NomeFuncionarios;
            tbx_PesquEmailCodUser.Text=Funcionario.EmailFuncionarios;
            dateTimePicker1.Text = Usuario.DataAcesso;
        }
    }
}
