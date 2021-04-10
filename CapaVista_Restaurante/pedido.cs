using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaVista_Restaurante
{
    class Pedido
    {
        public object comida { get; set; }
        public object bebida { get; set; }
        public object postre { get; set; }
        public double horaEntrada { get; set; }
        public double horaSalida { get; set; }
        public double tiempo { get; set; }
        public string estado { get; set; }

        
        public double calcularTiempo()
        {
            return tiempo = horaSalida - horaEntrada;
        }
    }
}
