namespace GestionHotel
{
    partial class InformeIncidencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeIncidencias));
            this.incidenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.incidenciaTableAdapter = new GestionHotel.HotelDataSetTableAdapters.IncidenciaTableAdapter();
            this.buttonVolverInicio = new System.Windows.Forms.Button();
            this.buttonQuitarFiltro = new System.Windows.Forms.Button();
            this.buttonTipo = new System.Windows.Forms.Button();
            this.buttonEstado = new System.Windows.Forms.Button();
            this.buttonGravedad = new System.Windows.Forms.Button();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxGravedad = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // incidenciaBindingSource
            // 
            this.incidenciaBindingSource.DataMember = "Incidencia";
            this.incidenciaBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetIncidencias";
            reportDataSource1.Value = this.incidenciaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionHotel.InformeIncidencias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1093, 762);
            this.reportViewer1.TabIndex = 0;
            // 
            // incidenciaTableAdapter
            // 
            this.incidenciaTableAdapter.ClearBeforeFill = true;
            // 
            // buttonVolverInicio
            // 
            this.buttonVolverInicio.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolverInicio.FlatAppearance.BorderSize = 0;
            this.buttonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverInicio.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolverInicio.Image")));
            this.buttonVolverInicio.Location = new System.Drawing.Point(1374, 48);
            this.buttonVolverInicio.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolverInicio.Name = "buttonVolverInicio";
            this.buttonVolverInicio.Size = new System.Drawing.Size(88, 68);
            this.buttonVolverInicio.TabIndex = 19;
            this.toolTip1.SetToolTip(this.buttonVolverInicio, "Volver a la ventana crear incidencias");
            this.buttonVolverInicio.UseVisualStyleBackColor = false;
            this.buttonVolverInicio.Click += new System.EventHandler(this.buttonVolverInicio_Click);
            // 
            // buttonQuitarFiltro
            // 
            this.buttonQuitarFiltro.Location = new System.Drawing.Point(1269, 458);
            this.buttonQuitarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuitarFiltro.Name = "buttonQuitarFiltro";
            this.buttonQuitarFiltro.Size = new System.Drawing.Size(100, 28);
            this.buttonQuitarFiltro.TabIndex = 18;
            this.buttonQuitarFiltro.Text = "Quitar filtros";
            this.toolTip1.SetToolTip(this.buttonQuitarFiltro, "Quitar filtros");
            this.buttonQuitarFiltro.UseVisualStyleBackColor = true;
            this.buttonQuitarFiltro.Click += new System.EventHandler(this.buttonQuitarFiltro_Click);
            // 
            // buttonTipo
            // 
            this.buttonTipo.Location = new System.Drawing.Point(1319, 196);
            this.buttonTipo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTipo.Name = "buttonTipo";
            this.buttonTipo.Size = new System.Drawing.Size(143, 28);
            this.buttonTipo.TabIndex = 17;
            this.buttonTipo.Text = "Filtrar por tipo";
            this.toolTip1.SetToolTip(this.buttonTipo, "Filtrar según el tipo de incidencia");
            this.buttonTipo.UseVisualStyleBackColor = true;
            this.buttonTipo.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // buttonEstado
            // 
            this.buttonEstado.Location = new System.Drawing.Point(1319, 279);
            this.buttonEstado.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEstado.Name = "buttonEstado";
            this.buttonEstado.Size = new System.Drawing.Size(143, 28);
            this.buttonEstado.TabIndex = 21;
            this.buttonEstado.Text = "Filtrar por estado";
            this.toolTip1.SetToolTip(this.buttonEstado, "Filtrar según el estado de la incidencia");
            this.buttonEstado.UseVisualStyleBackColor = true;
            this.buttonEstado.Click += new System.EventHandler(this.buttonEstado_Click);
            // 
            // buttonGravedad
            // 
            this.buttonGravedad.Location = new System.Drawing.Point(1319, 364);
            this.buttonGravedad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGravedad.Name = "buttonGravedad";
            this.buttonGravedad.Size = new System.Drawing.Size(143, 28);
            this.buttonGravedad.TabIndex = 23;
            this.buttonGravedad.Text = "Filtrar por gravedad";
            this.toolTip1.SetToolTip(this.buttonGravedad, "Filtar según la gravedad de los daños ocasionados");
            this.buttonGravedad.UseVisualStyleBackColor = true;
            this.buttonGravedad.Click += new System.EventHandler(this.buttonGravedad_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Incendio",
            "Fuga de agua",
            "Avería eléctrica",
            "Robo"});
            this.comboBoxTipo.Location = new System.Drawing.Point(1154, 196);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(132, 24);
            this.comboBoxTipo.TabIndex = 24;
            this.toolTip1.SetToolTip(this.comboBoxTipo, "Seleccione una opción en el desplegable");
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Recibida",
            "Trabajando",
            "Resuelta"});
            this.comboBoxEstado.Location = new System.Drawing.Point(1154, 279);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(132, 24);
            this.comboBoxEstado.TabIndex = 25;
            this.toolTip1.SetToolTip(this.comboBoxEstado, "Seleccione una opción en el desplegable");
            // 
            // comboBoxGravedad
            // 
            this.comboBoxGravedad.FormattingEnabled = true;
            this.comboBoxGravedad.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta",
            "Muy alta"});
            this.comboBoxGravedad.Location = new System.Drawing.Point(1154, 364);
            this.comboBoxGravedad.Name = "comboBoxGravedad";
            this.comboBoxGravedad.Size = new System.Drawing.Size(132, 24);
            this.comboBoxGravedad.TabIndex = 26;
            this.toolTip1.SetToolTip(this.comboBoxGravedad, "Seleccione una opción en el desplegable");
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\AyudaHotel.chm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1269, 555);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // InformeIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1490, 765);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxGravedad);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.buttonGravedad);
            this.Controls.Add(this.buttonEstado);
            this.Controls.Add(this.buttonVolverInicio);
            this.Controls.Add(this.buttonQuitarFiltro);
            this.Controls.Add(this.buttonTipo);
            this.Controls.Add(this.reportViewer1);
            this.helpProvider1.SetHelpKeyword(this, "13");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InformeIncidencias";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Informe Incidencias";
            this.Load += new System.EventHandler(this.InformeIncidencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource incidenciaBindingSource;
        private HotelDataSetTableAdapters.IncidenciaTableAdapter incidenciaTableAdapter;
        private System.Windows.Forms.Button buttonVolverInicio;
        private System.Windows.Forms.Button buttonQuitarFiltro;
        private System.Windows.Forms.Button buttonTipo;
        private System.Windows.Forms.Button buttonEstado;
        private System.Windows.Forms.Button buttonGravedad;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxGravedad;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}