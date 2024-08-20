namespace GestionHotel
{
    partial class InformeReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeReservas));
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonVolverInicio = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxTipoDePago = new System.Windows.Forms.ComboBox();
            this.buttonFiltrarId = new System.Windows.Forms.Button();
            this.textBoxFiltrarIdReserva = new System.Windows.Forms.TextBox();
            this.buttonQuitarFiltro = new System.Windows.Forms.Button();
            this.buttonFiltrarTipoDePago = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reservaTableAdapter = new GestionHotel.HotelDataSetTableAdapters.ReservaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reservaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionHotel.InformeReservas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1102, 769);
            this.reportViewer1.TabIndex = 0;
            // 
            // buttonVolverInicio
            // 
            this.buttonVolverInicio.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolverInicio.FlatAppearance.BorderSize = 0;
            this.buttonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverInicio.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolverInicio.Image")));
            this.buttonVolverInicio.Location = new System.Drawing.Point(1366, 64);
            this.buttonVolverInicio.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolverInicio.Name = "buttonVolverInicio";
            this.buttonVolverInicio.Size = new System.Drawing.Size(88, 68);
            this.buttonVolverInicio.TabIndex = 20;
            this.toolTip1.SetToolTip(this.buttonVolverInicio, "Volver a la ventana anterior");
            this.buttonVolverInicio.UseVisualStyleBackColor = false;
            this.buttonVolverInicio.Click += new System.EventHandler(this.buttonVolverInicio_Click);
            // 
            // comboBoxTipoDePago
            // 
            this.comboBoxTipoDePago.FormattingEnabled = true;
            this.comboBoxTipoDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.comboBoxTipoDePago.Location = new System.Drawing.Point(1127, 363);
            this.comboBoxTipoDePago.Name = "comboBoxTipoDePago";
            this.comboBoxTipoDePago.Size = new System.Drawing.Size(141, 24);
            this.comboBoxTipoDePago.TabIndex = 41;
            this.toolTip1.SetToolTip(this.comboBoxTipoDePago, "Seleccione una opción del desplegable");
            // 
            // buttonFiltrarId
            // 
            this.buttonFiltrarId.Location = new System.Drawing.Point(1292, 265);
            this.buttonFiltrarId.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrarId.Name = "buttonFiltrarId";
            this.buttonFiltrarId.Size = new System.Drawing.Size(179, 28);
            this.buttonFiltrarId.TabIndex = 40;
            this.buttonFiltrarId.Text = "Filtrar por id Reserva";
            this.toolTip1.SetToolTip(this.buttonFiltrarId, "Filtra según el número de Id");
            this.buttonFiltrarId.UseVisualStyleBackColor = true;
            this.buttonFiltrarId.Click += new System.EventHandler(this.buttonFiltrarId_Click);
            // 
            // textBoxFiltrarIdReserva
            // 
            this.textBoxFiltrarIdReserva.Location = new System.Drawing.Point(1127, 268);
            this.textBoxFiltrarIdReserva.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiltrarIdReserva.Name = "textBoxFiltrarIdReserva";
            this.textBoxFiltrarIdReserva.Size = new System.Drawing.Size(141, 22);
            this.textBoxFiltrarIdReserva.TabIndex = 39;
            this.toolTip1.SetToolTip(this.textBoxFiltrarIdReserva, "Introduzca el Id");
            // 
            // buttonQuitarFiltro
            // 
            this.buttonQuitarFiltro.Location = new System.Drawing.Point(1239, 435);
            this.buttonQuitarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuitarFiltro.Name = "buttonQuitarFiltro";
            this.buttonQuitarFiltro.Size = new System.Drawing.Size(100, 28);
            this.buttonQuitarFiltro.TabIndex = 38;
            this.buttonQuitarFiltro.Text = "Quitar filtros";
            this.toolTip1.SetToolTip(this.buttonQuitarFiltro, "Quitar los filtros");
            this.buttonQuitarFiltro.UseVisualStyleBackColor = true;
            this.buttonQuitarFiltro.Click += new System.EventHandler(this.buttonQuitarFiltro_Click);
            // 
            // buttonFiltrarTipoDePago
            // 
            this.buttonFiltrarTipoDePago.Location = new System.Drawing.Point(1292, 363);
            this.buttonFiltrarTipoDePago.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrarTipoDePago.Name = "buttonFiltrarTipoDePago";
            this.buttonFiltrarTipoDePago.Size = new System.Drawing.Size(179, 30);
            this.buttonFiltrarTipoDePago.TabIndex = 37;
            this.buttonFiltrarTipoDePago.Text = "Filtrar por tipo de pago";
            this.toolTip1.SetToolTip(this.buttonFiltrarTipoDePago, "Filtra según tipo de pago");
            this.buttonFiltrarTipoDePago.UseVisualStyleBackColor = true;
            this.buttonFiltrarTipoDePago.Click += new System.EventHandler(this.buttonFiltrarTipoDePago_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\AyudaHotel.chm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1235, 562);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // InformeReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1484, 770);
            this.Controls.Add(this.comboBoxTipoDePago);
            this.Controls.Add(this.buttonFiltrarId);
            this.Controls.Add(this.textBoxFiltrarIdReserva);
            this.Controls.Add(this.buttonQuitarFiltro);
            this.Controls.Add(this.buttonFiltrarTipoDePago);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVolverInicio);
            this.Controls.Add(this.reportViewer1);
            this.helpProvider1.SetHelpKeyword(this, "11");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InformeReservas";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Informe Reservas";
            this.Load += new System.EventHandler(this.InformeReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button buttonVolverInicio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxTipoDePago;
        private System.Windows.Forms.Button buttonFiltrarId;
        private System.Windows.Forms.TextBox textBoxFiltrarIdReserva;
        private System.Windows.Forms.Button buttonQuitarFiltro;
        private System.Windows.Forms.Button buttonFiltrarTipoDePago;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private HotelDataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
    }
}