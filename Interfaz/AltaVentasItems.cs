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
    public partial class AltaVentasItems : Form
    {
        private List<VentasItems> listaVentasItems;
        private VentasItems ventasItems = null;
        private List<Productos> listaProductos;
        private List<Clientes> listaClientes;
        private Ventas venta = null;
        private Ventas AcumuladorItems = null;
        public AltaVentasItems()
        {
            InitializeComponent();
            Text = "Agregar Venta";
            this.ControlBox = false;
        }
        public AltaVentasItems(Ventas venta)
        {
            InitializeComponent();
            this.venta = venta;
            this.AcumuladorItems = venta;
            cboClientes.Enabled = false;
            dtpFecha.Enabled = false;
            btnCancelarCarga.Visible = false;
            Text = "Modificar Venta";
            this.ControlBox = false;
        }
        public void cargarVentasItems()
        {
            VentasItemsDatos ventasItemsDatos = new VentasItemsDatos();
            if (venta == null)
            {
                try
                {
                    listaVentasItems = ventasItemsDatos.listar();
                    dgvVentaItems.DataSource = listaVentasItems;
                    dgvVentaItems.Columns["ID"].Visible = false;
                    dgvVentaItems.Columns["Venta"].Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    listaVentasItems = ventasItemsDatos.listar(venta);
                    dgvVentaItems.DataSource = listaVentasItems;
                    dgvVentaItems.Columns["ID"].Visible = false;
                    dgvVentaItems.Columns["Venta"].Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AltaVentasItems_Load(object sender, EventArgs e)
        {
            ProductosDatos productosDatos = new ProductosDatos();
            ClientesDatos clienteDatos = new ClientesDatos();
            VentasDatos ventasDatos = new VentasDatos();

            listaProductos = productosDatos.listar();
            cboProducto.DataSource = listaProductos;
            listaClientes = clienteDatos.listar();
            cboClientes.DataSource = listaClientes;
            ventasDatos.AgregarVentaNula();
            if (venta == null)
                lblTotal.Text = "Total: ";
            else
                lblTotal.Text = "Total: " + AcumuladorItems.Total;


            cargarVentasItems();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            VentasItemsDatos ventasItemsDatos = new VentasItemsDatos();
            Productos productoSeleccionado = (Productos)cboProducto.SelectedItem;
            double precioTotal = 0;
            bool hayVentaCargada = false;
            if (!(string.IsNullOrEmpty(txtCantidad.Text)))
            {
                if (ventasItems == null)
                ventasItems = new VentasItems();
           
            if (venta != null)
                hayVentaCargada = true;

            ventasItems.Producto = (Productos)cboProducto.SelectedItem;
            ventasItems.PrecioUnitario = productoSeleccionado.Precio;
            ventasItems.Cantidad = double.Parse(txtCantidad.Text);
            precioTotal = ventasItems.PrecioUnitario * ventasItems.Cantidad;
            ventasItems.PrecioTotal = precioTotal;


            ventasItemsDatos.AgregarVentasItems(ventasItems, hayVentaCargada, venta);
            if (AcumuladorItems == null)
                  AcumuladorItems = new Ventas();

             AcumuladorItems.Total += precioTotal;
             lblTotal.Text = "Total: " + AcumuladorItems.Total;

             cargarVentasItems();
            }
            else
            {
                MessageBox.Show("Falta cargar la cantidad!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btmEliminarProducto_Click(object sender, EventArgs e)
        {
            VentasItemsDatos ventasItemsDatos = new VentasItemsDatos();
            try
            {
                if (dgvVentaItems.CurrentRow != null)
                {
                    VentasItems seleccionado = (VentasItems)dgvVentaItems.CurrentRow.DataBoundItem;
                    DialogResult resultado = MessageBox.Show("Esta seguro que quiere eliminar el producto?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        ventasItemsDatos.EliminarVentaItem(seleccionado.Id);
                        AcumuladorItems.Total -= seleccionado.PrecioTotal;
                        lblTotal.Text = "Total: " + AcumuladorItems.Total;
                        cargarVentasItems();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un item!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {
            VentasItemsDatos ventasItemsDatos = new VentasItemsDatos();

            DialogResult resultado = MessageBox.Show("Esta seguro que no quiere conservar los cambios?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                ventasItemsDatos.CancelarCambiosVenta();
                Close();
            }
        }

        private void btnTerminarCarga_Click(object sender, EventArgs e)
        {
            VentasItemsDatos ventasItemsDatos = new VentasItemsDatos();
            bool esNuevaVenta;
            if (venta == null)
            {
                esNuevaVenta = true;
                venta = new Ventas();
                venta.Total = AcumuladorItems.Total;
                venta.Cliente = (Clientes)cboClientes.SelectedItem;
                DateTime fechaSeleccionada = dtpFecha.Value;
                DateTime fechaSinHora = new DateTime(fechaSeleccionada.Year, fechaSeleccionada.Month, fechaSeleccionada.Day);
                venta.Fecha = fechaSinHora;
                try
                {
                    ventasItemsDatos.GuardarVenta(venta, esNuevaVenta);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                esNuevaVenta = false;
                venta.Cliente = (Clientes)cboClientes.SelectedItem;
                venta.Fecha = dtpFecha.Value;
                try
                {
                    ventasItemsDatos.GuardarVenta(venta, esNuevaVenta);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificarCantidad_Click(object sender, EventArgs e)
        {
            if (dgvVentaItems.CurrentRow != null)
            {
                lblModificarCantidad.Visible = true;
                txtModificarCantidad.Visible = true;
                btnAceptarModificacion.Visible = true;
                btnModificarCantidad.Enabled = false;
                btnAgregarProducto.Enabled = false;
                btnTerminarCarga.Enabled = false;
                txtCantidad.Enabled = false;
                btnCancelarCarga.Enabled = false;
                btnEliminarProducto.Enabled = false;
                cboProducto.Enabled = false;
                VentasItems seleccionado = (VentasItems)dgvVentaItems.CurrentRow.DataBoundItem;
                this.ventasItems = seleccionado;
                txtModificarCantidad.Text = ventasItems.Cantidad.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un item!");
            }
        }

        private void btnAceptarModificacion_Click(object sender, EventArgs e)
        {
            VentasItemsDatos ventasItemsDatos = new VentasItemsDatos();
            try
            {
                if(!string.IsNullOrEmpty(txtModificarCantidad.Text))
                {
                    btnModificarCantidad.Enabled = true;
                    lblModificarCantidad.Visible = false;
                    txtModificarCantidad.Visible = false;
                    txtCantidad.Enabled = true;
                    btnAceptarModificacion.Visible = false;
                    btnAgregarProducto.Enabled = true;
                    btnTerminarCarga.Enabled = true;
                    btnCancelarCarga.Enabled = true;
                    btnEliminarProducto.Enabled = true;
                    cboProducto.Enabled = true;
                    AcumuladorItems.Total -= ventasItems.PrecioTotal;
                    ventasItems.PrecioTotal = double.Parse(txtModificarCantidad.Text) * ventasItems.PrecioUnitario;
                    AcumuladorItems.Total += double.Parse(txtModificarCantidad.Text) * ventasItems.PrecioUnitario;
                    lblTotal.Text = "Total: " + AcumuladorItems.Total;
                    ventasItemsDatos.ModificarCantidad(ventasItems, double.Parse(txtModificarCantidad.Text));
                    ventasItems = null;
                    cargarVentasItems();
                }
                else
                {
                    MessageBox.Show("No hay una cantidad ingresada!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModificarCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
