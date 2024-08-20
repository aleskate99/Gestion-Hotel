namespace GestionHotel
{
    partial class Login
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
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usuarioAccederTextBox = new System.Windows.Forms.TextBox();
            this.passwordAccederTextBox = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonMostrasPassRegistro = new System.Windows.Forms.Button();
            this.buttonMostrarPassAcceder = new System.Windows.Forms.Button();
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.buttonAcceder = new System.Windows.Forms.Button();
            this.textBoxUsuarioRegistro = new System.Windows.Forms.TextBox();
            this.textBoxPassRegistro = new System.Windows.Forms.TextBox();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.groupBoxAcceder = new System.Windows.Forms.GroupBox();
            this.groupBoxRegistrarse = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.hotelDataSet = new GestionHotel.HotelDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new GestionHotel.HotelDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new GestionHotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.empleadoTableAdapter = new GestionHotel.HotelDataSetTableAdapters.EmpleadoTableAdapter();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            usuarioLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            this.groupBoxAcceder.SuspendLayout();
            this.groupBoxRegistrarse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.BackColor = System.Drawing.Color.Transparent;
            usuarioLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(177, 66);
            usuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(105, 29);
            usuarioLabel.TabIndex = 1;
            usuarioLabel.Text = "Usuario:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = System.Drawing.Color.Transparent;
            passwordLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(177, 167);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(123, 29);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(149, 66);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 29);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(149, 164);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(123, 29);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // usuarioAccederTextBox
            // 
            this.usuarioAccederTextBox.Location = new System.Drawing.Point(315, 73);
            this.usuarioAccederTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usuarioAccederTextBox.Name = "usuarioAccederTextBox";
            this.usuarioAccederTextBox.Size = new System.Drawing.Size(200, 22);
            this.usuarioAccederTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.usuarioAccederTextBox, "Introduzca su nombre de usuario");
            this.usuarioAccederTextBox.Validated += new System.EventHandler(this.usuarioAccederTextBox_Validated);
            // 
            // passwordAccederTextBox
            // 
            this.passwordAccederTextBox.Location = new System.Drawing.Point(315, 174);
            this.passwordAccederTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordAccederTextBox.Name = "passwordAccederTextBox";
            this.passwordAccederTextBox.Size = new System.Drawing.Size(200, 22);
            this.passwordAccederTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.passwordAccederTextBox, "Introduzca su contraseña ");
            this.passwordAccederTextBox.UseSystemPasswordChar = true;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEntrar.FlatAppearance.BorderSize = 0;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEntrar.Image")));
            this.buttonEntrar.Location = new System.Drawing.Point(1083, 619);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(100, 89);
            this.buttonEntrar.TabIndex = 17;
            this.toolTip1.SetToolTip(this.buttonEntrar, "Acceder");
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // buttonMostrasPassRegistro
            // 
            this.buttonMostrasPassRegistro.FlatAppearance.BorderSize = 0;
            this.buttonMostrasPassRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrasPassRegistro.Image = ((System.Drawing.Image)(resources.GetObject("buttonMostrasPassRegistro.Image")));
            this.buttonMostrasPassRegistro.Location = new System.Drawing.Point(507, 166);
            this.buttonMostrasPassRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMostrasPassRegistro.Name = "buttonMostrasPassRegistro";
            this.buttonMostrasPassRegistro.Size = new System.Drawing.Size(44, 30);
            this.buttonMostrasPassRegistro.TabIndex = 17;
            this.toolTip1.SetToolTip(this.buttonMostrasPassRegistro, "Mostrar contraseña");
            this.buttonMostrasPassRegistro.UseVisualStyleBackColor = true;
            this.buttonMostrasPassRegistro.Click += new System.EventHandler(this.buttonMostrasPassRegistro_Click);
            // 
            // buttonMostrarPassAcceder
            // 
            this.buttonMostrarPassAcceder.BackColor = System.Drawing.Color.Transparent;
            this.buttonMostrarPassAcceder.FlatAppearance.BorderSize = 0;
            this.buttonMostrarPassAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarPassAcceder.Image = ((System.Drawing.Image)(resources.GetObject("buttonMostrarPassAcceder.Image")));
            this.buttonMostrarPassAcceder.Location = new System.Drawing.Point(523, 158);
            this.buttonMostrarPassAcceder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMostrarPassAcceder.Name = "buttonMostrarPassAcceder";
            this.buttonMostrarPassAcceder.Size = new System.Drawing.Size(48, 49);
            this.buttonMostrarPassAcceder.TabIndex = 18;
            this.toolTip1.SetToolTip(this.buttonMostrarPassAcceder, "Mostrar contraseña");
            this.buttonMostrarPassAcceder.UseVisualStyleBackColor = false;
            this.buttonMostrarPassAcceder.Click += new System.EventHandler(this.buttonMostrarPassAcceder_Click);
            // 
            // buttonAyuda
            // 
            this.buttonAyuda.BackColor = System.Drawing.Color.Transparent;
            this.buttonAyuda.FlatAppearance.BorderSize = 0;
            this.buttonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpProvider1.SetHelpKeyword(this.buttonAyuda, "1");
            this.helpProvider1.SetHelpNavigator(this.buttonAyuda, System.Windows.Forms.HelpNavigator.TopicId);
            this.helpProvider1.SetHelpString(this.buttonAyuda, "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\bin\\Debug\\HotelAyuda.chm");
            this.buttonAyuda.Image = ((System.Drawing.Image)(resources.GetObject("buttonAyuda.Image")));
            this.buttonAyuda.Location = new System.Drawing.Point(2, 670);
            this.buttonAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAyuda.Name = "buttonAyuda";
            this.helpProvider1.SetShowHelp(this.buttonAyuda, true);
            this.buttonAyuda.Size = new System.Drawing.Size(75, 64);
            this.buttonAyuda.TabIndex = 7;
            this.toolTip1.SetToolTip(this.buttonAyuda, "Pulse F1 para abrir ayuda");
            this.buttonAyuda.UseVisualStyleBackColor = false;
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuario.Image = ((System.Drawing.Image)(resources.GetObject("buttonUsuario.Image")));
            this.buttonUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsuario.Location = new System.Drawing.Point(404, 94);
            this.buttonUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(195, 86);
            this.buttonUsuario.TabIndex = 10;
            this.buttonUsuario.Text = "Usuario";
            this.buttonUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonUsuario, "Cliente");
            this.buttonUsuario.UseVisualStyleBackColor = true;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.Image")));
            this.buttonAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdmin.Location = new System.Drawing.Point(639, 94);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(195, 86);
            this.buttonAdmin.TabIndex = 11;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonAdmin, "Administrador");
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.Location = new System.Drawing.Point(903, 94);
            this.buttonRegistrarse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(100, 28);
            this.buttonRegistrarse.TabIndex = 13;
            this.buttonRegistrarse.Text = "Registrarse";
            this.toolTip1.SetToolTip(this.buttonRegistrarse, "Registrarse");
            this.buttonRegistrarse.UseVisualStyleBackColor = true;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // buttonAcceder
            // 
            this.buttonAcceder.Location = new System.Drawing.Point(903, 153);
            this.buttonAcceder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAcceder.Name = "buttonAcceder";
            this.buttonAcceder.Size = new System.Drawing.Size(100, 28);
            this.buttonAcceder.TabIndex = 14;
            this.buttonAcceder.Text = "Acceder";
            this.toolTip1.SetToolTip(this.buttonAcceder, "Acceder");
            this.buttonAcceder.UseVisualStyleBackColor = true;
            this.buttonAcceder.Click += new System.EventHandler(this.buttonAcceder_Click);
            // 
            // textBoxUsuarioRegistro
            // 
            this.textBoxUsuarioRegistro.Location = new System.Drawing.Point(287, 73);
            this.textBoxUsuarioRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuarioRegistro.Name = "textBoxUsuarioRegistro";
            this.textBoxUsuarioRegistro.Size = new System.Drawing.Size(200, 22);
            this.textBoxUsuarioRegistro.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxUsuarioRegistro, "Introduzca el nombre para registrarse");
            this.textBoxUsuarioRegistro.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUsuarioRegistro_Validating);
            this.textBoxUsuarioRegistro.Validated += new System.EventHandler(this.textBoxUsuarioRegistro_Validated);
            // 
            // textBoxPassRegistro
            // 
            this.textBoxPassRegistro.Location = new System.Drawing.Point(287, 170);
            this.textBoxPassRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassRegistro.Name = "textBoxPassRegistro";
            this.textBoxPassRegistro.Size = new System.Drawing.Size(200, 22);
            this.textBoxPassRegistro.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxPassRegistro, "Introduzca una contraseña (Al menos 8 dígitos entre ellos 1 número y 1 mayúscula)" +
        "");
            this.textBoxPassRegistro.UseSystemPasswordChar = true;
            this.textBoxPassRegistro.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassRegistro_Validating);
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.Color.Transparent;
            this.buttonAtras.FlatAppearance.BorderSize = 0;
            this.buttonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtras.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtras.Image")));
            this.buttonAtras.Location = new System.Drawing.Point(1199, 94);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 53);
            this.buttonAtras.TabIndex = 18;
            this.toolTip1.SetToolTip(this.buttonAtras, "Volver al inicio");
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 90);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.Image")));
            this.pictureBoxPassword.Location = new System.Drawing.Point(36, 132);
            this.pictureBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(96, 90);
            this.pictureBoxPassword.TabIndex = 9;
            this.pictureBoxPassword.TabStop = false;
            // 
            // groupBoxAcceder
            // 
            this.groupBoxAcceder.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAcceder.Controls.Add(this.buttonMostrarPassAcceder);
            this.groupBoxAcceder.Controls.Add(this.pictureBox1);
            this.groupBoxAcceder.Controls.Add(this.usuarioAccederTextBox);
            this.groupBoxAcceder.Controls.Add(usuarioLabel);
            this.groupBoxAcceder.Controls.Add(this.pictureBoxPassword);
            this.groupBoxAcceder.Controls.Add(this.passwordAccederTextBox);
            this.groupBoxAcceder.Controls.Add(passwordLabel);
            this.groupBoxAcceder.Location = new System.Drawing.Point(653, 286);
            this.groupBoxAcceder.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAcceder.Name = "groupBoxAcceder";
            this.groupBoxAcceder.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAcceder.Size = new System.Drawing.Size(593, 258);
            this.groupBoxAcceder.TabIndex = 12;
            this.groupBoxAcceder.TabStop = false;
            this.groupBoxAcceder.Text = "Acceder";
            // 
            // groupBoxRegistrarse
            // 
            this.groupBoxRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRegistrarse.Controls.Add(this.buttonMostrasPassRegistro);
            this.groupBoxRegistrarse.Controls.Add(this.pictureBox2);
            this.groupBoxRegistrarse.Controls.Add(this.textBoxUsuarioRegistro);
            this.groupBoxRegistrarse.Controls.Add(label1);
            this.groupBoxRegistrarse.Controls.Add(this.pictureBox3);
            this.groupBoxRegistrarse.Controls.Add(this.textBoxPassRegistro);
            this.groupBoxRegistrarse.Controls.Add(label2);
            this.groupBoxRegistrarse.Location = new System.Drawing.Point(29, 286);
            this.groupBoxRegistrarse.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRegistrarse.Name = "groupBoxRegistrarse";
            this.groupBoxRegistrarse.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRegistrarse.Size = new System.Drawing.Size(571, 258);
            this.groupBoxRegistrarse.TabIndex = 15;
            this.groupBoxRegistrarse.TabStop = false;
            this.groupBoxRegistrarse.Text = "Registrarse";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 92);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(36, 134);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 87);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "AyudaHotel.chm";
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.hotelDataSet;
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
            this.tableAdapterManager.EmpleadoTableAdapter = this.empleadoTableAdapter;
            this.tableAdapterManager.HabitacionTableAdapter = null;
            this.tableAdapterManager.IncidenciaTableAdapter = null;
            this.tableAdapterManager.ParteReparacionTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.ServiciosExtraTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionHotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.hotelDataSet;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1299, 736);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.buttonAyuda);
            this.Controls.Add(this.groupBoxRegistrarse);
            this.Controls.Add(this.buttonAcceder);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.groupBoxAcceder);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonUsuario);
            this.Controls.Add(this.buttonEntrar);
            this.helpProvider1.SetHelpKeyword(this, "1");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Palace - Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            this.groupBoxAcceder.ResumeLayout(false);
            this.groupBoxAcceder.PerformLayout();
            this.groupBoxRegistrarse.ResumeLayout(false);
            this.groupBoxRegistrarse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox usuarioAccederTextBox;
        private System.Windows.Forms.TextBox passwordAccederTextBox;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Button buttonUsuario;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.GroupBox groupBoxAcceder;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Button buttonAcceder;
        private System.Windows.Forms.GroupBox groupBoxRegistrarse;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxUsuarioRegistro;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxPassRegistro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonMostrarPassAcceder;
        private System.Windows.Forms.Button buttonMostrasPassRegistro;
        private System.Windows.Forms.Button buttonAyuda;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private HotelDataSet hotelDataSet;
        private HotelDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HotelDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.Button buttonAtras;
    }
}