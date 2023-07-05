namespace Interfaz
{
    partial class ListaProductos
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCampoFiltro = new System.Windows.Forms.Label();
            this.lblCriterioFiltro = new System.Windows.Forms.Label();
            this.cboCampoProducto = new System.Windows.Forms.ComboBox();
            this.cboCriterioProducto = new System.Windows.Forms.ComboBox();
            this.txtFiltroProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.Location = new System.Drawing.Point(12, 12);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(344, 451);
            this.dgvProductos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(362, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(228, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(362, 89);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(228, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(362, 118);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(228, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Peru;
            this.lblFiltro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(446, 278);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(51, 18);
            this.lblFiltro.TabIndex = 4;
            this.lblFiltro.Text = "Filtros";
            // 
            // lblCampoFiltro
            // 
            this.lblCampoFiltro.AutoSize = true;
            this.lblCampoFiltro.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoFiltro.Location = new System.Drawing.Point(359, 311);
            this.lblCampoFiltro.Name = "lblCampoFiltro";
            this.lblCampoFiltro.Size = new System.Drawing.Size(56, 16);
            this.lblCampoFiltro.TabIndex = 5;
            this.lblCampoFiltro.Text = "Campo:";
            // 
            // lblCriterioFiltro
            // 
            this.lblCriterioFiltro.AutoSize = true;
            this.lblCriterioFiltro.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioFiltro.Location = new System.Drawing.Point(359, 337);
            this.lblCriterioFiltro.Name = "lblCriterioFiltro";
            this.lblCriterioFiltro.Size = new System.Drawing.Size(57, 16);
            this.lblCriterioFiltro.TabIndex = 6;
            this.lblCriterioFiltro.Text = "Criterio:";
            // 
            // cboCampoProducto
            // 
            this.cboCampoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampoProducto.FormattingEnabled = true;
            this.cboCampoProducto.Location = new System.Drawing.Point(420, 307);
            this.cboCampoProducto.Name = "cboCampoProducto";
            this.cboCampoProducto.Size = new System.Drawing.Size(147, 21);
            this.cboCampoProducto.TabIndex = 3;
            this.cboCampoProducto.SelectedIndexChanged += new System.EventHandler(this.cboCampoProducto_SelectedIndexChanged);
            // 
            // cboCriterioProducto
            // 
            this.cboCriterioProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterioProducto.FormattingEnabled = true;
            this.cboCriterioProducto.Location = new System.Drawing.Point(419, 333);
            this.cboCriterioProducto.Name = "cboCriterioProducto";
            this.cboCriterioProducto.Size = new System.Drawing.Size(148, 21);
            this.cboCriterioProducto.TabIndex = 4;
            // 
            // txtFiltroProducto
            // 
            this.txtFiltroProducto.Location = new System.Drawing.Point(419, 360);
            this.txtFiltroProducto.Name = "txtFiltroProducto";
            this.txtFiltroProducto.Size = new System.Drawing.Size(148, 20);
            this.txtFiltroProducto.TabIndex = 5;
            this.txtFiltroProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroProducto_KeyPress);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(450, 386);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 6;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 469);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(602, 501);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtFiltroProducto);
            this.Controls.Add(this.cboCriterioProducto);
            this.Controls.Add(this.cboCampoProducto);
            this.Controls.Add(this.lblCriterioFiltro);
            this.Controls.Add(this.lblCampoFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCampoFiltro;
        private System.Windows.Forms.Label lblCriterioFiltro;
        private System.Windows.Forms.ComboBox cboCampoProducto;
        private System.Windows.Forms.ComboBox cboCriterioProducto;
        private System.Windows.Forms.TextBox txtFiltroProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnSalir;
    }
}