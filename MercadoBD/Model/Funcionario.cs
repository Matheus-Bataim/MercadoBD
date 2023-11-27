using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoBD.Model
{
    internal class Funcionario
    {
        private static string id_fun;
        private static string nome;
        private static string email;
        private static string fone;

       
        public static string NomeFuncionarios { get => nome; set => nome = value; }
        public static string EmailFuncionarios { get => email; set => email = value; }
        public static string FoneFuncionarios { get => fone; set => fone = value; }
        public static string Id_Funcioarios { get => id_fun; set => id_fun = value; }
    }
}
