using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoBD.Model
{
    internal class Produto
    {
        private static int id_Produtos;
        private static string nome;
        private static string marca;
        private static string valor;

        public static int Id_Produtos { get => id_Produtos; set => id_Produtos = value; }
        public static string NomeProdutos { get => nome; set => nome = value; }
        public static string MarcaProdutos { get => marca; set => marca = value; }
        public static string ValorProdutos { get => valor; set => valor = value; }
    }
}
