using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeInformatica.Model
{
    class Funcionario
    {
        private static long cpfFun;
        private static string nomeFun;
        private static string enderecoFun;
        private static DateTime nascimentoFun;
        private static string senhaFun;

        public static long CpfFun { get => cpfFun; set => cpfFun = value; }
        public static string NomeFun { get => nomeFun; set => nomeFun = value; }
        public static string EnderecoFun { get => enderecoFun; set => enderecoFun = value; }
        public static DateTime NascimentoFun { get => nascimentoFun; set => nascimentoFun = value; }
        public static string SenhaFun { get => senhaFun; set => senhaFun = value; }
    }
}
