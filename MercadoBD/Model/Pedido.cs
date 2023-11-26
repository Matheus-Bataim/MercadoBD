using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoBD.Model
{
    internal class Pedido
    {
        private string nomeCli;
        private string nomeFun;
        private string totalPedi;

        public string NomeCli { get => nomeCli; set => nomeCli = value; }
        public string NomeFun { get => nomeFun; set => nomeFun = value; }
        public string TotalPedi { get => totalPedi; set => totalPedi = value; }
    }
}
