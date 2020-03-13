using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeInformatica.Control
{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\valdinei.sazevedo\source\repos\LojaDeInformatica\LojaDeInformatica\BdLojaDeInformatica.mdf;Integrated Security=True";
        }
    }
}
