namespace WindowsFormsApp8
{
    partial class frmPasajeros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvPasajeros = new System.Windows.Forms.DataGridView();
            this.bD_LATAMDataSet = new WindowsFormsApp8.BD_LATAMDataSet();
            this.bDLATAMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LATAMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLATAMDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPasajeros
            // 
            this.dgvPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajeros.Location = new System.Drawing.Point(42, 64);
            this.dgvPasajeros.Name = "dgvPasajeros";
            this.dgvPasajeros.Size = new System.Drawing.Size(603, 200);
            this.dgvPasajeros.TabIndex = 0;
            this.dgvPasajeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasajeros_CellContentClick);
            // 
            // bD_LATAMDataSet
            // 
            this.bD_LATAMDataSet.DataSetName = "BD_LATAMDataSet";
            this.bD_LATAMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDLATAMDataSetBindingSource
            // 
            this.bDLATAMDataSetBindingSource.DataSource = this.bD_LATAMDataSet;
            this.bDLATAMDataSetBindingSource.Position = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(247, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // frmPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 311);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvPasajeros);
            this.Name = "frmPasajeros";
            this.Text = "Pasajeros";
            this.Load += new System.EventHandler(this.frmPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LATAMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLATAMDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasajeros;
        private System.Windows.Forms.BindingSource bDLATAMDataSetBindingSource;
        private BD_LATAMDataSet bD_LATAMDataSet;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

