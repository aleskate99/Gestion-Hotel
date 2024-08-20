namespace GestionHotel
{
    partial class CrearIncidencia
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
            System.Windows.Forms.Label idIncidenciaLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label solucionLabel;
            System.Windows.Forms.Label resumenLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label tiempoEstimadoArregloLabel;
            System.Windows.Forms.Label imagenLabel;
            System.Windows.Forms.Label gravedadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearIncidencia));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripLabelContadorIncidencias = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSiguiente = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFinal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAnadir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInforme = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxBuscarClientes = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBoxBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonBuscar = new System.Windows.Forms.ToolStripButton();
            this.buttonVolverInicio = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.incidenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.solucionTextBox = new System.Windows.Forms.TextBox();
            this.resumenTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gravedadComboBox = new System.Windows.Forms.ComboBox();
            this.tiempoEstimadoArregloNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idIncidenciaLabel1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.incidenciaTableAdapter = new GestionHotel.HotelDataSetTableAdapters.IncidenciaTableAdapter();
            this.tableAdapterManager = new GestionHotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.detalleParteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            idIncidenciaLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            solucionLabel = new System.Windows.Forms.Label();
            resumenLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            tiempoEstimadoArregloLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            gravedadLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiempoEstimadoArregloNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleParteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idIncidenciaLabel
            // 
            idIncidenciaLabel.AutoSize = true;
            idIncidenciaLabel.BackColor = System.Drawing.Color.Transparent;
            idIncidenciaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idIncidenciaLabel.Location = new System.Drawing.Point(32, 47);
            idIncidenciaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idIncidenciaLabel.Name = "idIncidenciaLabel";
            idIncidenciaLabel.Size = new System.Drawing.Size(133, 22);
            idIncidenciaLabel.TabIndex = 31;
            idIncidenciaLabel.Text = "Id Incidencia *";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.BackColor = System.Drawing.Color.Transparent;
            tipoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel.Location = new System.Drawing.Point(32, 95);
            tipoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(61, 22);
            tipoLabel.TabIndex = 33;
            tipoLabel.Text = "Tipo *";
            // 
            // solucionLabel
            // 
            solucionLabel.AutoSize = true;
            solucionLabel.BackColor = System.Drawing.Color.Transparent;
            solucionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            solucionLabel.Location = new System.Drawing.Point(39, 415);
            solucionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            solucionLabel.Name = "solucionLabel";
            solucionLabel.Size = new System.Drawing.Size(81, 22);
            solucionLabel.TabIndex = 35;
            solucionLabel.Text = "Solución";
            // 
            // resumenLabel
            // 
            resumenLabel.AutoSize = true;
            resumenLabel.BackColor = System.Drawing.Color.Transparent;
            resumenLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resumenLabel.Location = new System.Drawing.Point(37, 310);
            resumenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            resumenLabel.Name = "resumenLabel";
            resumenLabel.Size = new System.Drawing.Size(97, 22);
            resumenLabel.TabIndex = 37;
            resumenLabel.Text = "Resumen *";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.BackColor = System.Drawing.Color.Transparent;
            estadoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(35, 206);
            estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(81, 22);
            estadoLabel.TabIndex = 39;
            estadoLabel.Text = "Estado *";
            // 
            // tiempoEstimadoArregloLabel
            // 
            tiempoEstimadoArregloLabel.AutoSize = true;
            tiempoEstimadoArregloLabel.BackColor = System.Drawing.Color.Transparent;
            tiempoEstimadoArregloLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tiempoEstimadoArregloLabel.Location = new System.Drawing.Point(37, 260);
            tiempoEstimadoArregloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tiempoEstimadoArregloLabel.Name = "tiempoEstimadoArregloLabel";
            tiempoEstimadoArregloLabel.Size = new System.Drawing.Size(150, 22);
            tiempoEstimadoArregloLabel.TabIndex = 43;
            tiempoEstimadoArregloLabel.Text = "Tiempo Arreglo *";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.BackColor = System.Drawing.Color.Transparent;
            imagenLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imagenLabel.Location = new System.Drawing.Point(672, 187);
            imagenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(77, 22);
            imagenLabel.TabIndex = 45;
            imagenLabel.Text = "Imagen:";
            // 
            // gravedadLabel
            // 
            gravedadLabel.AutoSize = true;
            gravedadLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gravedadLabel.Location = new System.Drawing.Point(32, 155);
            gravedadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gravedadLabel.Name = "gravedadLabel";
            gravedadLabel.Size = new System.Drawing.Size(105, 22);
            gravedadLabel.TabIndex = 45;
            gravedadLabel.Text = "Gravedad *";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInicio,
            this.toolStripButtonAnterior,
            this.toolStripSeparator1,
            this.toolstripLabelContadorIncidencias,
            this.toolStripSeparator2,
            this.toolStripButtonSiguiente,
            this.toolStripButtonFinal,
            this.toolStripSeparator3,
            this.toolStripButtonAnadir,
            this.toolStripButtonEliminar,
            this.toolStripButtonEditar,
            this.toolStripSeparator4,
            this.toolStripButtonGuardar,
            this.toolStripButtonImprimir,
            this.toolStripButtonInforme,
            this.toolStripSeparator5,
            this.toolStripComboBoxBuscarClientes,
            this.toolStripTextBoxBuscar,
            this.toolStripButtonBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1307, 91);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonInicio
            // 
            this.toolStripButtonInicio.AutoSize = false;
            this.toolStripButtonInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInicio.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInicio.Image")));
            this.toolStripButtonInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInicio.Name = "toolStripButtonInicio";
            this.toolStripButtonInicio.Size = new System.Drawing.Size(29, 55);
            this.toolStripButtonInicio.Text = "Ir al principio";
            this.toolStripButtonInicio.Click += new System.EventHandler(this.toolStripButtonInicio_Click);
            // 
            // toolStripButtonAnterior
            // 
            this.toolStripButtonAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAnterior.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAnterior.Image")));
            this.toolStripButtonAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnterior.Name = "toolStripButtonAnterior";
            this.toolStripButtonAnterior.Size = new System.Drawing.Size(29, 88);
            this.toolStripButtonAnterior.Text = "Anterior";
            this.toolStripButtonAnterior.Click += new System.EventHandler(this.toolStripButtonAnterior_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 91);
            // 
            // toolstripLabelContadorIncidencias
            // 
            this.toolstripLabelContadorIncidencias.Name = "toolstripLabelContadorIncidencias";
            this.toolstripLabelContadorIncidencias.Size = new System.Drawing.Size(76, 88);
            this.toolstripLabelContadorIncidencias.Text = "incidencia";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 91);
            // 
            // toolStripButtonSiguiente
            // 
            this.toolStripButtonSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSiguiente.Image")));
            this.toolStripButtonSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSiguiente.Name = "toolStripButtonSiguiente";
            this.toolStripButtonSiguiente.Size = new System.Drawing.Size(29, 88);
            this.toolStripButtonSiguiente.Text = "Siguiente";
            this.toolStripButtonSiguiente.Click += new System.EventHandler(this.toolStripButtonSiguiente_Click);
            // 
            // toolStripButtonFinal
            // 
            this.toolStripButtonFinal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFinal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFinal.Image")));
            this.toolStripButtonFinal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFinal.Name = "toolStripButtonFinal";
            this.toolStripButtonFinal.Size = new System.Drawing.Size(29, 88);
            this.toolStripButtonFinal.Text = "Ir al final";
            this.toolStripButtonFinal.Click += new System.EventHandler(this.toolStripButtonFinal_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 91);
            // 
            // toolStripButtonAnadir
            // 
            this.toolStripButtonAnadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAnadir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAnadir.Image")));
            this.toolStripButtonAnadir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAnadir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnadir.Name = "toolStripButtonAnadir";
            this.toolStripButtonAnadir.Size = new System.Drawing.Size(52, 88);
            this.toolStripButtonAnadir.Text = "Añadir";
            this.toolStripButtonAnadir.ToolTipText = "Añadir Incidencia";
            this.toolStripButtonAnadir.Click += new System.EventHandler(this.toolStripButtonAnadir_Click);
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminar.Image")));
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(29, 88);
            this.toolStripButtonEliminar.Text = "Eliminar";
            this.toolStripButtonEliminar.ToolTipText = "Eliminar Incidencia";
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.toolStripButtonEliminar_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditar.Image")));
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(29, 88);
            this.toolStripButtonEditar.Text = "Editar";
            this.toolStripButtonEditar.ToolTipText = "Editar Incidencia";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 91);
            // 
            // toolStripButtonGuardar
            // 
            this.toolStripButtonGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuardar.Image")));
            this.toolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuardar.Name = "toolStripButtonGuardar";
            this.toolStripButtonGuardar.Size = new System.Drawing.Size(29, 88);
            this.toolStripButtonGuardar.Text = "Guardar";
            this.toolStripButtonGuardar.Click += new System.EventHandler(this.toolStripButtonGuardar_Click);
            // 
            // toolStripButtonImprimir
            // 
            this.toolStripButtonImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImprimir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImprimir.Image")));
            this.toolStripButtonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImprimir.Name = "toolStripButtonImprimir";
            this.toolStripButtonImprimir.Size = new System.Drawing.Size(29, 88);
            this.toolStripButtonImprimir.Text = "toolStripButton1";
            this.toolStripButtonImprimir.ToolTipText = "Imprimir";
            this.toolStripButtonImprimir.Click += new System.EventHandler(this.toolStripButtonImprimir_Click);
            // 
            // toolStripButtonInforme
            // 
            this.toolStripButtonInforme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInforme.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInforme.Image")));
            this.toolStripButtonInforme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInforme.Name = "toolStripButtonInforme";
            this.toolStripButtonInforme.Size = new System.Drawing.Size(29, 88);
            this.toolStripButtonInforme.ToolTipText = "Informe";
            this.toolStripButtonInforme.Click += new System.EventHandler(this.toolStripButtonInforme_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 91);
            // 
            // toolStripComboBoxBuscarClientes
            // 
            this.toolStripComboBoxBuscarClientes.Items.AddRange(new object[] {
            "Id",
            "Nombre"});
            this.toolStripComboBoxBuscarClientes.Name = "toolStripComboBoxBuscarClientes";
            this.toolStripComboBoxBuscarClientes.Size = new System.Drawing.Size(160, 91);
            this.toolStripComboBoxBuscarClientes.Text = "Buscar Incidencia";
            this.toolStripComboBoxBuscarClientes.ToolTipText = "Seleccione mediante que campo desea buscar la incidencia\r\n";
            // 
            // toolStripTextBoxBuscar
            // 
            this.toolStripTextBoxBuscar.Name = "toolStripTextBoxBuscar";
            this.toolStripTextBoxBuscar.Size = new System.Drawing.Size(100, 91);
            this.toolStripTextBoxBuscar.ToolTipText = "Escribe la incidencia que desee buscar";
            // 
            // toolStripButtonBuscar
            // 
            this.toolStripButtonBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBuscar.Image")));
            this.toolStripButtonBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBuscar.Name = "toolStripButtonBuscar";
            this.toolStripButtonBuscar.Size = new System.Drawing.Size(29, 88);
            this.toolStripButtonBuscar.Text = "Buscar";
            this.toolStripButtonBuscar.Click += new System.EventHandler(this.toolStripButtonBuscar_Click);
            // 
            // buttonVolverInicio
            // 
            this.buttonVolverInicio.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolverInicio.FlatAppearance.BorderSize = 0;
            this.buttonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverInicio.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolverInicio.Image")));
            this.buttonVolverInicio.Location = new System.Drawing.Point(1192, 108);
            this.buttonVolverInicio.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolverInicio.Name = "buttonVolverInicio";
            this.buttonVolverInicio.Size = new System.Drawing.Size(88, 68);
            this.buttonVolverInicio.TabIndex = 17;
            this.toolTip1.SetToolTip(this.buttonVolverInicio, "Volver a la ventana de incidencias");
            this.buttonVolverInicio.UseVisualStyleBackColor = false;
            this.buttonVolverInicio.Click += new System.EventHandler(this.buttonVolverInicio_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(1013, 630);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(169, 70);
            this.buttonCancelar.TabIndex = 19;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonCancelar, "Aborta operación y limpia los datos");
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAceptar.FlatAppearance.BorderSize = 0;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAceptar.Location = new System.Drawing.Point(779, 630);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(165, 70);
            this.buttonAceptar.TabIndex = 18;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonAceptar, "Valida los campos introducidos");
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 733);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1307, 26);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // buttonAyuda
            // 
            this.buttonAyuda.BackColor = System.Drawing.Color.Transparent;
            this.buttonAyuda.FlatAppearance.BorderSize = 0;
            this.buttonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyuda.Image = ((System.Drawing.Image)(resources.GetObject("buttonAyuda.Image")));
            this.buttonAyuda.Location = new System.Drawing.Point(0, 659);
            this.buttonAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAyuda.Name = "buttonAyuda";
            this.buttonAyuda.Size = new System.Drawing.Size(69, 70);
            this.buttonAyuda.TabIndex = 31;
            this.toolTip1.SetToolTip(this.buttonAyuda, "Ayuda");
            this.buttonAyuda.UseVisualStyleBackColor = false;
            this.buttonAyuda.Click += new System.EventHandler(this.buttonAyuda_Click);
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaBindingSource, "Tipo", true));
            this.tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.incidenciaBindingSource, "Tipo", true));
            this.tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.incidenciaBindingSource, "Tipo", true));
            this.tipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Items.AddRange(new object[] {
            "Incendio",
            "Fuga de agua",
            "Avería eléctrica",
            "Robo"});
            this.tipoComboBox.Location = new System.Drawing.Point(209, 92);
            this.tipoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(263, 30);
            this.tipoComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tipoComboBox, "Seleccione una opción del desplegable");
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
            // solucionTextBox
            // 
            this.solucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaBindingSource, "Solucion", true));
            this.solucionTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solucionTextBox.Location = new System.Drawing.Point(214, 416);
            this.solucionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.solucionTextBox.Multiline = true;
            this.solucionTextBox.Name = "solucionTextBox";
            this.solucionTextBox.Size = new System.Drawing.Size(263, 84);
            this.solucionTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.solucionTextBox, "Introduzca una posible solución");
            // 
            // resumenTextBox
            // 
            this.resumenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaBindingSource, "Resumen", true));
            this.resumenTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumenTextBox.Location = new System.Drawing.Point(214, 307);
            this.resumenTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resumenTextBox.Multiline = true;
            this.resumenTextBox.Name = "resumenTextBox";
            this.resumenTextBox.Size = new System.Drawing.Size(263, 84);
            this.resumenTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.resumenTextBox, "Introduzca un resumen sobre la incidencia");
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaBindingSource, "Estado", true));
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.incidenciaBindingSource, "Estado", true));
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.incidenciaBindingSource, "Estado", true));
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Recibida",
            "Trabajando",
            "Resuelta"});
            this.estadoComboBox.Location = new System.Drawing.Point(209, 203);
            this.estadoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(263, 30);
            this.estadoComboBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.estadoComboBox, "Seleccione una opción del desplegable");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(gravedadLabel);
            this.groupBox1.Controls.Add(this.gravedadComboBox);
            this.groupBox1.Controls.Add(this.tiempoEstimadoArregloNumericUpDown);
            this.groupBox1.Controls.Add(this.idIncidenciaLabel1);
            this.groupBox1.Controls.Add(idIncidenciaLabel);
            this.groupBox1.Controls.Add(tiempoEstimadoArregloLabel);
            this.groupBox1.Controls.Add(tipoLabel);
            this.groupBox1.Controls.Add(this.tipoComboBox);
            this.groupBox1.Controls.Add(solucionLabel);
            this.groupBox1.Controls.Add(this.estadoComboBox);
            this.groupBox1.Controls.Add(this.solucionTextBox);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(resumenLabel);
            this.groupBox1.Controls.Add(this.resumenTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(77, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(563, 524);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incidencias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "horas";
            // 
            // gravedadComboBox
            // 
            this.gravedadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaBindingSource, "Gravedad", true));
            this.gravedadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.incidenciaBindingSource, "Gravedad", true));
            this.gravedadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.incidenciaBindingSource, "Gravedad", true));
            this.gravedadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gravedadComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravedadComboBox.FormattingEnabled = true;
            this.gravedadComboBox.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta",
            "Muy alta"});
            this.gravedadComboBox.Location = new System.Drawing.Point(214, 152);
            this.gravedadComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.gravedadComboBox.Name = "gravedadComboBox";
            this.gravedadComboBox.Size = new System.Drawing.Size(256, 30);
            this.gravedadComboBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.gravedadComboBox, "Seleccione una opción del desplegable");
            // 
            // tiempoEstimadoArregloNumericUpDown
            // 
            this.tiempoEstimadoArregloNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.incidenciaBindingSource, "TiempoEstimadoArreglo", true));
            this.tiempoEstimadoArregloNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempoEstimadoArregloNumericUpDown.Location = new System.Drawing.Point(209, 259);
            this.tiempoEstimadoArregloNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tiempoEstimadoArregloNumericUpDown.Name = "tiempoEstimadoArregloNumericUpDown";
            this.tiempoEstimadoArregloNumericUpDown.Size = new System.Drawing.Size(263, 30);
            this.tiempoEstimadoArregloNumericUpDown.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tiempoEstimadoArregloNumericUpDown, "Incremente las horas que tardará en solucionar la incidencia");
            // 
            // idIncidenciaLabel1
            // 
            this.idIncidenciaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaBindingSource, "IdIncidencia", true));
            this.idIncidenciaLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idIncidenciaLabel1.Location = new System.Drawing.Point(203, 48);
            this.idIncidenciaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idIncidenciaLabel1.Name = "idIncidenciaLabel1";
            this.idIncidenciaLabel1.Size = new System.Drawing.Size(133, 28);
            this.idIncidenciaLabel1.TabIndex = 45;
            this.idIncidenciaLabel1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // incidenciaTableAdapter
            // 
            this.incidenciaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.DetalleParteTableAdapter = null;
            this.tableAdapterManager.DetalleReservaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.HabitacionTableAdapter = null;
            this.tableAdapterManager.IncidenciaTableAdapter = this.incidenciaTableAdapter;
            this.tableAdapterManager.ParteReparacionTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionHotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // detalleParteBindingSource
            // 
            this.detalleParteBindingSource.DataMember = "DetalleParte";
            this.detalleParteBindingSource.DataSource = this.hotelDataSet;
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.imagenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagenPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.incidenciaBindingSource, "Imagen", true));
            this.imagenPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.ErrorImage")));
            this.imagenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.Image")));
            this.imagenPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.InitialImage")));
            this.imagenPictureBox.Location = new System.Drawing.Point(767, 193);
            this.imagenPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(386, 302);
            this.imagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPictureBox.TabIndex = 48;
            this.imagenPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.imagenPictureBox, "Haga clic para insertar una imágen");
            this.imagenPictureBox.Click += new System.EventHandler(this.imagenPictureBox_Click_1);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\AyudaHotel.chm";
            // 
            // CrearIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1307, 759);
            this.Controls.Add(this.imagenPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(imagenLabel);
            this.Controls.Add(this.buttonAyuda);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonVolverInicio);
            this.Controls.Add(this.toolStrip1);
            this.helpProvider1.SetHelpKeyword(this, "8");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CrearIncidencia";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Crear Incidencia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrearIncidencia_FormClosed);
            this.Load += new System.EventHandler(this.CrearIncidencia_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiempoEstimadoArregloNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleParteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInicio;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnterior;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolstripLabelContadorIncidencias;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSiguiente;
        private System.Windows.Forms.ToolStripButton toolStripButtonFinal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnadir;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStripButton toolStripButtonImprimir;
        private System.Windows.Forms.ToolStripButton toolStripButtonInforme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxBuscarClientes;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBuscar;
        private System.Windows.Forms.ToolStripButton toolStripButtonBuscar;
        private System.Windows.Forms.Button buttonVolverInicio;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonAyuda;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource incidenciaBindingSource;
        private HotelDataSetTableAdapters.IncidenciaTableAdapter incidenciaTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource detalleParteBindingSource;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.TextBox solucionTextBox;
        private System.Windows.Forms.TextBox resumenTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label idIncidenciaLabel1;
        private System.Windows.Forms.PictureBox imagenPictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown tiempoEstimadoArregloNumericUpDown;
        private System.Windows.Forms.ComboBox gravedadComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}