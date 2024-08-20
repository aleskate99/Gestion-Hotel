namespace GestionHotel
{
    partial class InformeServicios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeServicios));
            this.serviciosExtraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonFiltrarId = new System.Windows.Forms.Button();
            this.textBoxFiltrarId = new System.Windows.Forms.TextBox();
            this.buttonQuitarFiltro = new System.Windows.Forms.Button();
            this.buttonFiltrarTraslado = new System.Windows.Forms.Button();
            this.buttonVolverInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxTrasladoAeropuerto = new System.Windows.Forms.ComboBox();
            this.serviciosExtraTableAdapter = new GestionHotel.HotelDataSetTableAdapters.ServiciosExtraTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosExtraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serviciosExtraBindingSource
            // 
            this.serviciosExtraBindingSource.DataMember = "ServiciosExtra";
            this.serviciosExtraBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.serviciosExtraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionHotel.InformeServicios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1116, 774);
            this.reportViewer1.TabIndex = 0;
            // 
            // buttonFiltrarId
            // 
            this.buttonFiltrarId.Location = new System.Drawing.Point(1286, 263);
            this.buttonFiltrarId.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrarId.Name = "buttonFiltrarId";
            this.buttonFiltrarId.Size = new System.Drawing.Size(179, 28);
            this.buttonFiltrarId.TabIndex = 33;
            this.buttonFiltrarId.Text = "Filtrar por id Servicios";
            this.toolTip1.SetToolTip(this.buttonFiltrarId, "Filtra según el número de Id");
            this.buttonFiltrarId.UseVisualStyleBackColor = true;
            this.buttonFiltrarId.Click += new System.EventHandler(this.buttonFiltrarId_Click);
            // 
            // textBoxFiltrarId
            // 
            this.textBoxFiltrarId.Location = new System.Drawing.Point(1121, 266);
            this.textBoxFiltrarId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiltrarId.Name = "textBoxFiltrarId";
            this.textBoxFiltrarId.Size = new System.Drawing.Size(141, 22);
            this.textBoxFiltrarId.TabIndex = 32;
            this.toolTip1.SetToolTip(this.textBoxFiltrarId, "Introduzca el Id");
            // 
            // buttonQuitarFiltro
            // 
            this.buttonQuitarFiltro.Location = new System.Drawing.Point(1233, 433);
            this.buttonQuitarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuitarFiltro.Name = "buttonQuitarFiltro";
            this.buttonQuitarFiltro.Size = new System.Drawing.Size(100, 28);
            this.buttonQuitarFiltro.TabIndex = 31;
            this.buttonQuitarFiltro.Text = "Quitar filtros";
            this.toolTip1.SetToolTip(this.buttonQuitarFiltro, "Quitar los filtros");
            this.buttonQuitarFiltro.UseVisualStyleBackColor = true;
            this.buttonQuitarFiltro.Click += new System.EventHandler(this.buttonQuitarFiltro_Click);
            // 
            // buttonFiltrarTraslado
            // 
            this.buttonFiltrarTraslado.Location = new System.Drawing.Point(1286, 338);
            this.buttonFiltrarTraslado.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrarTraslado.Name = "buttonFiltrarTraslado";
            this.buttonFiltrarTraslado.Size = new System.Drawing.Size(179, 69);
            this.buttonFiltrarTraslado.TabIndex = 30;
            this.buttonFiltrarTraslado.Text = "Filtrar por traslado al aeropuerto";
            this.toolTip1.SetToolTip(this.buttonFiltrarTraslado, "Filtra según si desea traslado a la ida, a la vuelta o ambas.");
            this.buttonFiltrarTraslado.UseVisualStyleBackColor = true;
            this.buttonFiltrarTraslado.Click += new System.EventHandler(this.buttonFiltrarTraslado_Click);
            // 
            // buttonVolverInicio
            // 
            this.buttonVolverInicio.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolverInicio.FlatAppearance.BorderSize = 0;
            this.buttonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverInicio.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolverInicio.Image")));
            this.buttonVolverInicio.Location = new System.Drawing.Point(1378, 57);
            this.buttonVolverInicio.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolverInicio.Name = "buttonVolverInicio";
            this.buttonVolverInicio.Size = new System.Drawing.Size(88, 68);
            this.buttonVolverInicio.TabIndex = 27;
            this.toolTip1.SetToolTip(this.buttonVolverInicio, "Volver a la ventana de servicios extra");
            this.buttonVolverInicio.UseVisualStyleBackColor = false;
            this.buttonVolverInicio.Click += new System.EventHandler(this.buttonVolverInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1233, 540);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxTrasladoAeropuerto
            // 
            this.comboBoxTrasladoAeropuerto.FormattingEnabled = true;
            this.comboBoxTrasladoAeropuerto.Items.AddRange(new object[] {
            "Ida",
            "Vuelta",
            "Ida y vuelta"});
            this.comboBoxTrasladoAeropuerto.Location = new System.Drawing.Point(1121, 361);
            this.comboBoxTrasladoAeropuerto.Name = "comboBoxTrasladoAeropuerto";
            this.comboBoxTrasladoAeropuerto.Size = new System.Drawing.Size(141, 24);
            this.comboBoxTrasladoAeropuerto.TabIndex = 35;
            this.toolTip1.SetToolTip(this.comboBoxTrasladoAeropuerto, "Seleccione una opción del desplegable");
            // 
            // serviciosExtraTableAdapter
            // 
            this.serviciosExtraTableAdapter.ClearBeforeFill = true;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\AyudaHotel.chm";
            // 
            // InformeServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1479, 775);
            this.Controls.Add(this.comboBoxTrasladoAeropuerto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonFiltrarId);
            this.Controls.Add(this.textBoxFiltrarId);
            this.Controls.Add(this.buttonQuitarFiltro);
            this.Controls.Add(this.buttonFiltrarTraslado);
            this.Controls.Add(this.buttonVolverInicio);
            this.Controls.Add(this.reportViewer1);
            this.helpProvider1.SetHelpKeyword(this, "22");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InformeServicios";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Informe Servicios";
            this.Load += new System.EventHandler(this.InformeServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviciosExtraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button buttonFiltrarId;
        private System.Windows.Forms.TextBox textBoxFiltrarId;
        private System.Windows.Forms.Button buttonQuitarFiltro;
        private System.Windows.Forms.Button buttonFiltrarTraslado;
        private System.Windows.Forms.Button buttonVolverInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxTrasladoAeropuerto;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource serviciosExtraBindingSource;
        private HotelDataSetTableAdapters.ServiciosExtraTableAdapter serviciosExtraTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}