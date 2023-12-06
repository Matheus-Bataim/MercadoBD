using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoBD.Model
{
    internal class Pedido
    {
        private static int id_Pedido;
        private static int id_ClienteFK;
        private static int id_FuncionariosFK;
        private static int id_itensProdutosFK;
        private static DateTime dataCompra;
        private static decimal totalPedido;
        private static int id_PedutosFk;
        private static int qtdProdutos;
        private static decimal totalIntens;

        public static int Id_Pedido { get => id_Pedido; set => id_Pedido = value; }
        public static int Id_ClienteFK { get => id_ClienteFK; set => id_ClienteFK = value; }
        public static int Id_FuncionariosFK { get => id_FuncionariosFK; set => id_FuncionariosFK = value; }
        public static int Id_itensProdutosFK { get => id_itensProdutosFK; set => id_itensProdutosFK = value; }
        public static DateTime DataCompra { get => dataCompra; set => dataCompra = value; }
        public static decimal TotalPedido { get => totalPedido; set => totalPedido = value; }
        public static int Id_PedutosFk { get => id_PedutosFk; set => id_PedutosFk = value; }
        public static int QtdProdutos { get => qtdProdutos; set => qtdProdutos = value; }
        public static decimal TotalIntens { get => totalIntens; set => totalIntens = value; }
    }
}