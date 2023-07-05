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
    public partial class AltaProducto : Form
    {
        private Productos datoProducto = null;
        public AltaProducto()
        {
            InitializeComponent();
            Text = "Agregar Producto";
        }

        public AltaProducto(Productos producto)
        {
            InitializeComponent();
            this.datoProducto = producto;
            Text = "Modificar Producto";
        }
        private void btnAceptarAltaProducto_Click(object sender, EventArgs e)
        {
            ProductosDatos productosDatos = new ProductosDatos(); 
            if (datoProducto == null)
                datoProducto= new Productos();

            datoProducto.Nombre = txtNombreProducto.Text;
            datoProducto.Precio = double.Parse(txtPrecioProducto.Text);
            datoProducto.Categoria = txtCategoriaProducto.Text;
            if (datoProducto.Id == 0)
            {
                productosDatos.AgregarProducto(datoProducto);
            }
            Close();    
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {
            ProductosDatos productoDatos = new ProductosDatos();
            try
            {
                if (datoProducto != null)
                {
                    txtNombreProducto.Text = datoProducto.Nombre;
                    txtPrecioProducto.Text = datoProducto.Precio.ToString("0.00");
                    txtCategoriaProducto.Text = datoProducto.Categoria;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error, contactese con el desarrollador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptarAltaProducto_Click_1(object sender, EventArgs e)
        {
            ProductosDatos productosDatos = new ProductosDatos();

            if (datoProducto == null)
                datoProducto = new Productos();

            if (validarCarga())
                return;

            datoProducto.Nombre = txtNombreProducto.Text;
            datoProducto.Precio = double.Parse(txtPrecioProducto.Text);
            datoProducto.Categoria = txtCategoriaProducto.Text;
            if (datoProducto.Id == 0)
            {
                productosDatos.AgregarProducto(datoProducto);
                MessageBox.Show("Agregado con éxito");
            }
            else
            {
                productosDatos.ModificarProducto(datoProducto);
                MessageBox.Show("Modificado con éxito");
            }
            Close();
        }
        private bool validarCarga()
        {
            if (string.IsNullOrEmpty(txtNombreProducto.Text) || string.IsNullOrEmpty(txtPrecioProducto.Text) || string.IsNullOrEmpty(txtCategoriaProducto.Text))
            {
                MessageBox.Show("Debe llenar los espacios vacios");
                return true;
            }
            return false;
        }

        private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
