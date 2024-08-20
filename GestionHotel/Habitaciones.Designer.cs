namespace GestionHotel
{
    partial class Habitaciones
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
            System.Windows.Forms.Label imagenHabitacionLabel;
            System.Windows.Forms.Label numeroHuespedesLabel;
            System.Windows.Forms.Label banosLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label tipoCamaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label camaSupletoriaLabel;
            System.Windows.Forms.Label desayunoLabel;
            System.Windows.Forms.Label imagenBanoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Habitaciones));
            this.buttonVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numeroHuespedesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.habitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.idHabitacionLabel2 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.tipoHabitacionComboBox = new System.Windows.Forms.ComboBox();
            this.banosComboBox = new System.Windows.Forms.ComboBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoCamaComboBox = new System.Windows.Forms.ComboBox();
            this.camaSupletoriaComboBox = new System.Windows.Forms.ComboBox();
            this.desayunoComboBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolstripLabelContadorHabitaciones = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonSiguiente = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFinal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAnadir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInforme = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxBuscarHabitacion = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBoxBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonBuscar = new System.Windows.Forms.ToolStripButton();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imagenHabitacionPictureBox = new System.Windows.Forms.PictureBox();
            this.imagenBanoPictureBox1 = new System.Windows.Forms.PictureBox();
            this.habitacionTableAdapter = new GestionHotel.HotelDataSetTableAdapters.HabitacionTableAdapter();
            this.tableAdapterManager = new GestionHotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            idHabitacionLabel = new System.Windows.Forms.Label();
            tipoHabitacionLabel = new System.Windows.Forms.Label();
            imagenHabitacionLabel = new System.Windows.Forms.Label();
            numeroHuespedesLabel = new System.Windows.Forms.Label();
            banosLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            tipoCamaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            camaSupletoriaLabel = new System.Windows.Forms.Label();
            desayunoLabel = new System.Windows.Forms.Label();
            imagenBanoLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroHuespedesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenHabitacionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBanoPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idHabitacionLabel
            // 
            idHabitacionLabel.AutoSize = true;
            idHabitacionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idHabitacionLabel.Location = new System.Drawing.Point(27, 46);
            idHabitacionLabel.Name = "idHabitacionLabel";
            idHabitacionLabel.Size = new System.Drawing.Size(138, 22);
            idHabitacionLabel.TabIndex = 0;
            idHabitacionLabel.Text = "Id Habitación *";
            // 
            // tipoHabitacionLabel
            // 
            tipoHabitacionLabel.AutoSize = true;
            tipoHabitacionLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoHabitacionLabel.Location = new System.Drawing.Point(27, 94);
            tipoHabitacionLabel.Name = "tipoHabitacionLabel";
            tipoHabitacionLabel.Size = new System.Drawing.Size(166, 20);
            tipoHabitacionLabel.TabIndex = 2;
            tipoHabitacionLabel.Text = "Tipo de Habitación *\r\n";
            // 
            // imagenHabitacionLabel
            // 
            imagenHabitacionLabel.AutoSize = true;
            imagenHabitacionLabel.BackColor = System.Drawing.Color.Transparent;
            imagenHabitacionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imagenHabitacionLabel.Location = new System.Drawing.Point(583, 94);
            imagenHabitacionLabel.Name = "imagenHabitacionLabel";
            imagenHabitacionLabel.Size = new System.Drawing.Size(166, 22);
            imagenHabitacionLabel.TabIndex = 4;
            imagenHabitacionLabel.Text = "Imagen Habitación";
            // 
            // numeroHuespedesLabel
            // 
            numeroHuespedesLabel.AutoSize = true;
            numeroHuespedesLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroHuespedesLabel.Location = new System.Drawing.Point(27, 262);
            numeroHuespedesLabel.Name = "numeroHuespedesLabel";
            numeroHuespedesLabel.Size = new System.Drawing.Size(190, 20);
            numeroHuespedesLabel.TabIndex = 6;
            numeroHuespedesLabel.Text = "Número de  Huéspedes *\r\n";
            // 
            // banosLabel
            // 
            banosLabel.AutoSize = true;
            banosLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            banosLabel.Location = new System.Drawing.Point(27, 441);
            banosLabel.Name = "banosLabel";
            banosLabel.Size = new System.Drawing.Size(67, 22);
            banosLabel.TabIndex = 8;
            banosLabel.Text = "Baño *";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(27, 212);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(81, 22);
            estadoLabel.TabIndex = 10;
            estadoLabel.Text = "Estado *";
            // 
            // tipoCamaLabel
            // 
            tipoCamaLabel.AutoSize = true;
            tipoCamaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoCamaLabel.Location = new System.Drawing.Point(27, 318);
            tipoCamaLabel.Name = "tipoCamaLabel";
            tipoCamaLabel.Size = new System.Drawing.Size(137, 22);
            tipoCamaLabel.TabIndex = 12;
            tipoCamaLabel.Text = "Tipo de Cama *\r\n";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(27, 151);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(114, 44);
            descripcionLabel.TabIndex = 14;
            descripcionLabel.Text = "Descripción \r\n\r\n";
            // 
            // camaSupletoriaLabel
            // 
            camaSupletoriaLabel.AutoSize = true;
            camaSupletoriaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            camaSupletoriaLabel.Location = new System.Drawing.Point(27, 382);
            camaSupletoriaLabel.Name = "camaSupletoriaLabel";
            camaSupletoriaLabel.Size = new System.Drawing.Size(162, 22);
            camaSupletoriaLabel.TabIndex = 16;
            camaSupletoriaLabel.Text = "Cama Supletoria *";
            // 
            // desayunoLabel
            // 
            desayunoLabel.AutoSize = true;
            desayunoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            desayunoLabel.Location = new System.Drawing.Point(27, 507);
            desayunoLabel.Name = "desayunoLabel";
            desayunoLabel.Size = new System.Drawing.Size(105, 22);
            desayunoLabel.TabIndex = 18;
            desayunoLabel.Text = "Desayuno *";
            // 
            // imagenBanoLabel1
            // 
            imagenBanoLabel1.AutoSize = true;
            imagenBanoLabel1.BackColor = System.Drawing.Color.Transparent;
            imagenBanoLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imagenBanoLabel1.Location = new System.Drawing.Point(583, 354);
            imagenBanoLabel1.Name = "imagenBanoLabel1";
            imagenBanoLabel1.Size = new System.Drawing.Size(117, 22);
            imagenBanoLabel1.TabIndex = 20;
            imagenBanoLabel1.Text = "Imagen Baño";
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolver.FlatAppearance.BorderSize = 0;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolver.Image")));
            this.buttonVolver.Location = new System.Drawing.Point(1169, 82);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 60);
            this.buttonVolver.TabIndex = 11;
            this.toolTip1.SetToolTip(this.buttonVolver, "Volver a la ventana principal");
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.numeroHuespedesNumericUpDown);
            this.groupBox1.Controls.Add(this.idHabitacionLabel2);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(idHabitacionLabel);
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
            this.groupBox1.Controls.Add(camaSupletoriaLabel);
            this.groupBox1.Controls.Add(this.camaSupletoriaComboBox);
            this.groupBox1.Controls.Add(desayunoLabel);
            this.groupBox1.Controls.Add(this.desayunoComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(535, 551);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la habitación";
            // 
            // numeroHuespedesNumericUpDown
            // 
            this.numeroHuespedesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.habitacionBindingSource, "NumeroHuespedes", true));
            this.numeroHuespedesNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroHuespedesNumericUpDown.Location = new System.Drawing.Point(249, 260);
            this.numeroHuespedesNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeroHuespedesNumericUpDown.Name = "numeroHuespedesNumericUpDown";
            this.numeroHuespedesNumericUpDown.Size = new System.Drawing.Size(265, 30);
            this.numeroHuespedesNumericUpDown.TabIndex = 4;
            this.numeroHuespedesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // idHabitacionLabel2
            // 
            this.idHabitacionLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "IdHabitacion", true));
            this.idHabitacionLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idHabitacionLabel2.Location = new System.Drawing.Point(249, 44);
            this.idHabitacionLabel2.Name = "idHabitacionLabel2";
            this.idHabitacionLabel2.Size = new System.Drawing.Size(100, 23);
            this.idHabitacionLabel2.TabIndex = 21;
            this.idHabitacionLabel2.Text = "label1";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "Descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(249, 148);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(265, 50);
            this.descripcionTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.descripcionTextBox, "Introduce la descripción de la habitación");
            // 
            // tipoHabitacionComboBox
            // 
            this.tipoHabitacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "TipoHabitacion", true));
            this.tipoHabitacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.habitacionBindingSource, "TipoHabitacion", true));
            this.tipoHabitacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.habitacionBindingSource, "TipoHabitacion", true));
            this.tipoHabitacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoHabitacionComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoHabitacionComboBox.FormattingEnabled = true;
            this.tipoHabitacionComboBox.Items.AddRange(new object[] {
            "Privada",
            "Compartida",
            "Suite"});
            this.tipoHabitacionComboBox.Location = new System.Drawing.Point(249, 91);
            this.tipoHabitacionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoHabitacionComboBox.Name = "tipoHabitacionComboBox";
            this.tipoHabitacionComboBox.Size = new System.Drawing.Size(265, 30);
            this.tipoHabitacionComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tipoHabitacionComboBox, "Seleccione una opción de la lista");
            // 
            // banosComboBox
            // 
            this.banosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "Banos", true));
            this.banosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.habitacionBindingSource, "Banos", true));
            this.banosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.habitacionBindingSource, "Banos", true));
            this.banosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banosComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banosComboBox.FormattingEnabled = true;
            this.banosComboBox.Items.AddRange(new object[] {
            "Privado",
            "Compartido"});
            this.banosComboBox.Location = new System.Drawing.Point(249, 441);
            this.banosComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.banosComboBox.Name = "banosComboBox";
            this.banosComboBox.Size = new System.Drawing.Size(265, 30);
            this.banosComboBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.banosComboBox, "Seleccione una opción de la lista");
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "Estado", true));
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.habitacionBindingSource, "Estado", true));
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.habitacionBindingSource, "Estado", true));
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Libre",
            "Ocupada"});
            this.estadoComboBox.Location = new System.Drawing.Point(249, 209);
            this.estadoComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(265, 30);
            this.estadoComboBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.estadoComboBox, "Seleccione una opción de la lista");
            // 
            // tipoCamaComboBox
            // 
            this.tipoCamaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "TipoCama", true));
            this.tipoCamaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.habitacionBindingSource, "TipoCama", true));
            this.tipoCamaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.habitacionBindingSource, "TipoCama", true));
            this.tipoCamaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoCamaComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoCamaComboBox.FormattingEnabled = true;
            this.tipoCamaComboBox.Items.AddRange(new object[] {
            "Matrimonio",
            "Individual"});
            this.tipoCamaComboBox.Location = new System.Drawing.Point(249, 318);
            this.tipoCamaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoCamaComboBox.Name = "tipoCamaComboBox";
            this.tipoCamaComboBox.Size = new System.Drawing.Size(265, 30);
            this.tipoCamaComboBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tipoCamaComboBox, "Seleccione una opción de la lista");
            // 
            // camaSupletoriaComboBox
            // 
            this.camaSupletoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "CamaSupletoria", true));
            this.camaSupletoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.habitacionBindingSource, "CamaSupletoria", true));
            this.camaSupletoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.habitacionBindingSource, "CamaSupletoria", true));
            this.camaSupletoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camaSupletoriaComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camaSupletoriaComboBox.FormattingEnabled = true;
            this.camaSupletoriaComboBox.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.camaSupletoriaComboBox.Location = new System.Drawing.Point(249, 382);
            this.camaSupletoriaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.camaSupletoriaComboBox.Name = "camaSupletoriaComboBox";
            this.camaSupletoriaComboBox.Size = new System.Drawing.Size(265, 30);
            this.camaSupletoriaComboBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.camaSupletoriaComboBox, "Seleccione una opción de la lista");
            // 
            // desayunoComboBox
            // 
            this.desayunoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "Desayuno", true));
            this.desayunoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.habitacionBindingSource, "Desayuno", true));
            this.desayunoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.habitacionBindingSource, "Desayuno", true));
            this.desayunoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desayunoComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desayunoComboBox.FormattingEnabled = true;
            this.desayunoComboBox.Items.AddRange(new object[] {
            "Incluido",
            "No incluido"});
            this.desayunoComboBox.Location = new System.Drawing.Point(249, 505);
            this.desayunoComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desayunoComboBox.Name = "desayunoComboBox";
            this.desayunoComboBox.Size = new System.Drawing.Size(265, 30);
            this.desayunoComboBox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.desayunoComboBox, "Seleccione una opción de la lista");
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
            this.toolStripButtonAnadir,
            this.toolStripButtonEliminar,
            this.toolStripButtonEditar,
            this.toolStripSeparator2,
            this.toolStripButtonGuardar,
            this.toolStripButtonImprimir,
            this.toolStripButtonInforme,
            this.toolStripSeparator3,
            this.toolStripComboBoxBuscarHabitacion,
            this.toolStripTextBoxBuscar,
            this.toolStripButtonBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1293, 28);
            this.toolStrip1.TabIndex = 19;
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
            // toolStripButtonAnadir
            // 
            this.toolStripButtonAnadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAnadir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAnadir.Image")));
            this.toolStripButtonAnadir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnadir.Name = "toolStripButtonAnadir";
            this.toolStripButtonAnadir.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonAnadir.ToolTipText = "Añadir habitación";
            this.toolStripButtonAnadir.Click += new System.EventHandler(this.toolStripButtonAnadir_Click);
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminar.Image")));
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonEliminar.ToolTipText = "Eliminar habitación";
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.toolStripButtonEliminar_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditar.Image")));
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonEditar.ToolTipText = "Editar habitación";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonGuardar
            // 
            this.toolStripButtonGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuardar.Image")));
            this.toolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuardar.Name = "toolStripButtonGuardar";
            this.toolStripButtonGuardar.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonGuardar.ToolTipText = "Guardar ";
            this.toolStripButtonGuardar.Click += new System.EventHandler(this.toolStripButtonGuardar_Click);
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
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(1053, 622);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(169, 70);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.buttonAceptar.Location = new System.Drawing.Point(759, 622);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(165, 70);
            this.buttonAceptar.TabIndex = 9;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 714);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1293, 26);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // imagenHabitacionPictureBox
            // 
            this.imagenHabitacionPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.imagenHabitacionPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenHabitacionPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagenHabitacionPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.habitacionBindingSource, "ImagenHabitacion", true));
            this.imagenHabitacionPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imagenHabitacionPictureBox.ErrorImage")));
            this.imagenHabitacionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagenHabitacionPictureBox.Image")));
            this.imagenHabitacionPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imagenHabitacionPictureBox.InitialImage")));
            this.imagenHabitacionPictureBox.Location = new System.Drawing.Point(765, 94);
            this.imagenHabitacionPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagenHabitacionPictureBox.Name = "imagenHabitacionPictureBox";
            this.imagenHabitacionPictureBox.Size = new System.Drawing.Size(314, 232);
            this.imagenHabitacionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenHabitacionPictureBox.TabIndex = 5;
            this.imagenHabitacionPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.imagenHabitacionPictureBox, "Haga click para insertar la imagen");
            this.imagenHabitacionPictureBox.Click += new System.EventHandler(this.imagenHabitacionPictureBox_Click);
            // 
            // imagenBanoPictureBox1
            // 
            this.imagenBanoPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.imagenBanoPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenBanoPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagenBanoPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.habitacionBindingSource, "ImagenBano", true));
            this.imagenBanoPictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imagenBanoPictureBox1.ErrorImage")));
            this.imagenBanoPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("imagenBanoPictureBox1.Image")));
            this.imagenBanoPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("imagenBanoPictureBox1.InitialImage")));
            this.imagenBanoPictureBox1.Location = new System.Drawing.Point(765, 354);
            this.imagenBanoPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagenBanoPictureBox1.Name = "imagenBanoPictureBox1";
            this.imagenBanoPictureBox1.Size = new System.Drawing.Size(314, 232);
            this.imagenBanoPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenBanoPictureBox1.TabIndex = 21;
            this.imagenBanoPictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.imagenBanoPictureBox1, "Haga click para insertar la imagen");
            this.imagenBanoPictureBox1.Click += new System.EventHandler(this.imagenBanoPictureBox1_Click);
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
            // buttonAyuda
            // 
            this.buttonAyuda.BackColor = System.Drawing.Color.Transparent;
            this.buttonAyuda.FlatAppearance.BorderSize = 0;
            this.buttonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyuda.Image = ((System.Drawing.Image)(resources.GetObject("buttonAyuda.Image")));
            this.buttonAyuda.Location = new System.Drawing.Point(0, 639);
            this.buttonAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAyuda.Name = "buttonAyuda";
            this.buttonAyuda.Size = new System.Drawing.Size(75, 64);
            this.buttonAyuda.TabIndex = 12;
            this.toolTip1.SetToolTip(this.buttonAyuda, "Ayuda");
            this.buttonAyuda.UseVisualStyleBackColor = false;
            this.buttonAyuda.Click += new System.EventHandler(this.buttonAyuda_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\AyudaHotel.chm";
            // 
            // Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1293, 740);
            this.Controls.Add(this.buttonAyuda);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(imagenHabitacionLabel);
            this.Controls.Add(this.imagenHabitacionPictureBox);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(imagenBanoLabel1);
            this.Controls.Add(this.imagenBanoPictureBox1);
            this.helpProvider1.SetHelpKeyword(this, "6");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Habitaciones";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Habitaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Habitaciones_FormClosed);
            this.Load += new System.EventHandler(this.Habitaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroHuespedesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenHabitacionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBanoPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource habitacionBindingSource;
        private HotelDataSetTableAdapters.HabitacionTableAdapter habitacionTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInicio;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnterior;
        private System.Windows.Forms.ToolStripLabel toolstripLabelContadorHabitaciones;
        private System.Windows.Forms.ToolStripButton toolStripButtonSiguiente;
        private System.Windows.Forms.ToolStripButton toolStripButtonFinal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnadir;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStripButton toolStripButtonImprimir;
        private System.Windows.Forms.ToolStripButton toolStripButtonInforme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxBuscarHabitacion;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBuscar;
        private System.Windows.Forms.ToolStripButton toolStripButtonBuscar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox tipoHabitacionComboBox;
        private System.Windows.Forms.ComboBox banosComboBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.ComboBox tipoCamaComboBox;
        private System.Windows.Forms.ComboBox camaSupletoriaComboBox;
        private System.Windows.Forms.ComboBox desayunoComboBox;
        private System.Windows.Forms.PictureBox imagenHabitacionPictureBox;
        private System.Windows.Forms.PictureBox imagenBanoPictureBox1;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label idHabitacionLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonAyuda;
        private System.Windows.Forms.NumericUpDown numeroHuespedesNumericUpDown;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}