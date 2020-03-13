using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeInformatica.Model
{
    class Cliente
    {
        private static int idCliente;
        private static string nomeCLiente;
        private static long cpfCliente;
        private static string enderecoCliente;
        private static DateTime dataDeNascimento;

        public static int IdCliente { get => idCliente; set => idCliente = value; }
        public static string NomeCLiente { get => nomeCLiente; set => nomeCLiente = value; }
        public static long CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public static string EnderecoCliente { get => enderecoCliente; set => enderecoCliente = value; }
        public static DateTime DataDeNascimento { get => dataDeNascimento; set => dataDeNascimento = value; }
    }
}
