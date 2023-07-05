using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using BaseDatos;

namespace Interfaz
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ListaClientes ventana = new ListaClientes();
            ventana.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ListaProductos ventana = new ListaProductos();
            ventana.ShowDialog();
        }

        private void btnRegistroVentas_Click(object sender, EventArgs e)
        {
            RegistroVentas registroVentas = new RegistroVentas();
            registroVentas.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
