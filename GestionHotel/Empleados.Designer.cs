namespace GestionHotel
{
    partial class Empleados
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
            System.Windows.Forms.Label idEmpleadoLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label imagenLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label cuentaBancariaLabel;
            System.Windows.Forms.Label direccion_Label;
            System.Windows.Forms.Label tiempoEnLaEmpresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonAyudaEmpleados = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.cuentaBancariaTextBox = new System.Windows.Forms.TextBox();
            this.direccion_TextBox = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.tiempoEnLaEmpresaComboBox = new System.Windows.Forms.ComboBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolstripLabelContadorEmpleados = new System.Windows.Forms.ToolStripLabel();
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
            this.toolStripComboBoxBuscarEmpleados = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBoxBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonBuscar = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.empleadoTableAdapter = new GestionHotel.HotelDataSetTableAdapters.EmpleadoTableAdapter();
            this.tableAdapterManager = new GestionHotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idEmpleadoLabel2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            idEmpleadoLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            cuentaBancariaLabel = new System.Windows.Forms.Label();
            direccion_Label = new System.Windows.Forms.Label();
            tiempoEnLaEmpresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idEmpleadoLabel
            // 
            idEmpleadoLabel.AutoSize = true;
            idEmpleadoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idEmpleadoLabel.Location = new System.Drawing.Point(23, 46);
            idEmpleadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idEmpleadoLabel.Name = "idEmpleadoLabel";
            idEmpleadoLabel.Size = new System.Drawing.Size(128, 22);
            idEmpleadoLabel.TabIndex = 5;
            idEmpleadoLabel.Text = "Id Empleado *";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dNILabel.Location = new System.Drawing.Point(23, 90);
            dNILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(59, 22);
            dNILabel.TabIndex = 7;
            dNILabel.Text = "DNI *";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(23, 142);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(88, 22);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre *";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidosLabel.Location = new System.Drawing.Point(23, 192);
            apellidosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(101, 22);
            apellidosLabel.TabIndex = 11;
            apellidosLabel.Text = "Apellidos *";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaNacimientoLabel.Location = new System.Drawing.Point(23, 238);
            fechaNacimientoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(158, 20);
            fechaNacimientoLabel.TabIndex = 13;
            fechaNacimientoLabel.Text = "Fecha Nacimiento *\r\n";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.Location = new System.Drawing.Point(23, 290);
            sexoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(63, 22);
            sexoLabel.TabIndex = 15;
            sexoLabel.Text = "Sexo *";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.BackColor = System.Drawing.Color.Transparent;
            imagenLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imagenLabel.Location = new System.Drawing.Point(641, 338);
            imagenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(70, 22);
            imagenLabel.TabIndex = 17;
            imagenLabel.Text = "Imagen";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(23, 341);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(84, 22);
            telefonoLabel.TabIndex = 19;
            telefonoLabel.Text = "Teléfono ";
            // 
            // cuentaBancariaLabel
            // 
            cuentaBancariaLabel.AutoSize = true;
            cuentaBancariaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cuentaBancariaLabel.Location = new System.Drawing.Point(21, 45);
            cuentaBancariaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cuentaBancariaLabel.Name = "cuentaBancariaLabel";
            cuentaBancariaLabel.Size = new System.Drawing.Size(163, 22);
            cuentaBancariaLabel.TabIndex = 21;
            cuentaBancariaLabel.Text = "Cuenta Bancaria *";
            // 
            // direccion_Label
            // 
            direccion_Label.AutoSize = true;
            direccion_Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccion_Label.Location = new System.Drawing.Point(21, 96);
            direccion_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccion_Label.Name = "direccion_Label";
            direccion_Label.Size = new System.Drawing.Size(90, 22);
            direccion_Label.TabIndex = 23;
            direccion_Label.Text = "Dirección";
            // 
            // tiempoEnLaEmpresaLabel
            // 
            tiempoEnLaEmpresaLabel.AutoSize = true;
            tiempoEnLaEmpresaLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tiempoEnLaEmpresaLabel.Location = new System.Drawing.Point(21, 163);
            tiempoEnLaEmpresaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tiempoEnLaEmpresaLabel.Name = "tiempoEnLaEmpresaLabel";
            tiempoEnLaEmpresaLabel.Size = new System.Drawing.Size(194, 20);
            tiempoEnLaEmpresaLabel.TabIndex = 23;
            tiempoEnLaEmpresaLabel.Text = "Tiempo En La Empresa *";
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolver.FlatAppearance.BorderSize = 0;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolver.Image")));
            this.buttonVolver.Location = new System.Drawing.Point(1232, 64);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 59);
            this.buttonVolver.TabIndex = 13;
            this.toolTip1.SetToolTip(this.buttonVolver, "Volver a la ventana principal");
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonAyudaEmpleados
            // 
            this.buttonAyudaEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.buttonAyudaEmpleados.FlatAppearance.BorderSize = 0;
            this.buttonAyudaEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyudaEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("buttonAyudaEmpleados.Image")));
            this.buttonAyudaEmpleados.Location = new System.Drawing.Point(0, 639);
            this.buttonAyudaEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAyudaEmpleados.Name = "buttonAyudaEmpleados";
            this.buttonAyudaEmpleados.Size = new System.Drawing.Size(73, 69);
            this.buttonAyudaEmpleados.TabIndex = 12;
            this.toolTip1.SetToolTip(this.buttonAyudaEmpleados, "Ayuda");
            this.buttonAyudaEmpleados.UseVisualStyleBackColor = false;
            this.buttonAyudaEmpleados.Click += new System.EventHandler(this.buttonAyudaEmpleados_Click);
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.imagenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagenPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.empleadoBindingSource, "Imagen", true));
            this.imagenPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.ErrorImage")));
            this.imagenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.Image")));
            this.imagenPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.InitialImage")));
            this.imagenPictureBox.Location = new System.Drawing.Point(892, 340);
            this.imagenPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(325, 238);
            this.imagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPictureBox.TabIndex = 18;
            this.imagenPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.imagenPictureBox, "Haga click para insertar la imagen");
            this.imagenPictureBox.Click += new System.EventHandler(this.imagenPictureBox_Click);
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
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "DNI", true));
            this.dNITextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dNITextBox.Location = new System.Drawing.Point(203, 87);
            this.dNITextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(335, 30);
            this.dNITextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dNITextBox, "Introduzca el DNI");
            this.dNITextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dNITextBox_Validating);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(203, 139);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(335, 30);
            this.nombreTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.nombreTextBox, "Introduce el nombre");
            this.nombreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreTextBox_Validating);
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Apellidos", true));
            this.apellidosTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosTextBox.Location = new System.Drawing.Point(203, 190);
            this.apellidosTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(335, 30);
            this.apellidosTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.apellidosTextBox, "Introduce los apellidos");
            this.apellidosTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.apellidosTextBox_Validating);
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empleadoBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(203, 236);
            this.fechaNacimientoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(335, 30);
            this.fechaNacimientoDateTimePicker.TabIndex = 4;
            this.toolTip1.SetToolTip(this.fechaNacimientoDateTimePicker, "Introduce la fecha de nacimiento");
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(203, 340);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(335, 30);
            this.telefonoTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.telefonoTextBox, "El teléfono debe tener 9 dígitos");
            this.telefonoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telefonoTextBox_Validating);
            // 
            // cuentaBancariaTextBox
            // 
            this.cuentaBancariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "CuentaBancaria", true));
            this.cuentaBancariaTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuentaBancariaTextBox.Location = new System.Drawing.Point(272, 44);
            this.cuentaBancariaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cuentaBancariaTextBox.Name = "cuentaBancariaTextBox";
            this.cuentaBancariaTextBox.Size = new System.Drawing.Size(295, 30);
            this.cuentaBancariaTextBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cuentaBancariaTextBox, "Debe introducir su número de cuenta adaptándose a este formato: ES12 1234 1234 12" +
        " 0123456789");
            this.cuentaBancariaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cuentaBancariaTextBox_Validating);
            // 
            // direccion_TextBox
            // 
            this.direccion_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Direccion", true));
            this.direccion_TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_TextBox.Location = new System.Drawing.Point(272, 99);
            this.direccion_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.direccion_TextBox.Name = "direccion_TextBox";
            this.direccion_TextBox.Size = new System.Drawing.Size(295, 30);
            this.direccion_TextBox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.direccion_TextBox, "Introduce la dirección del empleado ");
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAceptar.FlatAppearance.BorderSize = 0;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAceptar.Location = new System.Drawing.Point(763, 604);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(183, 80);
            this.buttonAceptar.TabIndex = 10;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonAceptar, "Valida los campos introducidos");
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(1008, 604);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(183, 80);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonCancelar, "Aborta operación y limpia los datos");
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // tiempoEnLaEmpresaComboBox
            // 
            this.tiempoEnLaEmpresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "TiempoEnLaEmpresa", true));
            this.tiempoEnLaEmpresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.empleadoBindingSource, "TiempoEnLaEmpresa", true));
            this.tiempoEnLaEmpresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empleadoBindingSource, "TiempoEnLaEmpresa", true));
            this.tiempoEnLaEmpresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tiempoEnLaEmpresaComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempoEnLaEmpresaComboBox.FormattingEnabled = true;
            this.tiempoEnLaEmpresaComboBox.Items.AddRange(new object[] {
            "<3",
            "3",
            "5",
            ">5"});
            this.tiempoEnLaEmpresaComboBox.Location = new System.Drawing.Point(272, 158);
            this.tiempoEnLaEmpresaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tiempoEnLaEmpresaComboBox.Name = "tiempoEnLaEmpresaComboBox";
            this.tiempoEnLaEmpresaComboBox.Size = new System.Drawing.Size(295, 30);
            this.tiempoEnLaEmpresaComboBox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.tiempoEnLaEmpresaComboBox, "Seleccione una opción de la lista");
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Sexo", true));
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.empleadoBindingSource, "Sexo", true));
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empleadoBindingSource, "Sexo", true));
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexoComboBox.Location = new System.Drawing.Point(203, 290);
            this.sexoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(335, 30);
            this.sexoComboBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.sexoComboBox, "Porfavor seleccione una opción (M o F)");
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInicio,
            this.toolStripButtonAnterior,
            this.toolstripLabelContadorEmpleados,
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
            this.toolStripComboBoxBuscarEmpleados,
            this.toolStripTextBoxBuscar,
            this.toolStripButtonBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1339, 28);
            this.toolStrip1.TabIndex = 2;
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
            // toolstripLabelContadorEmpleados
            // 
            this.toolstripLabelContadorEmpleados.Name = "toolstripLabelContadorEmpleados";
            this.toolstripLabelContadorEmpleados.Size = new System.Drawing.Size(111, 25);
            this.toolstripLabelContadorEmpleados.Text = "toolStripLabel1";
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
            this.toolStripButtonAnadir.ToolTipText = "Añadir empleado";
            this.toolStripButtonAnadir.Click += new System.EventHandler(this.toolStripButtonAnadir_Click);
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminar.Image")));
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonEliminar.ToolTipText = "Eliminar empleado";
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.toolStripButtonEliminar_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditar.Image")));
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonEditar.ToolTipText = "Editar empleado";
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
            // toolStripComboBoxBuscarEmpleados
            // 
            this.toolStripComboBoxBuscarEmpleados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBoxBuscarEmpleados.Items.AddRange(new object[] {
            "Id",
            "DNI",
            "Nombre"});
            this.toolStripComboBoxBuscarEmpleados.Name = "toolStripComboBoxBuscarEmpleados";
            this.toolStripComboBoxBuscarEmpleados.Size = new System.Drawing.Size(160, 28);
            this.toolStripComboBoxBuscarEmpleados.Text = "Buscar empleado";
            this.toolStripComboBoxBuscarEmpleados.ToolTipText = "Seleccione mediante que campo desea buscar al empleado";
            // 
            // toolStripTextBoxBuscar
            // 
            this.toolStripTextBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxBuscar.Name = "toolStripTextBoxBuscar";
            this.toolStripTextBoxBuscar.Size = new System.Drawing.Size(132, 28);
            this.toolStripTextBoxBuscar.ToolTipText = "Escribe el empleado que desee buscar";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 712);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1339, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.DetalleParteTableAdapter = null;
            this.tableAdapterManager.DetalleReservaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = this.empleadoTableAdapter;
            this.tableAdapterManager.HabitacionTableAdapter = null;
            this.tableAdapterManager.IncidenciaTableAdapter = null;
            this.tableAdapterManager.ParteReparacionTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionHotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(tiempoEnLaEmpresaLabel);
            this.groupBox1.Controls.Add(this.tiempoEnLaEmpresaComboBox);
            this.groupBox1.Controls.Add(cuentaBancariaLabel);
            this.groupBox1.Controls.Add(this.direccion_TextBox);
            this.groupBox1.Controls.Add(direccion_Label);
            this.groupBox1.Controls.Add(this.cuentaBancariaTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(620, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(597, 212);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de cobro";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.sexoComboBox);
            this.groupBox2.Controls.Add(this.idEmpleadoLabel2);
            this.groupBox2.Controls.Add(idEmpleadoLabel);
            this.groupBox2.Controls.Add(this.telefonoTextBox);
            this.groupBox2.Controls.Add(telefonoLabel);
            this.groupBox2.Controls.Add(dNILabel);
            this.groupBox2.Controls.Add(this.dNITextBox);
            this.groupBox2.Controls.Add(nombreLabel);
            this.groupBox2.Controls.Add(sexoLabel);
            this.groupBox2.Controls.Add(this.nombreTextBox);
            this.groupBox2.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.groupBox2.Controls.Add(apellidosLabel);
            this.groupBox2.Controls.Add(fechaNacimientoLabel);
            this.groupBox2.Controls.Add(this.apellidosTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(24, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(565, 412);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del empleado";
            // 
            // idEmpleadoLabel2
            // 
            this.idEmpleadoLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "IdEmpleado", true));
            this.idEmpleadoLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEmpleadoLabel2.Location = new System.Drawing.Point(196, 47);
            this.idEmpleadoLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idEmpleadoLabel2.Name = "idEmpleadoLabel2";
            this.idEmpleadoLabel2.Size = new System.Drawing.Size(133, 28);
            this.idEmpleadoLabel2.TabIndex = 21;
            this.idEmpleadoLabel2.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\AyudaHotel.chm";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1339, 738);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.imagenPictureBox);
            this.Controls.Add(this.buttonAyudaEmpleados);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(imagenLabel);
            this.helpProvider1.SetHelpKeyword(this, "4");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Empleados";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Empleados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Empleados_FormClosed);
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonAyudaEmpleados;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInicio;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnterior;
        private System.Windows.Forms.ToolStripButton toolStripButtonSiguiente;
        private System.Windows.Forms.ToolStripButton toolStripButtonFinal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnadir;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolstripLabelContadorEmpleados;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStripButton toolStripButtonImprimir;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxBuscarEmpleados;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBuscar;
        private System.Windows.Forms.ToolStripButton toolStripButtonBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private HotelDataSet hotelDataSet;
        private HotelDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.PictureBox imagenPictureBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox direccion_TextBox;
        private System.Windows.Forms.TextBox cuentaBancariaTextBox;
        private System.Windows.Forms.Label idEmpleadoLabel2;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInforme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.ComboBox tiempoEnLaEmpresaComboBox;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}