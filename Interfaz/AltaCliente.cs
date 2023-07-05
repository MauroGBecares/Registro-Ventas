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
    public partial class AltaCliente : Form
    {
        private Clientes datoCliente = null;
        public AltaCliente()
        {
            InitializeComponent();
            Text = "Agregar Cliente";
        }
        public AltaCliente(Clientes cliente)
        {
            InitializeComponent();
            this.datoCliente = cliente;
            Text = "Modificar Cliente";
        }

        private void btnAceptarAltaCliente_Click(object sender, EventArgs e)
        {
            ClientesDatos clientesDatos = new ClientesDatos();

            if (datoCliente == null)
                datoCliente = new Clientes();
            if (validarCarga())
                return;

            datoCliente.Cliente = txtCliente.Text;
            datoCliente.Telefono = txtTelefono.Text;
            datoCliente.Correo = txtCorreo.Text;
            if (datoCliente.Id == 0)
            {
                clientesDatos.AgregarCliente(datoCliente);
                MessageBox.Show("Agregado con éxito");
            }
            else
            {
                clientesDatos.ModificarCliente(datoCliente);
                MessageBox.Show("Modificado con éxito");
            }
            Close();
        }

        private void btnCancelarAltaCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            ClientesDatos clientesDatos = new ClientesDatos();
            try
            {
                if (datoCliente != null)
                {
                    txtCliente.Text = datoCliente.Cliente;
                    txtTelefono.Text = datoCliente.Telefono;
                    txtCorreo.Text = datoCliente.Correo;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool validarCarga()
        {
            if (string.IsNullOrEmpty(txtCliente.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe llenar los espacios vacios");
                return true;
            }
            return false;
        }
    }
}
