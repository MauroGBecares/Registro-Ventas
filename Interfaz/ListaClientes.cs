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
    public partial class ListaClientes : Form
    {
        private List<Clientes> listarClientes;
        public ListaClientes()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public void cargarClientes()
        {
            ClientesDatos clientesDatos = new ClientesDatos();
            try
            {
                listarClientes = clientesDatos.listar();
                dgvClientes.DataSource = listarClientes;
                dgvClientes.Columns["Id"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListaClientes_Load(object sender, EventArgs e)
        {
            cboCampoCliente.Items.Add("Nombre o Razon Social");
            cboCampoCliente.Items.Add("Teléfono");
            cboCampoCliente.Items.Add("Correo");
            cargarClientes();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AltaCliente ventanaCliente = new AltaCliente();
            ventanaCliente.ShowDialog();
            cargarClientes();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Clientes seleccionado = (Clientes)dgvClientes.CurrentRow.DataBoundItem;
                AltaCliente ventana = new AltaCliente(seleccionado);
                ventana.ShowDialog();
                cargarClientes();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            ClientesDatos clientesDatos = new ClientesDatos();
            try
            {
                if (dgvClientes.CurrentRow != null)
                {
                    Clientes seleccionado = (Clientes)dgvClientes.CurrentRow.DataBoundItem;
                    DialogResult resultado = MessageBox.Show("Esta seguro que quiere eliminar el cliente?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        clientesDatos.eliminarCliente(seleccionado.Id);
                        cargarClientes();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ClientesDatos clientesDatos = new ClientesDatos();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampoCliente.SelectedItem.ToString();
                string criterio = cboCriterioCliente.SelectedItem.ToString();
                string filtro = txtFiltroCliente.Text;
                dgvClientes.DataSource = clientesDatos.filtroCliente(campo, criterio, filtro);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCampoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampoCliente.Items.ToString();
            if (!(string.IsNullOrEmpty(opcion)))
            {
                cboCriterioCliente.Items.Clear();
                cboCriterioCliente.Items.Add("Comienza con");
                cboCriterioCliente.Items.Add("Contiene");
                cboCriterioCliente.Items.Add("Termina con");
            }
            else
            {
                cboCriterioCliente.Items.Clear();
            }
        }
        private bool validarFiltro()
        {
            if (cboCampoCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo");
                return true;
            }
            if (cboCriterioCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un criterio");
                return true;
            }
            return false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
