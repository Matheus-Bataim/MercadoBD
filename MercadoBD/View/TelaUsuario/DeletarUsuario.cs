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
            Usuario.Id_Usuarios = Convert.ToInt32(tbx_ExBuscarUser.Text);

            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.DeletarUsuario();

            tbx_ExNomeUser.Text = string.Empty;
            tbx_ExEmailUser.Text = string.Empty;
            tbx_ExNomeUser.Text = "0";
            cbox_ExTipoUser.Text = string.Empty;
        }
        
        private void btn_BuscarExUser_Click(object sender, EventArgs e)
        {
            
            Usuario.Id_Usuarios = Convert.ToInt32(tbx_ExBuscarUser.Text);
            
            ManipulaUsuario manipulaUsuario=new ManipulaUsuario();
            manipulaUsuario.VisualizarUsuarios();
            cbox_ExTipoUser.Text = Usuario.Tipo;
            tbx_ExNomeUser.Text = Funcionario.NomeFuncionarios;
            tbx_ExEmailUser.Text = Funcionario.EmailFuncionarios;
            tbx_ExBuscarUser.Text = Usuario.Id_Usuarios.ToString();

        }
    }
}
