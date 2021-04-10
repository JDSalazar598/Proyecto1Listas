using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Restaurante
{
    class Lista
    {
        private Nodo primero, ultimo;

        public Lista()
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
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.siguiente = null;
                nuevo.atras = ultimo;
                ultimo = nuevo;
            }
        }
        

        public void mostrar(DataGridView tabla )
        {
            Nodo mostrar = new Nodo();

            mostrar = primero;

            tabla.Rows.Clear();

            while (mostrar!= null)
            {
                if (mostrar.Pedidos.calcularTiempo()<=5)
                {
                    mostrar.Pedidos.estado = "A tiempo";
                }
                else if (mostrar.Pedidos.calcularTiempo()>5 && mostrar.Pedidos.calcularTiempo()<=10)
                {
                    mostrar.Pedidos.estado = " se tardo un poco";
                }
                else if(mostrar.Pedidos.calcularTiempo()>10)
                {
                    mostrar.Pedidos.estado = " se a tardado mucho ";
                }
                
                tabla.Rows.Add(mostrar.Clientes.nombre, mostrar.Clientes.Nit, mostrar.Clientes.direccion, 
                    mostrar.Pedidos.comida, mostrar.Pedidos.bebida, mostrar.Pedidos.postre, 
                    mostrar.Pedidos.calcularTiempo(), mostrar.Pedidos.estado);

                mostrar = mostrar.siguiente;
            }

            tabla.ClearSelection();
        }

        public void Atiempo(DataGridView tabla)
        {
            Nodo atiempo = new Nodo();

            atiempo = primero;

            tabla.Rows.Clear();

            while (atiempo!=null)
            {
                if (atiempo.Pedidos.calcularTiempo() <= 5)
                {
                    tabla.Rows.Add(atiempo.Clientes.nombre, atiempo.Clientes.Nit, atiempo.Clientes.direccion,
                    atiempo.Pedidos.comida, atiempo.Pedidos.bebida, atiempo.Pedidos.postre,
                    atiempo.Pedidos.calcularTiempo(), atiempo.Pedidos.estado);
                }

                atiempo = atiempo.siguiente;
            }

            tabla.ClearSelection();
        }

        public void tarde(DataGridView tabla)
        {
            Nodo tarde = new Nodo();

            tarde = primero;

            tabla.Rows.Clear();

            while (tarde != null)
            {
                if (tarde.Pedidos.calcularTiempo()>10)
                {
                    tabla.Rows.Add(tarde.Clientes.nombre, tarde.Clientes.Nit, tarde.Clientes.direccion,
                    tarde.Pedidos.comida, tarde.Pedidos.bebida, tarde.Pedidos.postre,
                    tarde.Pedidos.calcularTiempo(), tarde.Pedidos.estado);
                }

                tarde = tarde.siguiente;
            }

            tabla.ClearSelection();
        }
    }
}
