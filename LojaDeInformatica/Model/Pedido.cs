using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeInformatica.Model
{
    class Pedido
    {
        private static int idPedido;
        private static DateTime dataPedido;
        private static int quantidadePedido;
        private static double totalPedido;

        public static int IdPedido { get => idPedido; set => idPedido = value; }
        public static DateTime DataPedido { get => dataPedido; set => dataPedido = value; }
        public static int QuantidadePedido { get => quantidadePedido; set => quantidadePedido = value; }
        public static double TotalPedido { get => totalPedido; set => totalPedido = value; }
    }
}
