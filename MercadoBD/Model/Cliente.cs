using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MercadoBD.Model
{
    internal class Cliente
    {
        private static int id_Clientes;
        private static string nomeClientes;
        private static string emailClientes;
        private static string foneClientes;

        
        public static string NomeClientes { get => nomeClientes; set => nomeClientes = value; }
        public static string EmailClientes { get => emailClientes; set => emailClientes = value; }
        public static string FoneClientes { get => foneClientes; set => foneClientes = value; }
        public static int Id_Clientes { get => id_Clientes; set => id_Clientes = value; }
    }
}
