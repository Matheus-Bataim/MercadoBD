using MercadoBD.Controller;
using MercadoBD.Model;
using Microsoft.VisualBasic;
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
    public partial class DeletarUsuario : Form
    {
        public DeletarUsuario()
        {
            InitializeComponent();
        }

        private void btn_exUser_Click(object sender, EventArgs e)
        {
            Usuario.Id_Usuarios = Convert.ToInt32(tbx_buscaDelser.Text);

            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.DeletarUsuario();

            tbx_NomeDelUser.Text = string.Empty;
            tbx_EmailDelUser.Text = string.Empty;
            tbx_NomeDelUser.Text = "0";
            cbox_tipoExUser.Text = string.Empty;
        }

        private void btn_BuscarExUser_Click(object sender, EventArgs e)
        {
            
            Usuario.Id_Usuarios = Convert.ToInt32(tbx_buscaDelser.Text);
            
            ManipulaUsuario manipulaUsuario=new ManipulaUsuario();
            manipulaUsuario.VisualizarUsuario();
            cbox_tipoExUser.Text = Usuario.Tipo;
            tbx_NomeDelUser.Text = Funcionario.NomeFuncionarios;
            tbx_EmailDelUser.Text = Funcionario.EmailFuncionarios;
            tbx_buscaDelser.Text = Usuario.Id_Usuarios.ToString();

        }
    }
}
