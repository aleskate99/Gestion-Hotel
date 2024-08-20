namespace GestionHotel
{
    partial class InformeClientes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeClientes));
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.clienteTableAdapter = new GestionHotel.HotelDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new GestionHotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonQuitarFiltro = new System.Windows.Forms.Button();
            this.buttonFiltrarNombre = new System.Windows.Forms.Button();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.buttonVolverInicio = new System.Windows.Forms.Button();
            this.buttonFiltrarTelefono = new System.Windows.Forms.Button();
            this.textBoxFiltrarTelefono = new System.Windows.Forms.TextBox();
            this.buttonFiltrarSexo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.DetalleParteTableAdapter = null;
            this.tableAdapterManager.DetalleReservaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.HabitacionTableAdapter = null;
            this.tableAdapterManager.IncidenciaTableAdapter = null;
            this.tableAdapterManager.ParteReparacionTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.ServiciosExtraTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionHotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionHotel.InformeClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1159, 768);
            this.reportViewer1.TabIndex = 0;
            // 
            // buttonQuitarFiltro
            // 
            this.buttonQuitarFiltro.Location = new System.Drawing.Point(1273, 494);
            this.buttonQuitarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuitarFiltro.Name = "buttonQuitarFiltro";
            this.buttonQuitarFiltro.Size = new System.Drawing.Size(100, 28);
            this.buttonQuitarFiltro.TabIndex = 6;
            this.buttonQuitarFiltro.Text = "Quitar filtros";
            this.toolTip1.SetToolTip(this.buttonQuitarFiltro, "Quitar filtro");
            this.buttonQuitarFiltro.UseVisualStyleBackColor = true;
            this.buttonQuitarFiltro.Click += new System.EventHandler(this.buttonQuitarFiltro_Click);
            // 
            // buttonFiltrarNombre
            // 
            this.buttonFiltrarNombre.Location = new System.Drawing.Point(1331, 195);
            this.buttonFiltrarNombre.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrarNombre.Name = "buttonFiltrarNombre";
            this.buttonFiltrarNombre.Size = new System.Drawing.Size(143, 28);
            this.buttonFiltrarNombre.TabIndex = 5;
            this.buttonFiltrarNombre.Text = "Filtrar por nombre";
            this.toolTip1.SetToolTip(this.buttonFiltrarNombre, "Filtra según el nombre del cliente");
            this.buttonFiltrarNombre.UseVisualStyleBackColor = true;
            this.buttonFiltrarNombre.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.Location = new System.Drawing.Point(1166, 198);
            this.textBoxFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(132, 22);
            this.textBoxFiltrar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxFiltrar, "Introduce el nombre del cliente");
            // 
            // buttonVolverInicio
            // 
            this.buttonVolverInicio.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolverInicio.FlatAppearance.BorderSize = 0;
            this.buttonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverInicio.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolverInicio.Image")));
            this.buttonVolverInicio.Location = new System.Drawing.Point(1386, 36);
            this.buttonVolverInicio.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolverInicio.Name = "buttonVolverInicio";
            this.buttonVolverInicio.Size = new System.Drawing.Size(88, 68);
            this.buttonVolverInicio.TabIndex = 15;
            this.toolTip1.SetToolTip(this.buttonVolverInicio, "Volver a la ventana de clientes");
            this.buttonVolverInicio.UseVisualStyleBackColor = false;
            this.buttonVolverInicio.Click += new System.EventHandler(this.buttonVolverInicio_Click);
            // 
            // buttonFiltrarTelefono
            // 
            this.buttonFiltrarTelefono.Location = new System.Drawing.Point(1331, 293);
            this.buttonFiltrarTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrarTelefono.Name = "buttonFiltrarTelefono";
            this.buttonFiltrarTelefono.Size = new System.Drawing.Size(143, 28);
            this.buttonFiltrarTelefono.TabIndex = 17;
            this.buttonFiltrarTelefono.Text = "Filtrar por teléfono";
            this.toolTip1.SetToolTip(this.buttonFiltrarTelefono, "Filtra por número de teléfono");
            this.buttonFiltrarTelefono.UseVisualStyleBackColor = true;
            this.buttonFiltrarTelefono.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFiltrarTelefono
            // 
            this.textBoxFiltrarTelefono.Location = new System.Drawing.Point(1166, 296);
            this.textBoxFiltrarTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiltrarTelefono.Name = "textBoxFiltrarTelefono";
            this.textBoxFiltrarTelefono.Size = new System.Drawing.Size(132, 22);
            this.textBoxFiltrarTelefono.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBoxFiltrarTelefono, "Introduce el número de teléfono del cliente");
            // 
            // buttonFiltrarSexo
            // 
            this.buttonFiltrarSexo.Location = new System.Drawing.Point(1331, 392);
            this.buttonFiltrarSexo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrarSexo.Name = "buttonFiltrarSexo";
            this.buttonFiltrarSexo.Size = new System.Drawing.Size(143, 28);
            this.buttonFiltrarSexo.TabIndex = 19;
            this.buttonFiltrarSexo.Text = "Filtrar por sexo";
            this.toolTip1.SetToolTip(this.buttonFiltrarSexo, "Filtra en función del sexo del cliente");
            this.buttonFiltrarSexo.UseVisualStyleBackColor = true;
            this.buttonFiltrarSexo.Click += new System.EventHandler(this.buttonFiltrarSexo_Click);
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBoxSexo.Location = new System.Drawing.Point(1165, 392);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(132, 24);
            this.comboBoxSexo.TabIndex = 20;
            this.toolTip1.SetToolTip(this.comboBoxSexo, "Seleccione una opción del desplegable");
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\AyudaHotel.chm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1273, 608);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // InformeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1487, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.buttonFiltrarSexo);
            this.Controls.Add(this.buttonFiltrarTelefono);
            this.Controls.Add(this.textBoxFiltrarTelefono);
            this.Controls.Add(this.buttonVolverInicio);
            this.Controls.Add(this.buttonQuitarFiltro);
            this.Controls.Add(this.buttonFiltrarNombre);
            this.Controls.Add(this.textBoxFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.helpProvider1.SetHelpKeyword(this, "9");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "InformeClientes";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Informe Cliente";
            this.Load += new System.EventHandler(this.InformeCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private HotelDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button buttonQuitarFiltro;
        private System.Windows.Forms.Button buttonFiltrarNombre;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.Button buttonVolverInicio;
        private System.Windows.Forms.Button buttonFiltrarTelefono;
        private System.Windows.Forms.TextBox textBoxFiltrarTelefono;
        private System.Windows.Forms.Button buttonFiltrarSexo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}