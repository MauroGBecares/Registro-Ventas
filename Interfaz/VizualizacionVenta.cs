using BaseDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class VizualizacionVenta : Form
    {
        private Ventas venta;
        private List<VentasItems> listaVentasItems;
        public VizualizacionVenta(Ventas ventas)
        {
            InitializeComponent();
            this.venta = ventas;
            this.ControlBox = false;
        }

        private void VizualizacionVenta_Load(object sender, EventArgs e)
        {
            VentasItemsDatos ventasItemsDatos = new VentasItemsDatos();
            listaVentasItems = ventasItemsDatos.listar(venta);
            dgvVizualizacion.DataSource = listaVentasItems;
            dgvVizualizacion.Columns["Venta"].Visible = false;
            dgvVizualizacion.Columns["Id"].Visible = false;
            lblCliente.Text = lblCliente.Text + " " + venta.Cliente.ToString();
            lblFecha.Text = lblFecha.Text + " " + venta.Fecha.ToString("yyyy-MM-dd");
            lblTotal.Text = lblTotal.Text + " " + venta.Total.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
