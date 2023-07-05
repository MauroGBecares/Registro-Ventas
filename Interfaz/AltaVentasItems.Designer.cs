namespace Interfaz
{
    partial class AltaVentasItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVentaItems = new System.Windows.Forms.DataGridView();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnTerminarCarga = new System.Windows.Forms.Button();
            this.btnCancelarCarga = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnModificarCantidad = new System.Windows.Forms.Button();
            this.txtModificarCantidad = new System.Windows.Forms.TextBox();
            this.lblModificarCantidad = new System.Windows.Forms.Label();
            this.btnAceptarModificacion = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentaItems
            // 
            this.dgvVentaItems.AllowUserToResizeColumns = false;
            this.dgvVentaItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentaItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVentaItems.Location = new System.Drawing.Point(12, 300);
            this.dgvVentaItems.MultiSelect = false;
            this.dgvVentaItems.Name = "dgvVentaItems";
            this.dgvVentaItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentaItems.Size = new System.Drawing.Size(641, 304);
            this.dgvVentaItems.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(45, 77);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 17);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(31, 101);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(71, 17);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(32, 125);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 17);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // cboClientes
            // 
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(109, 75);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(186, 21);
            this.cboClientes.TabIndex = 0;
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(109, 100);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(175, 21);
            this.cboProducto.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(119, 127);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(53, 20);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(408, 97);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(349, 100);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 17);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha:";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(12, 199);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(143, 23);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(12, 228);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(143, 23);
            this.btnEliminarProducto.TabIndex = 5;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btmEliminarProducto_Click);
            // 
            // btnTerminarCarga
            // 
            this.btnTerminarCarga.Location = new System.Drawing.Point(508, 229);
            this.btnTerminarCarga.Name = "btnTerminarCarga";
            this.btnTerminarCarga.Size = new System.Drawing.Size(145, 23);
            this.btnTerminarCarga.TabIndex = 7;
            this.btnTerminarCarga.Text = "Guardar Venta";
            this.btnTerminarCarga.UseVisualStyleBackColor = true;
            this.btnTerminarCarga.Click += new System.EventHandler(this.btnTerminarCarga_Click);
            // 
            // btnCancelarCarga
            // 
            this.btnCancelarCarga.Location = new System.Drawing.Point(508, 258);
            this.btnCancelarCarga.Name = "btnCancelarCarga";
            this.btnCancelarCarga.Size = new System.Drawing.Size(145, 23);
            this.btnCancelarCarga.TabIndex = 8;
            this.btnCancelarCarga.Text = "Cancelar Carga";
            this.btnCancelarCarga.UseVisualStyleBackColor = true;
            this.btnCancelarCarga.Click += new System.EventHandler(this.btnCancelarCambios_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(505, 607);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 13;
            // 
            // btnModificarCantidad
            // 
            this.btnModificarCantidad.Location = new System.Drawing.Point(12, 258);
            this.btnModificarCantidad.Name = "btnModificarCantidad";
            this.btnModificarCantidad.Size = new System.Drawing.Size(143, 23);
            this.btnModificarCantidad.TabIndex = 6;
            this.btnModificarCantidad.Text = "Modificar Cantidad";
            this.btnModificarCantidad.UseVisualStyleBackColor = true;
            this.btnModificarCantidad.Click += new System.EventHandler(this.btnModificarCantidad_Click);
            // 
            // txtModificarCantidad
            // 
            this.txtModificarCantidad.Location = new System.Drawing.Point(249, 263);
            this.txtModificarCantidad.Name = "txtModificarCantidad";
            this.txtModificarCantidad.Size = new System.Drawing.Size(35, 20);
            this.txtModificarCantidad.TabIndex = 15;
            this.txtModificarCantidad.Visible = false;
            this.txtModificarCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModificarCantidad_KeyPress);
            // 
            // lblModificarCantidad
            // 
            this.lblModificarCantidad.AutoSize = true;
            this.lblModificarCantidad.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarCantidad.Location = new System.Drawing.Point(161, 264);
            this.lblModificarCantidad.Name = "lblModificarCantidad";
            this.lblModificarCantidad.Size = new System.Drawing.Size(85, 17);
            this.lblModificarCantidad.TabIndex = 16;
            this.lblModificarCantidad.Text = "Cantidad   x";
            this.lblModificarCantidad.Visible = false;
            // 
            // btnAceptarModificacion
            // 
            this.btnAceptarModificacion.Location = new System.Drawing.Point(290, 262);
            this.btnAceptarModificacion.Name = "btnAceptarModificacion";
            this.btnAceptarModificacion.Size = new System.Drawing.Size(53, 23);
            this.btnAceptarModificacion.TabIndex = 17;
            this.btnAceptarModificacion.Text = "Aceptar";
            this.btnAceptarModificacion.UseVisualStyleBackColor = true;
            this.btnAceptarModificacion.Visible = false;
            this.btnAceptarModificacion.Click += new System.EventHandler(this.btnAceptarModificacion_Click);
            // 
            // AltaVentasItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(668, 647);
            this.Controls.Add(this.btnAceptarModificacion);
            this.Controls.Add(this.lblModificarCantidad);
            this.Controls.Add(this.txtModificarCantidad);
            this.Controls.Add(this.btnModificarCantidad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCancelarCarga);
            this.Controls.Add(this.btnTerminarCarga);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dgvVentaItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AltaVentasItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Venta";
            this.Load += new System.EventHandler(this.AltaVentasItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentaItems;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnTerminarCarga;
        private System.Windows.Forms.Button btnCancelarCarga;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnModificarCantidad;
        private System.Windows.Forms.TextBox txtModificarCantidad;
        private System.Windows.Forms.Label lblModificarCantidad;
        private System.Windows.Forms.Button btnAceptarModificacion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}