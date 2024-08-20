namespace GestionHotel
{
    partial class HabitacionesCliente
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
            System.Windows.Forms.Label idHabitacionLabel;
            System.Windows.Forms.Label tipoHabitacionLabel;
            System.Windows.Forms.Label imagenHabitacionLabel1;
            System.Windows.Forms.Label numeroHuespedesLabel;
            System.Windows.Forms.Label banosLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label tipoCamaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label camaSupletoriaLabel;
            System.Windows.Forms.Label desayunoLabel;
            System.Windows.Forms.Label imagenBanoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HabitacionesCliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolstripLabelContadorHabitaciones = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonSiguiente = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFinal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInforme = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxBuscarHabitacion = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBoxBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonBuscar = new System.Windows.Forms.ToolStripButton();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numeroHuespedesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.habitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.idHabitacionLabel1 = new System.Windows.Forms.Label();
            this.tipoHabitacionComboBox = new System.Windows.Forms.ComboBox();
            this.banosComboBox = new System.Windows.Forms.ComboBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoCamaComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.camaSupletoriaComboBox = new System.Windows.Forms.ComboBox();
            this.desayunoComboBox = new System.Windows.Forms.ComboBox();
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.habitacionTableAdapter = new GestionHotel.HotelDataSetTableAdapters.HabitacionTableAdapter();
            this.tableAdapterManager = new GestionHotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.imagenHabitacionPictureBox = new System.Windows.Forms.PictureBox();
            this.imagenBanoPictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            idHabitacionLabel = new System.Windows.Forms.Label();
            tipoHabitacionLabel = new System.Windows.Forms.Label();
            imagenHabitacionLabel1 = new System.Windows.Forms.Label();
            numeroHuespedesLabel = new System.Windows.Forms.Label();
            banosLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            tipoCamaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            camaSupletoriaLabel = new System.Windows.Forms.Label();
            desayunoLabel = new System.Windows.Forms.Label();
            imagenBanoLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroHuespedesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenHabitacionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBanoPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idHabitacionLabel
            // 
            idHabitacionLabel.AutoSize = true;
            idHabitacionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idHabitacionLabel.Location = new System.Drawing.Point(20, 51);
            idHabitacionLabel.Name = "idHabitacionLabel";
            idHabitacionLabel.Size = new System.Drawing.Size(138, 22);
            idHabitacionLabel.TabIndex = 0;
            idHabitacionLabel.Text = "Id Habitación *";
            // 
            // tipoHabitacionLabel
            // 
            tipoHabitacionLabel.AutoSize = true;
            tipoHabitacionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoHabitacionLabel.Location = new System.Drawing.Point(23, 100);
            tipoHabitacionLabel.Name = "tipoHabitacionLabel";
            tipoHabitacionLabel.Size = new System.Drawing.Size(181, 22);
            tipoHabitacionLabel.TabIndex = 2;
            tipoHabitacionLabel.Text = "Tipo de Habitación *";
            // 
            // imagenHabitacionLabel1
            // 
            imagenHabitacionLabel1.AutoSize = true;
            imagenHabitacionLabel1.BackColor = System.Drawing.Color.Transparent;
            imagenHabitacionLabel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imagenHabitacionLabel1.Location = new System.Drawing.Point(594, 92);
            imagenHabitacionLabel1.Name = "imagenHabitacionLabel1";
            imagenHabitacionLabel1.Size = new System.Drawing.Size(151, 20);
            imagenHabitacionLabel1.TabIndex = 4;
            imagenHabitacionLabel1.Text = "Imagen Habitación";
            // 
            // numeroHuespedesLabel
            // 
            numeroHuespedesLabel.AutoSize = true;
            numeroHuespedesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroHuespedesLabel.Location = new System.Drawing.Point(20, 272);
            numeroHuespedesLabel.Name = "numeroHuespedesLabel";
            numeroHuespedesLabel.Size = new System.Drawing.Size(204, 22);
            numeroHuespedesLabel.TabIndex = 6;
            numeroHuespedesLabel.Text = "Número de Huéspedes *";
            // 
            // banosLabel
            // 
            banosLabel.AutoSize = true;
            banosLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            banosLabel.Location = new System.Drawing.Point(23, 447);
            banosLabel.Name = "banosLabel";
            banosLabel.Size = new System.Drawing.Size(75, 22);
            banosLabel.TabIndex = 8;
            banosLabel.Text = "Baños *";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(23, 223);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(81, 22);
            estadoLabel.TabIndex = 10;
            estadoLabel.Text = "Estado *";
            // 
            // tipoCamaLabel
            // 
            tipoCamaLabel.AutoSize = true;
            tipoCamaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoCamaLabel.Location = new System.Drawing.Point(20, 327);
            tipoCamaLabel.Name = "tipoCamaLabel";
            tipoCamaLabel.Size = new System.Drawing.Size(137, 22);
            tipoCamaLabel.TabIndex = 12;
            tipoCamaLabel.Text = "Tipo de Cama *";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(23, 154);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(109, 22);
            descripcionLabel.TabIndex = 14;
            descripcionLabel.Text = "Descripción";
            // 
            // camaSupletoriaLabel
            // 
            camaSupletoriaLabel.AutoSize = true;
            camaSupletoriaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            camaSupletoriaLabel.Location = new System.Drawing.Point(23, 392);
            camaSupletoriaLabel.Name = "camaSupletoriaLabel";
            camaSupletoriaLabel.Size = new System.Drawing.Size(162, 22);
            camaSupletoriaLabel.TabIndex = 16;
            camaSupletoriaLabel.Text = "Cama Supletoria *";
            // 
            // desayunoLabel
            // 
            desayunoLabel.AutoSize = true;
            desayunoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            desayunoLabel.Location = new System.Drawing.Point(23, 505);
            desayunoLabel.Name = "desayunoLabel";
            desayunoLabel.Size = new System.Drawing.Size(105, 22);
            desayunoLabel.TabIndex = 18;
            desayunoLabel.Text = "Desayuno *";
            // 
            // imagenBanoLabel
            // 
            imagenBanoLabel.AutoSize = true;
            imagenBanoLabel.BackColor = System.Drawing.Color.Transparent;
            imagenBanoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imagenBanoLabel.Location = new System.Drawing.Point(593, 353);
            imagenBanoLabel.Name = "imagenBanoLabel";
            imagenBanoLabel.Size = new System.Drawing.Size(117, 22);
            imagenBanoLabel.TabIndex = 20;
            imagenBanoLabel.Text = "Imagen Baño";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInicio,
            this.toolStripButtonAnterior,
            this.toolstripLabelContadorHabitaciones,
            this.toolStripButtonSiguiente,
            this.toolStripButtonFinal,
            this.toolStripSeparator1,
            this.toolStripButtonImprimir,
            this.toolStripButtonInforme,
            this.toolStripSeparator3,
            this.toolStripComboBoxBuscarHabitacion,
            this.toolStripTextBoxBuscar,
            this.toolStripButtonBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1293, 28);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonInicio
            // 
            this.toolStripButtonInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInicio.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInicio.Image")));
            this.toolStripButtonInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInicio.Name = "toolStripButtonInicio";
            this.toolStripButtonInicio.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonInicio.ToolTipText = "Ir al principio";
            this.toolStripButtonInicio.Click += new System.EventHandler(this.toolStripButtonInicio_Click);
            // 
            // toolStripButtonAnterior
            // 
            this.toolStripButtonAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAnterior.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAnterior.Image")));
            this.toolStripButtonAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnterior.Name = "toolStripButtonAnterior";
            this.toolStripButtonAnterior.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonAnterior.ToolTipText = "Anterior";
            this.toolStripButtonAnterior.Click += new System.EventHandler(this.toolStripButtonAnterior_Click);
            // 
            // toolstripLabelContadorHabitaciones
            // 
            this.toolstripLabelContadorHabitaciones.Name = "toolstripLabelContadorHabitaciones";
            this.toolstripLabelContadorHabitaciones.Size = new System.Drawing.Size(111, 25);
            this.toolstripLabelContadorHabitaciones.Text = "toolStripLabel1";
            // 
            // toolStripButtonSiguiente
            // 
            this.toolStripButtonSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSiguiente.Image")));
            this.toolStripButtonSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSiguiente.Name = "toolStripButtonSiguiente";
            this.toolStripButtonSiguiente.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonSiguiente.ToolTipText = "Siguiente";
            this.toolStripButtonSiguiente.Click += new System.EventHandler(this.toolStripButtonSiguiente_Click);
            // 
            // toolStripButtonFinal
            // 
            this.toolStripButtonFinal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFinal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFinal.Image")));
            this.toolStripButtonFinal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFinal.Name = "toolStripButtonFinal";
            this.toolStripButtonFinal.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonFinal.ToolTipText = "Ir al final";
            this.toolStripButtonFinal.Click += new System.EventHandler(this.toolStripButtonFinal_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonImprimir
            // 
            this.toolStripButtonImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImprimir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImprimir.Image")));
            this.toolStripButtonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImprimir.Name = "toolStripButtonImprimir";
            this.toolStripButtonImprimir.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonImprimir.ToolTipText = "Imprimir ";
            this.toolStripButtonImprimir.Click += new System.EventHandler(this.toolStripButtonImprimir_Click);
            // 
            // toolStripButtonInforme
            // 
            this.toolStripButtonInforme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInforme.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInforme.Image")));
            this.toolStripButtonInforme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInforme.Name = "toolStripButtonInforme";
            this.toolStripButtonInforme.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonInforme.ToolTipText = "Informe";
            this.toolStripButtonInforme.Click += new System.EventHandler(this.toolStripButtonInforme_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripComboBoxBuscarHabitacion
            // 
            this.toolStripComboBoxBuscarHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBoxBuscarHabitacion.Items.AddRange(new object[] {
            "Id"});
            this.toolStripComboBoxBuscarHabitacion.Name = "toolStripComboBoxBuscarHabitacion";
            this.toolStripComboBoxBuscarHabitacion.Size = new System.Drawing.Size(160, 28);
            this.toolStripComboBoxBuscarHabitacion.Text = "Buscar habitación";
            this.toolStripComboBoxBuscarHabitacion.ToolTipText = "Seleccione mediante que campo desea buscar la habitación";
            // 
            // toolStripTextBoxBuscar
            // 
            this.toolStripTextBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxBuscar.Name = "toolStripTextBoxBuscar";
            this.toolStripTextBoxBuscar.Size = new System.Drawing.Size(132, 28);
            this.toolStripTextBoxBuscar.ToolTipText = "Escribe la habitación que desee buscar";
            // 
            // toolStripButtonBuscar
            // 
            this.toolStripButtonBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBuscar.Image")));
            this.toolStripButtonBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBuscar.Name = "toolStripButtonBuscar";
            this.toolStripButtonBuscar.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonBuscar.ToolTipText = "Buscar";
            this.toolStripButtonBuscar.Click += new System.EventHandler(this.toolStripButtonBuscar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolver.FlatAppearance.BorderSize = 0;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolver.Image")));
            this.buttonVolver.Location = new System.Drawing.Point(1180, 92);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 60);
            this.buttonVolver.TabIndex = 21;
            this.toolTip1.SetToolTip(this.buttonVolver, "Volver a la ventana principal");
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.numeroHuespedesNumericUpDown);
            this.groupBox1.Controls.Add(idHabitacionLabel);
            this.groupBox1.Controls.Add(this.idHabitacionLabel1);
            this.groupBox1.Controls.Add(tipoHabitacionLabel);
            this.groupBox1.Controls.Add(this.tipoHabitacionComboBox);
            this.groupBox1.Controls.Add(numeroHuespedesLabel);
            this.groupBox1.Controls.Add(banosLabel);
            this.groupBox1.Controls.Add(this.banosComboBox);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(this.estadoComboBox);
            this.groupBox1.Controls.Add(tipoCamaLabel);
            this.groupBox1.Controls.Add(this.tipoCamaComboBox);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(camaSupletoriaLabel);
            this.groupBox1.Controls.Add(this.camaSupletoriaComboBox);
            this.groupBox1.Controls.Add(desayunoLabel);
            this.groupBox1.Controls.Add(this.desayunoComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(509, 552);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la habitación";
            // 
            // numeroHuespedesNumericUpDown
            // 
            this.numeroHuespedesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.habitacionBindingSource, "NumeroHuespedes", true));
            this.numeroHuespedesNumericUpDown.Enabled = false;
            this.numeroHuespedesNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroHuespedesNumericUpDown.Location = new System.Drawing.Point(246, 272);
            this.numeroHuespedesNumericUpDown.Name = "numeroHuespedesNumericUpDown";
            this.numeroHuespedesNumericUpDown.ReadOnly = true;
            this.numeroHuespedesNumericUpDown.Size = new System.Drawing.Size(235, 30);
            this.numeroHuespedesNumericUpDown.TabIndex = 19;
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
            // idHabitacionLabel1
            // 
            this.idHabitacionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "IdHabitacion", true));
            this.idHabitacionLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idHabitacionLabel1.Location = new System.Drawing.Point(239, 51);
            this.idHabitacionLabel1.Name = "idHabitacionLabel1";
            this.idHabitacionLabel1.Size = new System.Drawing.Size(121, 23);
            this.idHabitacionLabel1.TabIndex = 1;
            this.idHabitacionLabel1.Text = "label1";
            // 
            // tipoHabitacionComboBox
            // 
            this.tipoHabitacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "TipoHabitacion", true));
            this.tipoHabitacionComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoHabitacionComboBox.FormattingEnabled = true;
            this.tipoHabitacionComboBox.Location = new System.Drawing.Point(243, 97);
            this.tipoHabitacionComboBox.Name = "tipoHabitacionComboBox";
            this.tipoHabitacionComboBox.Size = new System.Drawing.Size(238, 30);
            this.tipoHabitacionComboBox.TabIndex = 1;
            // 
            // banosComboBox
            // 
            this.banosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "Banos", true));
            this.banosComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banosComboBox.FormattingEnabled = true;
            this.banosComboBox.Location = new System.Drawing.Point(243, 444);
            this.banosComboBox.Name = "banosComboBox";
            this.banosComboBox.Size = new System.Drawing.Size(238, 30);
            this.banosComboBox.TabIndex = 3;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "Estado", true));
            this.estadoComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(246, 220);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(235, 30);
            this.estadoComboBox.TabIndex = 4;
            // 
            // tipoCamaComboBox
            // 
            this.tipoCamaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "TipoCama", true));
            this.tipoCamaComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoCamaComboBox.FormattingEnabled = true;
            this.tipoCamaComboBox.Location = new System.Drawing.Point(243, 324);
            this.tipoCamaComboBox.Name = "tipoCamaComboBox";
            this.tipoCamaComboBox.Size = new System.Drawing.Size(238, 30);
            this.tipoCamaComboBox.TabIndex = 5;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "Descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(242, 151);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(239, 47);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // camaSupletoriaComboBox
            // 
            this.camaSupletoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "CamaSupletoria", true));
            this.camaSupletoriaComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camaSupletoriaComboBox.FormattingEnabled = true;
            this.camaSupletoriaComboBox.Location = new System.Drawing.Point(242, 389);
            this.camaSupletoriaComboBox.Name = "camaSupletoriaComboBox";
            this.camaSupletoriaComboBox.Size = new System.Drawing.Size(239, 30);
            this.camaSupletoriaComboBox.TabIndex = 7;
            // 
            // desayunoComboBox
            // 
            this.desayunoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "Desayuno", true));
            this.desayunoComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desayunoComboBox.FormattingEnabled = true;
            this.desayunoComboBox.Location = new System.Drawing.Point(242, 502);
            this.desayunoComboBox.Name = "desayunoComboBox";
            this.desayunoComboBox.Size = new System.Drawing.Size(239, 30);
            this.desayunoComboBox.TabIndex = 8;
            // 
            // buttonAyuda
            // 
            this.buttonAyuda.BackColor = System.Drawing.Color.Transparent;
            this.buttonAyuda.FlatAppearance.BorderSize = 0;
            this.buttonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyuda.Image = ((System.Drawing.Image)(resources.GetObject("buttonAyuda.Image")));
            this.buttonAyuda.Location = new System.Drawing.Point(0, 635);
            this.buttonAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAyuda.Name = "buttonAyuda";
            this.buttonAyuda.Size = new System.Drawing.Size(75, 64);
            this.buttonAyuda.TabIndex = 27;
            this.toolTip1.SetToolTip(this.buttonAyuda, "Ayuda");
            this.buttonAyuda.UseVisualStyleBackColor = false;
            this.buttonAyuda.Click += new System.EventHandler(this.buttonAyuda_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 710);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1293, 26);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // habitacionTableAdapter
            // 
            this.habitacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.DetalleParteTableAdapter = null;
            this.tableAdapterManager.DetalleReservaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.HabitacionTableAdapter = this.habitacionTableAdapter;
            this.tableAdapterManager.IncidenciaTableAdapter = null;
            this.tableAdapterManager.ParteReparacionTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionHotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imagenHabitacionPictureBox
            // 
            this.imagenHabitacionPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.imagenHabitacionPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenHabitacionPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.habitacionBindingSource, "ImagenHabitacion", true));
            this.imagenHabitacionPictureBox.Location = new System.Drawing.Point(796, 92);
            this.imagenHabitacionPictureBox.Name = "imagenHabitacionPictureBox";
            this.imagenHabitacionPictureBox.Size = new System.Drawing.Size(314, 232);
            this.imagenHabitacionPictureBox.TabIndex = 5;
            this.imagenHabitacionPictureBox.TabStop = false;
            // 
            // imagenBanoPictureBox1
            // 
            this.imagenBanoPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.imagenBanoPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenBanoPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.habitacionBindingSource, "ImagenBano", true));
            this.imagenBanoPictureBox1.Location = new System.Drawing.Point(796, 359);
            this.imagenBanoPictureBox1.Name = "imagenBanoPictureBox1";
            this.imagenBanoPictureBox1.Size = new System.Drawing.Size(314, 232);
            this.imagenBanoPictureBox1.TabIndex = 21;
            this.imagenBanoPictureBox1.TabStop = false;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\AyudaHotel.chm";
            // 
            // HabitacionesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1293, 736);
            this.Controls.Add(this.buttonAyuda);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(imagenHabitacionLabel1);
            this.Controls.Add(this.imagenHabitacionPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(imagenBanoLabel);
            this.Controls.Add(this.imagenBanoPictureBox1);
            this.helpProvider1.SetHelpKeyword(this, "17");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "HabitacionesCliente";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Habitaciones Cliente";
            this.Load += new System.EventHandler(this.HabitacionesCliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroHuespedesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenHabitacionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBanoPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInicio;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnterior;
        private System.Windows.Forms.ToolStripLabel toolstripLabelContadorHabitaciones;
        private System.Windows.Forms.ToolStripButton toolStripButtonSiguiente;
        private System.Windows.Forms.ToolStripButton toolStripButtonFinal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonImprimir;
        private System.Windows.Forms.ToolStripButton toolStripButtonInforme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxBuscarHabitacion;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBuscar;
        private System.Windows.Forms.ToolStripButton toolStripButtonBuscar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAyuda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource habitacionBindingSource;
        private HotelDataSetTableAdapters.HabitacionTableAdapter habitacionTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idHabitacionLabel1;
        private System.Windows.Forms.ComboBox tipoHabitacionComboBox;
        private System.Windows.Forms.PictureBox imagenHabitacionPictureBox;
        private System.Windows.Forms.ComboBox banosComboBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.ComboBox tipoCamaComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox camaSupletoriaComboBox;
        private System.Windows.Forms.ComboBox desayunoComboBox;
        private System.Windows.Forms.PictureBox imagenBanoPictureBox1;
        private System.Windows.Forms.NumericUpDown numeroHuespedesNumericUpDown;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}