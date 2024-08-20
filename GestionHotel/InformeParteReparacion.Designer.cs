namespace GestionHotel
{
    partial class InformeParteReparacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeParteReparacion));
            this.parteReparacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonVolverInicio = new System.Windows.Forms.Button();
            this.buttonFiltrarPrecio = new System.Windows.Forms.Button();
            this.textBoxFiltrarPrecio = new System.Windows.Forms.TextBox();
            this.buttonQuitarFiltro = new System.Windows.Forms.Button();
            this.buttonFiltrarIdHabitacion = new System.Windows.Forms.Button();
            this.textBoxFiltrarIdHabitacion = new System.Windows.Forms.TextBox();
            this.parteReparacionTableAdapter = new GestionHotel.HotelDataSetTableAdapters.ParteReparacionTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.parteReparacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // parteReparacionBindingSource
            // 
            this.parteReparacionBindingSource.DataMember = "ParteReparacion";
            this.parteReparacionBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.parteReparacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionHotel.InformeParteReparacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1106, 766);
            this.reportViewer1.TabIndex = 0;
            // 
            // buttonVolverInicio
            // 
            this.buttonVolverInicio.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolverInicio.FlatAppearance.BorderSize = 0;
            this.buttonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverInicio.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolverInicio.Image")));
            this.buttonVolverInicio.Location = new System.Drawing.Point(1392, 52);
            this.buttonVolverInicio.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolverInicio.Name = "buttonVolverInicio";
            this.buttonVolverInicio.Size = new System.Drawing.Size(88, 68);
            this.buttonVolverInicio.TabIndex = 21;
            this.toolTip1.SetToolTip(this.buttonVolverInicio, "Volver a la ventana parte de reparación");
            this.buttonVolverInicio.UseVisualStyleBackColor = false;
            this.buttonVolverInicio.Click += new System.EventHandler(this.buttonVolverInicio_Click);
            // 
            // buttonFiltrarPrecio
            // 
            this.buttonFiltrarPrecio.Location = new System.Drawing.Point(1301, 334);
            this.buttonFiltrarPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrarPrecio.Name = "buttonFiltrarPrecio";
            this.buttonFiltrarPrecio.Size = new System.Drawing.Size(179, 28);
            this.buttonFiltrarPrecio.TabIndex = 26;
            this.buttonFiltrarPrecio.Text = "Filtrar por precio total";
            this.toolTip1.SetToolTip(this.buttonFiltrarPrecio, "Filtrar según el coste de la reparación");
            this.buttonFiltrarPrecio.UseVisualStyleBackColor = true;
            this.buttonFiltrarPrecio.Click += new System.EventHandler(this.buttonFiltrarTelefono_Click);
            // 
            // textBoxFiltrarPrecio
            // 
            this.textBoxFiltrarPrecio.Location = new System.Drawing.Point(1136, 337);
            this.textBoxFiltrarPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiltrarPrecio.Name = "textBoxFiltrarPrecio";
            this.textBoxFiltrarPrecio.Size = new System.Drawing.Size(132, 22);
            this.textBoxFiltrarPrecio.TabIndex = 25;
            this.toolTip1.SetToolTip(this.textBoxFiltrarPrecio, "Introduzca el coste de la reparación");
            // 
            // buttonQuitarFiltro
            // 
            this.buttonQuitarFiltro.Location = new System.Drawing.Point(1247, 433);
            this.buttonQuitarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuitarFiltro.Name = "buttonQuitarFiltro";
            this.buttonQuitarFiltro.Size = new System.Drawing.Size(100, 28);
            this.buttonQuitarFiltro.TabIndex = 24;
            this.buttonQuitarFiltro.Text = "Quitar filtros";
            this.toolTip1.SetToolTip(this.buttonQuitarFiltro, "Quitar filtros");
            this.buttonQuitarFiltro.UseVisualStyleBackColor = true;
            this.buttonQuitarFiltro.Click += new System.EventHandler(this.buttonQuitarFiltro_Click);
            // 
            // buttonFiltrarIdHabitacion
            // 
            this.buttonFiltrarIdHabitacion.Location = new System.Drawing.Point(1301, 236);
            this.buttonFiltrarIdHabitacion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrarIdHabitacion.Name = "buttonFiltrarIdHabitacion";
            this.buttonFiltrarIdHabitacion.Size = new System.Drawing.Size(179, 28);
            this.buttonFiltrarIdHabitacion.TabIndex = 23;
            this.buttonFiltrarIdHabitacion.Text = "Filtrar por ID Habitación";
            this.toolTip1.SetToolTip(this.buttonFiltrarIdHabitacion, "Filtrar segín el número de la habitación");
            this.buttonFiltrarIdHabitacion.UseVisualStyleBackColor = true;
            this.buttonFiltrarIdHabitacion.Click += new System.EventHandler(this.buttonFiltrarIdHabitacion_Click);
            // 
            // textBoxFiltrarIdHabitacion
            // 
            this.textBoxFiltrarIdHabitacion.Location = new System.Drawing.Point(1136, 239);
            this.textBoxFiltrarIdHabitacion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiltrarIdHabitacion.Name = "textBoxFiltrarIdHabitacion";
            this.textBoxFiltrarIdHabitacion.Size = new System.Drawing.Size(132, 22);
            this.textBoxFiltrarIdHabitacion.TabIndex = 22;
            // 
            // parteReparacionTableAdapter
            // 
            this.parteReparacionTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1136, 239);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 22;
            this.toolTip1.SetToolTip(this.textBox1, "Introduzca el ID de la habitación");
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\AyudaHotel.chm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1247, 536);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // InformeParteReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1520, 763);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonFiltrarPrecio);
            this.Controls.Add(this.textBoxFiltrarPrecio);
            this.Controls.Add(this.buttonQuitarFiltro);
            this.Controls.Add(this.buttonFiltrarIdHabitacion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxFiltrarIdHabitacion);
            this.Controls.Add(this.buttonVolverInicio);
            this.Controls.Add(this.reportViewer1);
            this.helpProvider1.SetHelpKeyword(this, "14");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InformeParteReparacion";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Informe Parte de Reparación";
            this.Load += new System.EventHandler(this.InformeParteReparacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parteReparacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button buttonVolverInicio;
        private System.Windows.Forms.Button buttonFiltrarPrecio;
        private System.Windows.Forms.TextBox textBoxFiltrarPrecio;
        private System.Windows.Forms.Button buttonQuitarFiltro;
        private System.Windows.Forms.Button buttonFiltrarIdHabitacion;
        private System.Windows.Forms.TextBox textBoxFiltrarIdHabitacion;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource parteReparacionBindingSource;
        private HotelDataSetTableAdapters.ParteReparacionTableAdapter parteReparacionTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}