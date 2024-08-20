namespace GestionHotel
{
    partial class InformeEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeEmpleados));
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.empleadoTableAdapter = new GestionHotel.HotelDataSetTableAdapters.EmpleadoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFiltrarDNI = new System.Windows.Forms.TextBox();
            this.buttonQuitarFiltro = new System.Windows.Forms.Button();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.buttonVolverInicio = new System.Windows.Forms.Button();
            this.buttonTiempoEnLaEmpresa = new System.Windows.Forms.Button();
            this.comboBoxTiempoEnLaEmpresa = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetEmpleados";
            reportDataSource1.Value = this.empleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionHotel.InformeEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1143, 779);
            this.reportViewer1.TabIndex = 0;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1329, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Filtrar por DNI";
            this.toolTip1.SetToolTip(this.button1, "Filtrar por el dni del empleado");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFiltrarDNI
            // 
            this.textBoxFiltrarDNI.Location = new System.Drawing.Point(1164, 271);
            this.textBoxFiltrarDNI.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiltrarDNI.Name = "textBoxFiltrarDNI";
            this.textBoxFiltrarDNI.Size = new System.Drawing.Size(132, 22);
            this.textBoxFiltrarDNI.TabIndex = 21;
            this.toolTip1.SetToolTip(this.textBoxFiltrarDNI, "Introduzca el dni del empleado");
            // 
            // buttonQuitarFiltro
            // 
            this.buttonQuitarFiltro.Location = new System.Drawing.Point(1273, 486);
            this.buttonQuitarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuitarFiltro.Name = "buttonQuitarFiltro";
            this.buttonQuitarFiltro.Size = new System.Drawing.Size(100, 28);
            this.buttonQuitarFiltro.TabIndex = 20;
            this.buttonQuitarFiltro.Text = "Quitar filtros";
            this.toolTip1.SetToolTip(this.buttonQuitarFiltro, "Quitar los filtros");
            this.buttonQuitarFiltro.UseVisualStyleBackColor = true;
            this.buttonQuitarFiltro.Click += new System.EventHandler(this.buttonQuitarFiltro_Click);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(1329, 170);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(143, 28);
            this.buttonFiltrar.TabIndex = 19;
            this.buttonFiltrar.Text = "Filtrar por nombre";
            this.toolTip1.SetToolTip(this.buttonFiltrar, "Filtrar según el nombre del empleado");
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.Location = new System.Drawing.Point(1164, 174);
            this.textBoxFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(132, 22);
            this.textBoxFiltrar.TabIndex = 18;
            this.toolTip1.SetToolTip(this.textBoxFiltrar, "Introduzca el nombre del empleado");
            // 
            // buttonVolverInicio
            // 
            this.buttonVolverInicio.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolverInicio.FlatAppearance.BorderSize = 0;
            this.buttonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverInicio.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolverInicio.Image")));
            this.buttonVolverInicio.Location = new System.Drawing.Point(1384, 25);
            this.buttonVolverInicio.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolverInicio.Name = "buttonVolverInicio";
            this.buttonVolverInicio.Size = new System.Drawing.Size(88, 68);
            this.buttonVolverInicio.TabIndex = 23;
            this.toolTip1.SetToolTip(this.buttonVolverInicio, "Volver a la ventana de empleados");
            this.buttonVolverInicio.UseVisualStyleBackColor = false;
            this.buttonVolverInicio.Click += new System.EventHandler(this.buttonVolverInicio_Click);
            // 
            // buttonTiempoEnLaEmpresa
            // 
            this.buttonTiempoEnLaEmpresa.Location = new System.Drawing.Point(1329, 361);
            this.buttonTiempoEnLaEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTiempoEnLaEmpresa.Name = "buttonTiempoEnLaEmpresa";
            this.buttonTiempoEnLaEmpresa.Size = new System.Drawing.Size(143, 48);
            this.buttonTiempoEnLaEmpresa.TabIndex = 25;
            this.buttonTiempoEnLaEmpresa.Text = "Filtrar por tiempo en la empresa";
            this.toolTip1.SetToolTip(this.buttonTiempoEnLaEmpresa, "Filtrar por el tiempo que lleva trabajando el empleado en la empresa");
            this.buttonTiempoEnLaEmpresa.UseVisualStyleBackColor = true;
            this.buttonTiempoEnLaEmpresa.Click += new System.EventHandler(this.buttonTiempoEnLaEmpresa_Click);
            // 
            // comboBoxTiempoEnLaEmpresa
            // 
            this.comboBoxTiempoEnLaEmpresa.FormattingEnabled = true;
            this.comboBoxTiempoEnLaEmpresa.Items.AddRange(new object[] {
            "<3",
            "3",
            "5",
            ">5"});
            this.comboBoxTiempoEnLaEmpresa.Location = new System.Drawing.Point(1164, 370);
            this.comboBoxTiempoEnLaEmpresa.Name = "comboBoxTiempoEnLaEmpresa";
            this.comboBoxTiempoEnLaEmpresa.Size = new System.Drawing.Size(132, 24);
            this.comboBoxTiempoEnLaEmpresa.TabIndex = 26;
            this.toolTip1.SetToolTip(this.comboBoxTiempoEnLaEmpresa, "Seleccione una opción del desplegable");
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\AyudaHotel.chm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1273, 590);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // InformeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1483, 780);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxTiempoEnLaEmpresa);
            this.Controls.Add(this.buttonTiempoEnLaEmpresa);
            this.Controls.Add(this.buttonVolverInicio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFiltrarDNI);
            this.Controls.Add(this.buttonQuitarFiltro);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.textBoxFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.helpProvider1.SetHelpKeyword(this, "10");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "InformeEmpleados";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Informe Empleados";
            this.Load += new System.EventHandler(this.InformeEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private HotelDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFiltrarDNI;
        private System.Windows.Forms.Button buttonQuitarFiltro;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.Button buttonVolverInicio;
        private System.Windows.Forms.Button buttonTiempoEnLaEmpresa;
        private System.Windows.Forms.ComboBox comboBoxTiempoEnLaEmpresa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}