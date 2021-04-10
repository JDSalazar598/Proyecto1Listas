using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Restaurante
{
    public partial class Form1 : Form
    {
        Lista lista = new Lista();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Pedido pedido = new Pedido();

            cliente.nombre = textNombre.Text;
            cliente.Nit = textNit.Text;
            cliente.direccion = textDireccion.Text;
            pedido.comida = textComida.Text;
            pedido.bebida = textBebida.Text;
            pedido.postre = textPostre.Text;
            pedido.horaEntrada = double.Parse(textHoraPedido.Text);
            pedido.horaSalida = double.Parse(textHoraEntrega.Text);
            
            lista.AgregarPedidos(cliente, pedido);
            MessageBox.Show(" Generando pedido ");
            Agrega_tabla();
        }

        private void Agrega_tabla()
        {
            lista.mostrar(dataGridView1);
        }

        
        private void btnAtiempo_Click(object sender, EventArgs e)
        {
            lista.Atiempo(dataGridView1);
        }

        private void btnTarde_Click(object sender, EventArgs e)
        {
            lista.tarde(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agrega_tabla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
