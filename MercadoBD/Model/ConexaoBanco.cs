using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoBD.Model
{
    public class ConexaoBanco
    {   //public: visivel a todo lugar da aplicação
        //private: somente dentro desta classe
        //protect: nesta classe e em suas heranças
        //
        //static: o método não pode ser instânciada, assim se tornando uma função
        //void : método vazio
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\matheus.pbataim\source\repos\Math-droid\MercadoBD\MercadoBD\Banco de Dados\MercadoBD.mdf"";Integrated Security=True";
        }
    }
}
