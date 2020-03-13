using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeInformatica.Model
{
    class Produto
    {
        private static int codigoProduto;
        private static string marcaProduto;
        private static string descricaoProduto;
        private static DateTime dataDeEntrada;
        private static int quantidadeProduto;
        private static double valorProduto;

        public static int CodigoProduto { get => codigoProduto; set => codigoProduto = value; }
        public static string MarcaProduto { get => marcaProduto; set => marcaProduto = value; }
        public static string DescricaoProduto { get => descricaoProduto; set => descricaoProduto = value; }
        public static DateTime DataDeEntrada { get => dataDeEntrada; set => dataDeEntrada = value; }
        public static int QuantidadeProduto { get => quantidadeProduto; set => quantidadeProduto = value; }
        public static double ValorProduto { get => valorProduto; set => valorProduto = value; }
    }
}
