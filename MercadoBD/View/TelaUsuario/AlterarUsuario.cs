using MercadoBD.Controller;
using MercadoBD.Model;

namespace MercadoBD.View.TelaUsuario
{
    public partial class AlterarUsuario : Form
    {
        public AlterarUsuario()
        {
            InitializeComponent();
        }
        private void btn_AltBuscarUser_Click(object sender, EventArgs e)
        {
            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.VisualizarUsuarios();

            Funcionario.NomeFuncionarios = tbx_NomeAltUser.Text;
            Funcionario.EmailFuncionarios = tbx_EmailAltUser.Text;
            Usuario.Tipo = cbx_TipoAltUser.Text;
            Usuario.SenhaUsuarios = tbx_SenhaAltUser.Text;
            Usuario.Id_Usuarios = Convert.ToInt32(tbx_NumAltUser.Text);



        }

        private void btn_AltUser_Click(object sender, EventArgs e)
        {

        }
    }
}
