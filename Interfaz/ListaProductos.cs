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
    public partial class ListaProductos : Form
    {
        private List<Productos> listaProductos;
        public ListaProductos()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public void cargarProductos()
        {
            ProductosDatos productosDatos = new ProductosDatos();
            try
            {
                listaProductos = productosDatos.listar();
                dgvProductos.DataSource = listaProductos;
                dgvProductos.Columns["Id"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            cboCampoProducto.Items.Add("Nombre");
            cboCampoProducto.Items.Add("Precio");
            cboCampoProducto.Items.Add("Categoria");
            cargarProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaProducto ventana = new AltaProducto();
            ventana.ShowDialog();
            cargarProductos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos != null)
            {
                Productos seleccionado = (Productos)dgvProductos.CurrentRow.DataBoundItem;
                AltaProducto ventana = new AltaProducto(seleccionado);
                ventana.ShowDialog();
                cargarProductos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductosDatos productosDatos = new ProductosDatos();
            try
            {
                if (dgvProductos != null) 
                {
                    Productos seleccionado = (Productos)dgvProductos.CurrentRow.DataBoundItem;
                    DialogResult resultado = MessageBox.Show("Esta seguro que quiere eliminar el producto?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        productosDatos.EliminarProducto(seleccionado.Id);
                        cargarProductos();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCampoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampoProducto.SelectedItem.ToString();
            if (opcion == "Nombre" || opcion == "Categoria")
            {
                cboCriterioProducto.Items.Clear();
                cboCriterioProducto.Items.Add("Comienza con");
                cboCriterioProducto.Items.Add("Contiene");
                cboCriterioProducto.Items.Add("Termina con");
            }
            else
            {
                cboCriterioProducto.Items.Clear();
                cboCriterioProducto.Items.Add("Menos a");
                cboCriterioProducto.Items.Add("Igual");
                cboCriterioProducto.Items.Add("Mayor a");
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            ProductosDatos productosDatos = new ProductosDatos();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampoProducto.SelectedItem.ToString();
                string criterio = cboCriterioProducto.SelectedItem.ToString();
                string filtro = txtFiltroProducto.Text;
                dgvProductos.DataSource = productosDatos.filtroProducto(campo, criterio, filtro);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool validarFiltro()
        {
            if (cboCampoProducto.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo");
                return true;
            }
            if (cboCriterioProducto.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un criterio");
                return true;
            }
            if (cboCampoProducto.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroProducto.Text))
                {
                    MessageBox.Show("Debe cargar números");
                    return true;
                }
            }
            return false;
        }

        private void txtFiltroProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboCampoProducto.SelectedItem.ToString() == "Precio")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
