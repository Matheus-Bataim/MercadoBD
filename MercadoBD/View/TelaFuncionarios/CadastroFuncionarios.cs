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

namespace MercadoBD.View.TelaFuncionarios
{
    public partial class CadastroFuncionarios : Form
    {
        public CadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void btn_cadastrarFun_Click(object sender, EventArgs e)
        {
            Funcionario.NomeFuncionarios = tbx_nomeFun.Text;
            Funcionario.EmailFuncionarios = tbx_emailFun.Text;
            Funcionario.FoneFuncionarios = foneFun.Text;

            ManipulaFuncionario manipulaFuncionario = new();
            manipulaFuncionario.AddFuncionario();
            
        }
    }
}
