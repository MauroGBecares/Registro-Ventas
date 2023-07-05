namespace Interfaz
{
    partial class ListaClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtFiltroCliente = new System.Windows.Forms.TextBox();
            this.cboCriterioCliente = new System.Windows.Forms.ComboBox();
            this.cboCampoCliente = new System.Windows.Forms.ComboBox();
            this.lblCriterioFiltroCliente = new System.Windows.Forms.Label();
            this.lblCampoFiltroCliente = new System.Windows.Forms.Label();
            this.lblFiltroCliente = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.Location = new System.Drawing.Point(12, 32);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(342, 403);
            this.dgvClientes.TabIndex = 0;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(360, 56);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(204, 23);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(360, 85);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(204, 23);
            this.btnModificarCliente.TabIndex = 1;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(360, 114);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(204, 23);
            this.btnEliminarCliente.TabIndex = 2;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(447, 381);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtFiltroCliente
            // 
            this.txtFiltroCliente.Location = new System.Drawing.Point(416, 355);
            this.txtFiltroCliente.Name = "txtFiltroCliente";
            this.txtFiltroCliente.Size = new System.Drawing.Size(148, 20);
            this.txtFiltroCliente.TabIndex = 5;
            // 
            // cboCriterioCliente
            // 
            this.cboCriterioCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterioCliente.FormattingEnabled = true;
            this.cboCriterioCliente.Location = new System.Drawing.Point(416, 328);
            this.cboCriterioCliente.Name = "cboCriterioCliente";
            this.cboCriterioCliente.Size = new System.Drawing.Size(148, 21);
            this.cboCriterioCliente.TabIndex = 4;
            // 
            // cboCampoCliente
            // 
            this.cboCampoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampoCliente.FormattingEnabled = true;
            this.cboCampoCliente.Location = new System.Drawing.Point(417, 302);
            this.cboCampoCliente.Name = "cboCampoCliente";
            this.cboCampoCliente.Size = new System.Drawing.Size(147, 21);
            this.cboCampoCliente.TabIndex = 3;
            this.cboCampoCliente.SelectedIndexChanged += new System.EventHandler(this.cboCampoCliente_SelectedIndexChanged);
            // 
            // lblCriterioFiltroCliente
            // 
            this.lblCriterioFiltroCliente.AutoSize = true;
            this.lblCriterioFiltroCliente.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioFiltroCliente.Location = new System.Drawing.Point(360, 329);
            this.lblCriterioFiltroCliente.Name = "lblCriterioFiltroCliente";
            this.lblCriterioFiltroCliente.Size = new System.Drawing.Size(57, 16);
            this.lblCriterioFiltroCliente.TabIndex = 13;
            this.lblCriterioFiltroCliente.Text = "Criterio:";
            // 
            // lblCampoFiltroCliente
            // 
            this.lblCampoFiltroCliente.AutoSize = true;
            this.lblCampoFiltroCliente.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoFiltroCliente.Location = new System.Drawing.Point(360, 303);
            this.lblCampoFiltroCliente.Name = "lblCampoFiltroCliente";
            this.lblCampoFiltroCliente.Size = new System.Drawing.Size(56, 16);
            this.lblCampoFiltroCliente.TabIndex = 12;
            this.lblCampoFiltroCliente.Text = "Campo:";
            // 
            // lblFiltroCliente
            // 
            this.lblFiltroCliente.AutoSize = true;
            this.lblFiltroCliente.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblFiltroCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroCliente.Location = new System.Drawing.Point(443, 273);
            this.lblFiltroCliente.Name = "lblFiltroCliente";
            this.lblFiltroCliente.Size = new System.Drawing.Size(51, 18);
            this.lblFiltroCliente.TabIndex = 11;
            this.lblFiltroCliente.Text = "Filtros";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 449);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(592, 484);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtFiltroCliente);
            this.Controls.Add(this.cboCriterioCliente);
            this.Controls.Add(this.cboCampoCliente);
            this.Controls.Add(this.lblCriterioFiltroCliente);
            this.Controls.Add(this.lblCampoFiltroCliente);
            this.Controls.Add(this.lblFiltroCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Clientes";
            this.Load += new System.EventHandler(this.ListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtFiltroCliente;
        private System.Windows.Forms.ComboBox cboCriterioCliente;
        private System.Windows.Forms.ComboBox cboCampoCliente;
        private System.Windows.Forms.Label lblCriterioFiltroCliente;
        private System.Windows.Forms.Label lblCampoFiltroCliente;
        private System.Windows.Forms.Label lblFiltroCliente;
        private System.Windows.Forms.Button btnSalir;
    }
}