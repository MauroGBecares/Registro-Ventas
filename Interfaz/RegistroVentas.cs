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
    public partial class RegistroVentas : Form
    {
        private List<Ventas> listaVentas;
        public RegistroVentas()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void RegistroVentas_Load(object sender, EventArgs e)
        {
            cboCampoVentas.Items.Add("Cliente");
            cboCampoVentas.Items.Add("Fecha");
            cboCampoVentas.Items.Add("Total");
            cargarVentas();
        }
        public void cargarVentas()
        {
            VentasDatos datosVentas = new VentasDatos();
            try
            {
                listaVentas = datosVentas.listar();
                dgvVentas.DataSource = listaVentas;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            AltaVentasItems ventana = new AltaVentasItems();
            ventana.ShowDialog();
            cargarVentas();
        }

        private void btnBorrarVenta_Click(object sender, EventArgs e)
        {
            VentasDatos ventasDatos = new VentasDatos();
            try
            {
                if (dgvVentas.CurrentRow != null)
                {
                    Ventas seleccionado = (Ventas)dgvVentas.CurrentRow.DataBoundItem;
                    DialogResult resultado = MessageBox.Show("Esta seguro que quiere eliminar la venta?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        ventasDatos.EliminarVenta(seleccionado.Id);
                        cargarVentas();
                    }
                }
                else
                {
                    MessageBox.Show("No hay una venta seleccionada!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModificarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                Ventas seleccionada = (Ventas)dgvVentas.CurrentRow.DataBoundItem;
                AltaVentasItems ventana = new AltaVentasItems(seleccionada);
                ventana.ShowDialog();
                cargarVentas();
            }
            else
            {
                MessageBox.Show("No hay una venta seleccionada!");
            }
        }

        private void cboCampoVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampoVentas.SelectedItem.ToString();
            if (opcion == "Cliente")
            {
                dtpFiltroFecha.Visible = false;
                txtFiltroVentas.Visible = true;
                cboCriterioVentas.Visible = true;
                lblCriterioFiltroVentas.Visible = true;
                cboCriterioVentas.Items.Clear();
                cboCriterioVentas.Items.Add("Comienza con");
                cboCriterioVentas.Items.Add("Contiene");
                cboCriterioVentas.Items.Add("Termina con");
            }
            else if (opcion == "Fecha")
            {
                dtpFiltroFecha.Visible = true;
                txtFiltroVentas.Visible = false;
                cboCriterioVentas.Visible = false;
                lblCriterioFiltroVentas.Visible = false;
            }
            else
            {
                dtpFiltroFecha.Visible = false;
                txtFiltroVentas.Visible = true;
                cboCriterioVentas.Visible = true;
                lblCriterioFiltroVentas.Visible = true;
                cboCriterioVentas.Items.Clear();
                cboCriterioVentas.Items.Add("Menos a");
                cboCriterioVentas.Items.Add("Igual");
                cboCriterioVentas.Items.Add("Mayor a");
            }
        }

        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            VentasDatos ventasDatos = new VentasDatos();
            try
            {
                if (validarFiltro())
                    return;

                string filtro = txtFiltroVentas.Text;
                string campo = cboCampoVentas.Text;
                string criterio = cboCriterioVentas.Text;
                string fecha = dtpFiltroFecha.Value.ToString("yyyy-MM-dd");
                dgvVentas.DataSource = ventasDatos.fitroVentas(campo, criterio, filtro, fecha);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool validarFiltro()
        {
            if (cboCampoVentas.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo");
                return true;
            }
            if (cboCriterioVentas.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un criterio");
                return true;
            }
            if (cboCampoVentas.SelectedItem.ToString() == "Total")
            {
                if (string.IsNullOrEmpty(txtFiltroVentas.Text))
                {
                    MessageBox.Show("Debe cargar números");
                    return true;
                }
            }
            return false;
        }

        private void txtFiltroVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboCampoVentas.SelectedItem.ToString() == "Total")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            List<Ventas> listaFiltrada;
            string filtro = txtBuscarCodigo.Text;

            if (filtro.Length > 0)
                listaFiltrada = listaVentas.FindAll(x => x.Id.ToString().Contains(filtro));
            else
                listaFiltrada = listaVentas;

            dgvVentas.DataSource = null;
            dgvVentas.DataSource = listaFiltrada;
        }

        private void btnVisualizarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                Ventas seleccionada = (Ventas)dgvVentas.CurrentRow.DataBoundItem;
                VizualizacionVenta ventana = new VizualizacionVenta(seleccionada);
                ventana.ShowDialog();
                cargarVentas();
            }
            else
            {
                MessageBox.Show("No hay una venta seleccionada!");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
