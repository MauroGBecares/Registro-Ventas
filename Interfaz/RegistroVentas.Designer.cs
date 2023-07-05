namespace Interfaz
{
    partial class RegistroVentas
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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.btnBorrarVenta = new System.Windows.Forms.Button();
            this.btnModificarVenta = new System.Windows.Forms.Button();
            this.btnBuscarVentas = new System.Windows.Forms.Button();
            this.txtFiltroVentas = new System.Windows.Forms.TextBox();
            this.cboCriterioVentas = new System.Windows.Forms.ComboBox();
            this.cboCampoVentas = new System.Windows.Forms.ComboBox();
            this.lblCriterioFiltroVentas = new System.Windows.Forms.Label();
            this.lblCampoFiltroVentas = new System.Windows.Forms.Label();
            this.lblFiltroVentas = new System.Windows.Forms.Label();
            this.dtpFiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFiltroPorCodigo = new System.Windows.Forms.Label();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.btnVisualizarVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVentas.Location = new System.Drawing.Point(12, 49);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(618, 499);
            this.dgvVentas.TabIndex = 0;
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(636, 73);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(282, 23);
            this.btnAgregarVenta.TabIndex = 0;
            this.btnAgregarVenta.Text = "Agregar Venta";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // btnBorrarVenta
            // 
            this.btnBorrarVenta.Location = new System.Drawing.Point(636, 131);
            this.btnBorrarVenta.Name = "btnBorrarVenta";
            this.btnBorrarVenta.Size = new System.Drawing.Size(282, 23);
            this.btnBorrarVenta.TabIndex = 2;
            this.btnBorrarVenta.Text = "Borrar Venta";
            this.btnBorrarVenta.UseVisualStyleBackColor = true;
            this.btnBorrarVenta.Click += new System.EventHandler(this.btnBorrarVenta_Click);
            // 
            // btnModificarVenta
            // 
            this.btnModificarVenta.Location = new System.Drawing.Point(636, 102);
            this.btnModificarVenta.Name = "btnModificarVenta";
            this.btnModificarVenta.Size = new System.Drawing.Size(282, 23);
            this.btnModificarVenta.TabIndex = 1;
            this.btnModificarVenta.Text = "Modificar Venta";
            this.btnModificarVenta.UseVisualStyleBackColor = true;
            this.btnModificarVenta.Click += new System.EventHandler(this.btnModificarVenta_Click);
            // 
            // btnBuscarVentas
            // 
            this.btnBuscarVentas.Location = new System.Drawing.Point(742, 407);
            this.btnBuscarVentas.Name = "btnBuscarVentas";
            this.btnBuscarVentas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarVentas.TabIndex = 8;
            this.btnBuscarVentas.Text = "Buscar";
            this.btnBuscarVentas.UseVisualStyleBackColor = true;
            this.btnBuscarVentas.Click += new System.EventHandler(this.btnBuscarVentas_Click);
            // 
            // txtFiltroVentas
            // 
            this.txtFiltroVentas.Location = new System.Drawing.Point(711, 381);
            this.txtFiltroVentas.Name = "txtFiltroVentas";
            this.txtFiltroVentas.Size = new System.Drawing.Size(148, 20);
            this.txtFiltroVentas.TabIndex = 7;
            this.txtFiltroVentas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroVentas_KeyPress);
            // 
            // cboCriterioVentas
            // 
            this.cboCriterioVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterioVentas.FormattingEnabled = true;
            this.cboCriterioVentas.Location = new System.Drawing.Point(711, 354);
            this.cboCriterioVentas.Name = "cboCriterioVentas";
            this.cboCriterioVentas.Size = new System.Drawing.Size(148, 21);
            this.cboCriterioVentas.TabIndex = 5;
            // 
            // cboCampoVentas
            // 
            this.cboCampoVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampoVentas.FormattingEnabled = true;
            this.cboCampoVentas.Location = new System.Drawing.Point(712, 328);
            this.cboCampoVentas.Name = "cboCampoVentas";
            this.cboCampoVentas.Size = new System.Drawing.Size(147, 21);
            this.cboCampoVentas.TabIndex = 4;
            this.cboCampoVentas.SelectedIndexChanged += new System.EventHandler(this.cboCampoVentas_SelectedIndexChanged);
            // 
            // lblCriterioFiltroVentas
            // 
            this.lblCriterioFiltroVentas.AutoSize = true;
            this.lblCriterioFiltroVentas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioFiltroVentas.Location = new System.Drawing.Point(650, 355);
            this.lblCriterioFiltroVentas.Name = "lblCriterioFiltroVentas";
            this.lblCriterioFiltroVentas.Size = new System.Drawing.Size(57, 16);
            this.lblCriterioFiltroVentas.TabIndex = 20;
            this.lblCriterioFiltroVentas.Text = "Criterio:";
            // 
            // lblCampoFiltroVentas
            // 
            this.lblCampoFiltroVentas.AutoSize = true;
            this.lblCampoFiltroVentas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoFiltroVentas.Location = new System.Drawing.Point(650, 328);
            this.lblCampoFiltroVentas.Name = "lblCampoFiltroVentas";
            this.lblCampoFiltroVentas.Size = new System.Drawing.Size(56, 16);
            this.lblCampoFiltroVentas.TabIndex = 19;
            this.lblCampoFiltroVentas.Text = "Campo:";
            // 
            // lblFiltroVentas
            // 
            this.lblFiltroVentas.AutoSize = true;
            this.lblFiltroVentas.BackColor = System.Drawing.Color.Teal;
            this.lblFiltroVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroVentas.Location = new System.Drawing.Point(738, 299);
            this.lblFiltroVentas.Name = "lblFiltroVentas";
            this.lblFiltroVentas.Size = new System.Drawing.Size(52, 20);
            this.lblFiltroVentas.TabIndex = 18;
            this.lblFiltroVentas.Text = "Filtros";
            // 
            // dtpFiltroFecha
            // 
            this.dtpFiltroFecha.Location = new System.Drawing.Point(687, 364);
            this.dtpFiltroFecha.Name = "dtpFiltroFecha";
            this.dtpFiltroFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFiltroFecha.TabIndex = 6;
            this.dtpFiltroFecha.Visible = false;
            // 
            // lblFiltroPorCodigo
            // 
            this.lblFiltroPorCodigo.AutoSize = true;
            this.lblFiltroPorCodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroPorCodigo.Location = new System.Drawing.Point(12, 22);
            this.lblFiltroPorCodigo.Name = "lblFiltroPorCodigo";
            this.lblFiltroPorCodigo.Size = new System.Drawing.Size(142, 16);
            this.lblFiltroPorCodigo.TabIndex = 26;
            this.lblFiltroPorCodigo.Text = "Buscar por Código:";
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(160, 21);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(56, 20);
            this.txtBuscarCodigo.TabIndex = 9;
            this.txtBuscarCodigo.TextChanged += new System.EventHandler(this.txtBuscarCodigo_TextChanged);
            // 
            // btnVisualizarVenta
            // 
            this.btnVisualizarVenta.Location = new System.Drawing.Point(636, 160);
            this.btnVisualizarVenta.Name = "btnVisualizarVenta";
            this.btnVisualizarVenta.Size = new System.Drawing.Size(282, 23);
            this.btnVisualizarVenta.TabIndex = 3;
            this.btnVisualizarVenta.Text = "Visualizar Venta";
            this.btnVisualizarVenta.UseVisualStyleBackColor = true;
            this.btnVisualizarVenta.Click += new System.EventHandler(this.btnVisualizarVenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 567);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // RegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(930, 602);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVisualizarVenta);
            this.Controls.Add(this.txtBuscarCodigo);
            this.Controls.Add(this.lblFiltroPorCodigo);
            this.Controls.Add(this.dtpFiltroFecha);
            this.Controls.Add(this.btnBuscarVentas);
            this.Controls.Add(this.txtFiltroVentas);
            this.Controls.Add(this.cboCriterioVentas);
            this.Controls.Add(this.cboCampoVentas);
            this.Controls.Add(this.lblCriterioFiltroVentas);
            this.Controls.Add(this.lblCampoFiltroVentas);
            this.Controls.Add(this.lblFiltroVentas);
            this.Controls.Add(this.btnModificarVenta);
            this.Controls.Add(this.btnBorrarVenta);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.dgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistroVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroVentas";
            this.Load += new System.EventHandler(this.RegistroVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnBorrarVenta;
        private System.Windows.Forms.Button btnModificarVenta;
        private System.Windows.Forms.Button btnBuscarVentas;
        private System.Windows.Forms.TextBox txtFiltroVentas;
        private System.Windows.Forms.ComboBox cboCriterioVentas;
        private System.Windows.Forms.ComboBox cboCampoVentas;
        private System.Windows.Forms.Label lblCriterioFiltroVentas;
        private System.Windows.Forms.Label lblCampoFiltroVentas;
        private System.Windows.Forms.Label lblFiltroVentas;
        private System.Windows.Forms.DateTimePicker dtpFiltroFecha;
        private System.Windows.Forms.Label lblFiltroPorCodigo;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Button btnVisualizarVenta;
        private System.Windows.Forms.Button btnSalir;
    }
}