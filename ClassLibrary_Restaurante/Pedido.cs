using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Restaurante
{
	public class Pedido
	{
		public object comida { get; set; }
		public object bebida { get; set; }
		public object postre { get; set; }
		public float horaPedido { get; set; }
		public float horaEntrega { get; set; }

        public float calcularTiempo()
        {
            return horaEntrega - horaPedido;
        }
	}
}
