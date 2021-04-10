using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary_Restaurante
{
	public class ListaPedidos
	{
        private Nodo primero, ultimo;

        public ListaPedidos()
        {
            primero = null;
            ultimo = null;
        }

		public bool lista1_Vacia()
		{
			return primero == null;
		}

		
		public void AgregarPedidos(Cliente cliente, Pedido pedido)
		{
            Nodo nuevo = new Nodo();

            nuevo.Clientes = cliente;
            nuevo.Pedidos = pedido;
            nuevo.siguiente = null;
            nuevo.atras = null;

            if (lista1_Vacia())
            {
                primero = nuevo;
                primero.siguiente = null;
                primero.atras = null;
                ultimo = nuevo;
            }
		}

        public void mostrandoPedidos(DataGridView data)
        {
            Nodo actual = new Nodo();
            actual = primero;

            while (actual != null)
            {
            }
        }
	}
}
