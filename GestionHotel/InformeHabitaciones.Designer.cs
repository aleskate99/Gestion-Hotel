namespace GestionHotel
{
    partial class InformeHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeHabitaciones));
            this.habitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.habitacionTableAdapter = new GestionHotel.HotelDataSetTableAdapters.HabitacionTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonVolver = new System.Windows.Forms.Button();
            this.comboBoxDesayuno = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.buttonDesayuno = new System.Windows.Forms.Button();
            this.buttonEstado = new System.Windows.Forms.Button();
            this.buttonQuitarFiltro = new System.Windows.Forms.Button();
            this.buttonTipo = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // habitacionBindingSource
            // 
            this.habitacionBindingSource.DataMember = "Habitacion";
            this.habitacionBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Habitaciones";
            reportDataSource1.Value = this.habitacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionHotel.InformeHabitaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(998, 852);
            this.reportViewer1.TabIndex = 0;
            // 
            // habitacionTableAdapter
            // 
            this.habitacionTableAdapter.ClearBeforeFill = true;
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolver.FlatAppearance.BorderSize = 0;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolver.Image")));
            this.buttonVolver.Location = new System.Drawing.Point(1229, 51);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 60);
            this.buttonVolver.TabIndex = 12;
            this.toolTip1.SetToolTip(this.buttonVolver, "Volver a la ventana habitaciones");
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // comboBoxDesayuno
            // 
            this.comboBoxDesayuno.FormattingEnabled = true;
            this.comboBoxDesayuno.Items.AddRange(new object[] {
            "Incluido",
            "No incluido"});
            this.comboBoxDesayuno.Location = new System.Drawing.Point(1021, 386);
            this.comboBoxDesayuno.Name = "comboBoxDesayuno";
            this.comboBoxDesayuno.Size = new System.Drawing.Size(132, 24);
            this.comboBoxDesayuno.TabIndex = 33;
            this.toolTip1.SetToolTip(this.comboBoxDesayuno, "Seleccione una opción del desplegable");
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Libre",
            "Ocupada"});
            this.comboBoxEstado.Location = new System.Drawing.Point(1021, 301);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(132, 24);
            this.comboBoxEstado.TabIndex = 32;
            this.toolTip1.SetToolTip(this.comboBoxEstado, "Seleccione una opción del desplegable");
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Privada",
            "Compartida",
            "Suite"});
            this.comboBoxTipo.Location = new System.Drawing.Point(1021, 218);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(132, 24);
            this.comboBoxTipo.TabIndex = 31;
            this.toolTip1.SetToolTip(this.comboBoxTipo, "Seleccione una opción del desplegable");
            // 
            // buttonDesayuno
            // 
            this.buttonDesayuno.Location = new System.Drawing.Point(1186, 386);
            this.buttonDesayuno.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDesayuno.Name = "buttonDesayuno";
            this.buttonDesayuno.Size = new System.Drawing.Size(143, 28);
            this.buttonDesayuno.TabIndex = 30;
            this.buttonDesayuno.Text = "Filtrar por desayuno";
            this.toolTip1.SetToolTip(this.buttonDesayuno, "Filtrar en función si esta incluido o no el desayuno");
            this.buttonDesayuno.UseVisualStyleBackColor = true;
            this.buttonDesayuno.Click += new System.EventHandler(this.buttonDesayuno_Click);
            // 
            // buttonEstado
            // 
            this.buttonEstado.Location = new System.Drawing.Point(1186, 301);
            this.buttonEstado.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEstado.Name = "buttonEstado";
            this.buttonEstado.Size = new System.Drawing.Size(143, 28);
            this.buttonEstado.TabIndex = 29;
            this.buttonEstado.Text = "Filtrar por estado";
            this.toolTip1.SetToolTip(this.buttonEstado, "Filtrar por el estado de la habitación");
            this.buttonEstado.UseVisualStyleBackColor = true;
            this.buttonEstado.Click += new System.EventHandler(this.buttonEstado_Click);
            // 
            // buttonQuitarFiltro
            // 
            this.buttonQuitarFiltro.Location = new System.Drawing.Point(1136, 480);
            this.buttonQuitarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuitarFiltro.Name = "buttonQuitarFiltro";
            this.buttonQuitarFiltro.Size = new System.Drawing.Size(100, 28);
            this.buttonQuitarFiltro.TabIndex = 28;
            this.buttonQuitarFiltro.Text = "Quitar filtros";
            this.toolTip1.SetToolTip(this.buttonQuitarFiltro, "Quitar filtros");
            this.buttonQuitarFiltro.UseVisualStyleBackColor = true;
            this.buttonQuitarFiltro.Click += new System.EventHandler(this.buttonQuitarFiltro_Click);
            // 
            // buttonTipo
            // 
            this.buttonTipo.Location = new System.Drawing.Point(1186, 218);
            this.buttonTipo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTipo.Name = "buttonTipo";
            this.buttonTipo.Size = new System.Drawing.Size(143, 28);
            this.buttonTipo.TabIndex = 27;
            this.buttonTipo.Text = "Filtrar por tipo";
            this.toolTip1.SetToolTip(this.buttonTipo, "Filtrar por tipo de habitación");
            this.buttonTipo.UseVisualStyleBackColor = true;
            this.buttonTipo.Click += new System.EventHandler(this.buttonTipo_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\AyudaHotel.chm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1136, 594);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // InformeHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1342, 849);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxDesayuno);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.buttonDesayuno);
            this.Controls.Add(this.buttonEstado);
            this.Controls.Add(this.buttonQuitarFiltro);
            this.Controls.Add(this.buttonTipo);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.reportViewer1);
            this.helpProvider1.SetHelpKeyword(this, "18");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InformeHabitaciones";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Informe Habitaciones";
            this.Load += new System.EventHandler(this.InformeHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource habitacionBindingSource;
        private HotelDataSetTableAdapters.HabitacionTableAdapter habitacionTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.ComboBox comboBoxDesayuno;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button buttonDesayuno;
        private System.Windows.Forms.Button buttonEstado;
        private System.Windows.Forms.Button buttonQuitarFiltro;
        private System.Windows.Forms.Button buttonTipo;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}