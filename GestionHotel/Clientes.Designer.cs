namespace GestionHotel
{
    partial class Clientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label imagenLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label estadoCivilLabel;
            System.Windows.Forms.Label cuentaCorrienteLabel;
            System.Windows.Forms.Label tipoClienteLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripLabelContadorClientes = new System.Windows.Forms.ToolStripLabel();
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
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.idLabel2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.buttonVolverInicio = new System.Windows.Forms.Button();
            this.estadoCivilComboBox = new System.Windows.Forms.ComboBox();
            this.tipoClienteComboBox = new System.Windows.Forms.ComboBox();
            this.provinciaComboBox = new System.Windows.Forms.ComboBox();
            this.cuentaCorrienteTextBox = new System.Windows.Forms.TextBox();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new GestionHotel.HotelDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new GestionHotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            estadoCivilLabel = new System.Windows.Forms.Label();
            cuentaCorrienteLabel = new System.Windows.Forms.Label();
            tipoClienteLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(31, 48);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(42, 22);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id *";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(31, 102);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(88, 22);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre *";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.BackColor = System.Drawing.Color.Transparent;
            apellidosLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidosLabel.Location = new System.Drawing.Point(32, 155);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(101, 22);
            apellidosLabel.TabIndex = 5;
            apellidosLabel.Text = "Apellidos *";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = System.Drawing.Color.Transparent;
            telefonoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(32, 329);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(79, 22);
            telefonoLabel.TabIndex = 7;
            telefonoLabel.Text = "Teléfono";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.BackColor = System.Drawing.Color.Transparent;
            fechaNacimientoLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaNacimientoLabel.Location = new System.Drawing.Point(31, 215);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(158, 20);
            fechaNacimientoLabel.TabIndex = 9;
            fechaNacimientoLabel.Text = "Fecha Nacimiento *";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.BackColor = System.Drawing.Color.Transparent;
            sexoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.Location = new System.Drawing.Point(32, 267);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(63, 22);
            sexoLabel.TabIndex = 11;
            sexoLabel.Text = "Sexo *";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.BackColor = System.Drawing.Color.Transparent;
            imagenLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imagenLabel.Location = new System.Drawing.Point(659, 386);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(70, 22);
            imagenLabel.TabIndex = 13;
            imagenLabel.Text = "Imagen";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.BackColor = System.Drawing.Color.Transparent;
            direccionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(21, 214);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(90, 22);
            direccionLabel.TabIndex = 15;
            direccionLabel.Text = "Dirección";
            // 
            // estadoCivilLabel
            // 
            estadoCivilLabel.AutoSize = true;
            estadoCivilLabel.BackColor = System.Drawing.Color.Transparent;
            estadoCivilLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoCivilLabel.Location = new System.Drawing.Point(32, 394);
            estadoCivilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoCivilLabel.Name = "estadoCivilLabel";
            estadoCivilLabel.Size = new System.Drawing.Size(126, 22);
            estadoCivilLabel.TabIndex = 22;
            estadoCivilLabel.Text = "Estado Civil *";
            // 
            // cuentaCorrienteLabel
            // 
            cuentaCorrienteLabel.AutoSize = true;
            cuentaCorrienteLabel.BackColor = System.Drawing.Color.Transparent;
            cuentaCorrienteLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cuentaCorrienteLabel.Location = new System.Drawing.Point(21, 102);
            cuentaCorrienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cuentaCorrienteLabel.Name = "cuentaCorrienteLabel";
            cuentaCorrienteLabel.Size = new System.Drawing.Size(151, 20);
            cuentaCorrienteLabel.TabIndex = 23;
            cuentaCorrienteLabel.Text = "Cuenta Corriente *";
            // 
            // tipoClienteLabel
            // 
            tipoClienteLabel.AutoSize = true;
            tipoClienteLabel.BackColor = System.Drawing.Color.Transparent;
            tipoClienteLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoClienteLabel.Location = new System.Drawing.Point(21, 50);
            tipoClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tipoClienteLabel.Name = "tipoClienteLabel";
            tipoClienteLabel.Size = new System.Drawing.Size(154, 22);
            tipoClienteLabel.TabIndex = 25;
            tipoClienteLabel.Text = "Tipo de  Cliente *";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.BackColor = System.Drawing.Color.Transparent;
            provinciaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            provinciaLabel.Location = new System.Drawing.Point(21, 156);
            provinciaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(104, 22);
            provinciaLabel.TabIndex = 26;
            provinciaLabel.Text = "Provincia *";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(235, 100);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(308, 27);
            this.nombreTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nombreTextBox, "Introduce el nombre del cliente");
            this.nombreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreTextBox_Validating);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Apellidos", true));
            this.apellidosTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosTextBox.Location = new System.Drawing.Point(235, 154);
            this.apellidosTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(308, 27);
            this.apellidosTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.apellidosTextBox, "Introduce el apellido del cliente");
            this.apellidosTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.apellidosTextBox_Validating);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(235, 329);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(308, 27);
            this.telefonoTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.telefonoTextBox, "El teléfono debe tener 9 dígitos");
            this.telefonoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telefonoTextBox_Validating);
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(235, 213);
            this.fechaNacimientoDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(308, 27);
            this.fechaNacimientoDateTimePicker.TabIndex = 3;
            this.toolTip1.SetToolTip(this.fechaNacimientoDateTimePicker, "Introduzca su fecha de nacimiento");
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
            this.toolstripLabelContadorClientes,
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
            this.toolStrip1.Size = new System.Drawing.Size(1293, 91);
            this.toolStrip1.TabIndex = 15;
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
            // toolstripLabelContadorClientes
            // 
            this.toolstripLabelContadorClientes.Name = "toolstripLabelContadorClientes";
            this.toolstripLabelContadorClientes.Size = new System.Drawing.Size(111, 88);
            this.toolstripLabelContadorClientes.Text = "toolStripLabel1";
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
            this.toolStripButtonAnadir.Click += new System.EventHandler(this.toolStripButtonAniadir_Click);
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminar.Image")));
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(29, 88);
            this.toolStripButtonEliminar.Text = "Eliminar";
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
            this.toolStripComboBoxBuscarClientes.Text = "Buscar cliente";
            this.toolStripComboBoxBuscarClientes.ToolTipText = "Seleccione mediante que campo desea buscar al cliente";
            // 
            // toolStripTextBoxBuscar
            // 
            this.toolStripTextBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxBuscar.Name = "toolStripTextBoxBuscar";
            this.toolStripTextBoxBuscar.Size = new System.Drawing.Size(100, 91);
            this.toolStripTextBoxBuscar.ToolTipText = "Escribe el cliente que desee buscar";
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
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(213, 213);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(308, 27);
            this.direccionTextBox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.direccionTextBox, "Introduce la dirección del cliente");
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAceptar.FlatAppearance.BorderSize = 0;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAceptar.Location = new System.Drawing.Point(779, 623);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(165, 70);
            this.buttonAceptar.TabIndex = 11;
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
            this.buttonCancelar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(1015, 623);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(169, 70);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonCancelar, "Aborta operación y limpia los datos");
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // idLabel2
            // 
            this.idLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Id", true));
            this.idLabel2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel2.Location = new System.Drawing.Point(231, 50);
            this.idLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel2.Name = "idLabel2";
            this.idLabel2.Size = new System.Drawing.Size(133, 28);
            this.idLabel2.TabIndex = 22;
            this.idLabel2.Text = "label1";
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.clienteBindingSource, "Sexo", true));
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "Sexo", true));
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexoComboBox.Location = new System.Drawing.Point(235, 267);
            this.sexoComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(308, 27);
            this.sexoComboBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.sexoComboBox, "Porfavor seleccione una opción (M o F)");
            // 
            // buttonVolverInicio
            // 
            this.buttonVolverInicio.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolverInicio.FlatAppearance.BorderSize = 0;
            this.buttonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverInicio.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolverInicio.Image")));
            this.buttonVolverInicio.Location = new System.Drawing.Point(1205, 95);
            this.buttonVolverInicio.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolverInicio.Name = "buttonVolverInicio";
            this.buttonVolverInicio.Size = new System.Drawing.Size(88, 68);
            this.buttonVolverInicio.TabIndex = 14;
            this.toolTip1.SetToolTip(this.buttonVolverInicio, "Volver a la ventana principal");
            this.buttonVolverInicio.UseVisualStyleBackColor = false;
            this.buttonVolverInicio.Click += new System.EventHandler(this.buttonVolverInicio_Click);
            // 
            // estadoCivilComboBox
            // 
            this.estadoCivilComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "EstadoCivil", true));
            this.estadoCivilComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoCivilComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCivilComboBox.FormattingEnabled = true;
            this.estadoCivilComboBox.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Separado",
            "Divorciado",
            "Viudo"});
            this.estadoCivilComboBox.Location = new System.Drawing.Point(235, 395);
            this.estadoCivilComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estadoCivilComboBox.Name = "estadoCivilComboBox";
            this.estadoCivilComboBox.Size = new System.Drawing.Size(308, 27);
            this.estadoCivilComboBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.estadoCivilComboBox, "Seleccione un estado civil de la lista");
            // 
            // tipoClienteComboBox
            // 
            this.tipoClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "TipoCliente", true));
            this.tipoClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoClienteComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoClienteComboBox.FormattingEnabled = true;
            this.tipoClienteComboBox.Items.AddRange(new object[] {
            "VIP",
            "Estándar"});
            this.tipoClienteComboBox.Location = new System.Drawing.Point(217, 51);
            this.tipoClienteComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoClienteComboBox.Name = "tipoClienteComboBox";
            this.tipoClienteComboBox.Size = new System.Drawing.Size(304, 27);
            this.tipoClienteComboBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.tipoClienteComboBox, "Seleccione el tipo de cliente de la lista");
            // 
            // provinciaComboBox
            // 
            this.provinciaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Provincia", true));
            this.provinciaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinciaComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinciaComboBox.FormattingEnabled = true;
            this.provinciaComboBox.Items.AddRange(new object[] {
            " Álava (Araba) (País Vasco, ES)",
            " Albacete (Castilla-La Mancha, ES)",
            " Alicante (Comunidad Valenciana, ES)",
            " Almería (Andalucía, ES)",
            " Asturias (Principado de Asturias, ES)",
            " Ávila (Castilla y León, ES)",
            " Badajoz (Extremadura, ES)",
            " Barcelona (Cataluña, ES)",
            " Burgos (Castilla y León, ES)",
            " Cáceres (Extremadura, ES)",
            " Cádiz (Andalucía, ES)",
            " Cantabria (Cantabria, ES)",
            " Castellón (Comunidad Valenciana, ES)",
            " Ciudad Real (Castilla-La Mancha, ES)",
            " Córdoba (Andalucía, ES)",
            " Cuenca (Castilla-La Mancha, ES)",
            " Gerona (Girona) (Cataluña, ES)",
            " Granada (Andalucía, ES)",
            " Guadalajara (Castilla-La Mancha, ES)",
            " Guipúzcoa (Gipuzkoa) (País Vasco, ES)",
            " Huelva (Andalucía, ES)",
            " Huesca (Aragon, ES)",
            " Islas Baleares (Islas Baleares, ES)",
            " Jaén (Andalucía, ES)",
            " La Coruña (A Coruña) (Galicia, ES)",
            " La Rioja (La Rioja, ES)",
            " Las Palmas (Canarias, ES)",
            " León (Castilla y León, ES)",
            " Lérida (Lleida) (Cataluña, ES)",
            " Lugo (Galicia, ES)",
            " Madrid (Comunidad de Madrid, ES)",
            " Málaga (Andalucía, ES)",
            " Murcia (Región de Murcia, ES)",
            " Navarra (Comunidad Foral de Navarra, ES)",
            " Orense (Ourense) (Galicia, ES)",
            " Palencia (Castilla y León, ES)",
            " Pontevedra (Galicia, ES)",
            " Salamanca (Castilla y León, ES)",
            " Santa Cruz de Tenerife (Canarias, ES)",
            " Segovia (Castilla y León, ES)",
            " Sevilla (Andalucía, ES)",
            " Soria (Castilla y León, ES)",
            " Tarragona (Cataluña, ES)",
            " Teruel (Aragon, ES)",
            " Toledo (Castilla-La Mancha, ES)",
            " Valencia (Comunidad Valenciana, ES)",
            " Valladolid (Castilla y León, ES)",
            " Vizcaya (Bizkaia) (País Vasco, ES)",
            " Zamora (Castilla y León, ES)",
            " Zaragoza (Aragon, ES)"});
            this.provinciaComboBox.Location = new System.Drawing.Point(213, 157);
            this.provinciaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.provinciaComboBox.Name = "provinciaComboBox";
            this.provinciaComboBox.Size = new System.Drawing.Size(308, 27);
            this.provinciaComboBox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.provinciaComboBox, "Seleccione una provincia de la lista");
            // 
            // cuentaCorrienteTextBox
            // 
            this.cuentaCorrienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CuentaCorriente", true));
            this.cuentaCorrienteTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuentaCorrienteTextBox.Location = new System.Drawing.Point(217, 102);
            this.cuentaCorrienteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cuentaCorrienteTextBox.Name = "cuentaCorrienteTextBox";
            this.cuentaCorrienteTextBox.Size = new System.Drawing.Size(305, 27);
            this.cuentaCorrienteTextBox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.cuentaCorrienteTextBox, "Debe introducir su número de cuenta adaptándose a este formato: ES12 1234 1234 12" +
        " 0123456789");
            this.cuentaCorrienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cuentaCorrienteTextBox_Validating);
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.imagenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagenPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "Imagen", true));
            this.imagenPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.ErrorImage")));
            this.imagenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.Image")));
            this.imagenPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.InitialImage")));
            this.imagenPictureBox.Location = new System.Drawing.Point(850, 386);
            this.imagenPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(305, 224);
            this.imagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPictureBox.TabIndex = 14;
            this.imagenPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.imagenPictureBox, "Haga clic para insertar una imágen");
            this.imagenPictureBox.Click += new System.EventHandler(this.imagenPictureBox_Click);
            // 
            // buttonAyuda
            // 
            this.buttonAyuda.BackColor = System.Drawing.Color.Transparent;
            this.buttonAyuda.FlatAppearance.BorderSize = 0;
            this.buttonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyuda.Image = ((System.Drawing.Image)(resources.GetObject("buttonAyuda.Image")));
            this.buttonAyuda.Location = new System.Drawing.Point(0, 634);
            this.buttonAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAyuda.Name = "buttonAyuda";
            this.buttonAyuda.Size = new System.Drawing.Size(69, 70);
            this.buttonAyuda.TabIndex = 13;
            this.toolTip1.SetToolTip(this.buttonAyuda, "Ayuda\r\n");
            this.buttonAyuda.UseVisualStyleBackColor = false;
            this.buttonAyuda.Click += new System.EventHandler(this.buttonAyuda_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.DetalleParteTableAdapter = null;
            this.tableAdapterManager.DetalleReservaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.HabitacionTableAdapter = null;
            this.tableAdapterManager.IncidenciaTableAdapter = null;
            this.tableAdapterManager.ParteReparacionTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionHotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idLabel2);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(this.estadoCivilComboBox);
            this.groupBox1.Controls.Add(this.apellidosTextBox);
            this.groupBox1.Controls.Add(fechaNacimientoLabel);
            this.groupBox1.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.groupBox1.Controls.Add(apellidosLabel);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(this.sexoComboBox);
            this.groupBox1.Controls.Add(sexoLabel);
            this.groupBox1.Controls.Add(estadoCivilLabel);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(564, 485);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(tipoClienteLabel);
            this.groupBox2.Controls.Add(cuentaCorrienteLabel);
            this.groupBox2.Controls.Add(this.provinciaComboBox);
            this.groupBox2.Controls.Add(this.cuentaCorrienteTextBox);
            this.groupBox2.Controls.Add(this.tipoClienteComboBox);
            this.groupBox2.Controls.Add(direccionLabel);
            this.groupBox2.Controls.Add(provinciaLabel);
            this.groupBox2.Controls.Add(this.direccionTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(637, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(547, 260);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de facturación";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1293, 26);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\AyudaHotel.chm";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1293, 737);
            this.Controls.Add(this.buttonAyuda);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonVolverInicio);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(imagenLabel);
            this.Controls.Add(this.imagenPictureBox);
            this.helpProvider1.SetHelpKeyword(this, "3");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Clientes_FormClosed);
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private HotelDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInicio;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnterior;
        private System.Windows.Forms.ToolStripLabel toolstripLabelContadorClientes;
        private System.Windows.Forms.ToolStripButton toolStripButtonSiguiente;
        private System.Windows.Forms.ToolStripButton toolStripButtonFinal;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnadir;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStripButton toolStripButtonBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxBuscarClientes;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBuscar;
        private System.Windows.Forms.Label idLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.Button buttonVolverInicio;
        private System.Windows.Forms.ComboBox estadoCivilComboBox;
        private System.Windows.Forms.ComboBox tipoClienteComboBox;
        private System.Windows.Forms.ComboBox provinciaComboBox;
        private System.Windows.Forms.TextBox cuentaCorrienteTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox imagenPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonAyuda;
        private System.Windows.Forms.ToolStripButton toolStripButtonImprimir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonInforme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

