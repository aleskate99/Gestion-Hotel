using GestionHotel.HotelDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace GestionHotel
{
    public partial class Clientes : Form
    {

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.hotelDataSet.Cliente);
            EstadoControlesInicioApp();
            AjustarImagenes();
            RefrescarToolstripLabelCliente();
            toolStripStatusLabel1.Text = "Inicio";
        }

        private void AjustarImagenes()
        {
            //Ajustar imágen botón añadir
            this.toolStripButtonAnadir.AutoSize = false;
            this.toolStripButtonAnadir.Width = 50;
            this.toolStripButtonAnadir.Height = 50;
            this.toolStripButtonAnadir.ImageScaling = ToolStripItemImageScaling.None;

            //Ajustar imágen botón eliminar
            this.toolStripButtonEliminar.AutoSize = false;
            this.toolStripButtonEliminar.Width = 50;
            this.toolStripButtonEliminar.Height = 50;
            this.toolStripButtonEliminar.ImageScaling = ToolStripItemImageScaling.None;

            //Ajustar imágen botón editar
            this.toolStripButtonEditar.AutoSize = false;
            this.toolStripButtonEditar.Width = 50;
            this.toolStripButtonEditar.Height = 50;
            this.toolStripButtonEditar.ImageScaling = ToolStripItemImageScaling.None;

            //Ajustar imágen botón guardar
            this.toolStripButtonGuardar.AutoSize = false;
            this.toolStripButtonGuardar.Width = 50;
            this.toolStripButtonGuardar.Height = 50;
            this.toolStripButtonGuardar.ImageScaling = ToolStripItemImageScaling.None;

            //Ajustar imágen botón buscar
            this.toolStripButtonBuscar.AutoSize = false;
            this.toolStripButtonBuscar.Width = 50;
            this.toolStripButtonBuscar.Height = 50;
            this.toolStripButtonBuscar.ImageScaling = ToolStripItemImageScaling.None;

            //Ajustar imágen botón imprimir
            this.toolStripButtonImprimir.AutoSize = false;
            this.toolStripButtonImprimir.Width = 50;
            this.toolStripButtonImprimir.Height = 50;
            this.toolStripButtonImprimir.ImageScaling = ToolStripItemImageScaling.None;

            //Ajustar imágen botón formulario
            this.toolStripButtonInforme.AutoSize = false;
            this.toolStripButtonInforme.Width = 50;
            this.toolStripButtonInforme.Height = 50;
            this.toolStripButtonInforme.ImageScaling = ToolStripItemImageScaling.None;

            //Ajustar imágen botón anterior
            this.toolStripButtonAnterior.AutoSize = false;
            this.toolStripButtonAnterior.Width = 50;
            this.toolStripButtonAnterior.Height = 50;
            this.toolStripButtonAnterior.ImageScaling = ToolStripItemImageScaling.None;

            //Ajustar imágen botón principio
            this.toolStripButtonInicio.AutoSize = false;
            this.toolStripButtonInicio.Width = 50;
            this.toolStripButtonInicio.Height = 50;
            this.toolStripButtonInicio.ImageScaling = ToolStripItemImageScaling.None;

            //Ajustar imágen botón siguiente
            this.toolStripButtonSiguiente.AutoSize = false;
            this.toolStripButtonSiguiente.Width = 50;
            this.toolStripButtonSiguiente.Height = 50;
            this.toolStripButtonSiguiente.ImageScaling = ToolStripItemImageScaling.None;

            //Ajustar imágen botón final
            this.toolStripButtonFinal.AutoSize = false;
            this.toolStripButtonFinal.Width = 50;
            this.toolStripButtonFinal.Height = 50;
            this.toolStripButtonFinal.ImageScaling = ToolStripItemImageScaling.None;
        }

        private void EstadoControlesInicioApp()
        {
            //Botones
            toolStripButtonInicio.Enabled = false;
            toolStripButtonAnterior.Enabled = false;

            //Campos
            nombreTextBox.Enabled = false;
            apellidosTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            sexoComboBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            estadoCivilComboBox.Enabled = false;
            provinciaComboBox.Enabled = false;
            fechaNacimientoDateTimePicker.Enabled = false;
            tipoClienteComboBox.Enabled = false;
            cuentaCorrienteTextBox.Enabled = false;
            imagenPictureBox.Enabled = false;

            //Aceptar y cancelar invisibles hasta que se realice una operación
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Control estado flechas
            if (clienteBindingSource.Count < 1)
            {
                toolStripButtonEliminar.Enabled = false;
                toolStripButtonEditar.Enabled = false;
                toolStripButtonGuardar.Enabled = false;
                toolStripComboBoxBuscarClientes.Enabled = false;
                toolStripTextBoxBuscar.Enabled = false;
                toolStripButtonBuscar.Enabled = false;

                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }
            else if (clienteBindingSource.Count == 1)
            {
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;

                toolStripButtonEliminar.Enabled = true;
                toolStripButtonEditar.Enabled = true;
                toolStripButtonGuardar.Enabled = false;
                toolStripComboBoxBuscarClientes.Enabled = true;
                toolStripTextBoxBuscar.Enabled = true;
                toolStripButtonBuscar.Enabled = true;
            }
            else
            {
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;

                toolStripButtonEliminar.Enabled = true;
                toolStripButtonEditar.Enabled = true;
                toolStripButtonGuardar.Enabled = false;
                toolStripComboBoxBuscarClientes.Enabled = true;
                toolStripTextBoxBuscar.Enabled = true;
                toolStripButtonBuscar.Enabled = true;
            }
        }

        private void toolStripButtonInicio_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveFirst();
            toolStripButtonInicio.Enabled = false;
            toolStripButtonAnterior.Enabled = false;

            if (clienteBindingSource.Count > 1)
            {
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            RefrescarToolstripLabelCliente();
        }

        private void toolStripButtonAnterior_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MovePrevious();
            if (clienteBindingSource.Position <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
            }

            if (clienteBindingSource.Count > 1)
            {
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            RefrescarToolstripLabelCliente();
        }

        private void toolStripButtonSiguiente_Click(object sender, EventArgs e)
        {   
            clienteBindingSource.MoveNext();

            if (clienteBindingSource.Count <= 0 || clienteBindingSource.Position + 1 == clienteBindingSource.Count)
            {
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
            }

            RefrescarToolstripLabelCliente();
        }

        private void toolStripButtonFinal_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveLast();
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;

            if (clienteBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
            }

            RefrescarToolstripLabelCliente();
        }

        private void toolStripButtonAniadir_Click(object sender, EventArgs e)
        {
            imagenPictureBox.ImageLocation = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\Resources\\camara.png";
            toolStripStatusLabel1.Text = "Añadir cliente";
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;

            clienteBindingSource.AddNew();

            DeshabilitarBotonesEnAnadir();
            HabilitarControlesEnAnadir();
            RefrescarToolstripLabelCliente();
        }

        private void HabilitarControlesEnAnadir()
        {
            //Botones
            buttonAceptar.Visible = true;
            buttonCancelar.Visible = true;
            toolStripButtonGuardar.Enabled = false;

            //Campos
            nombreTextBox.Enabled = true;
            apellidosTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            sexoComboBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            estadoCivilComboBox.Enabled = true;
            provinciaComboBox.Enabled = true;
            fechaNacimientoDateTimePicker.Enabled = true;
            tipoClienteComboBox.Enabled = true;
            cuentaCorrienteTextBox.Enabled = true;
            imagenPictureBox.Enabled = true;

            //ComboBox por defecto a una opción
            // sexoComboBox.SelectAll();
            // sexoComboBox.SelectedText = "M";
            //sexoComboBox.Text = "M";
            //sexoComboBox.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            //sexoComboBox.SelectedItem = 0;
            sexoComboBox.SelectedIndex = 0;
            estadoCivilComboBox.SelectedIndex = 0;
            tipoClienteComboBox.SelectedIndex = 0;
            provinciaComboBox.SelectedIndex = 0;
        }

        //Deshabilita todos los botones en Añadir salvo aceptar cancelar y guardar
        private void DeshabilitarBotonesEnAnadir()
        {
            toolStripButtonAnadir.Enabled = false;
            toolStripButtonAnterior.Enabled = false;
            toolStripButtonInicio.Enabled = false;
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;
            toolStripButtonEditar.Enabled = false;
            toolStripButtonEliminar.Enabled = false;
            toolStripButtonBuscar.Enabled = false;
            toolStripComboBoxBuscarClientes.Enabled = false;
            toolStripTextBoxBuscar.Enabled = false;
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Eliminar cliente";

            var resultado = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Confirmación eliminar cliente", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                if (clienteBindingSource.Count <= 0)
                {
                    MessageBox.Show("No se puede eliminar el cliente porque no existe en la base de datos ", "Error en la eliminación de un cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clienteBindingSource.RemoveCurrent();
                }

                if (clienteBindingSource.Count == 1)
                {
                    toolStripButtonAnterior.Enabled = false;
                    toolStripButtonInicio.Enabled = false;
                    toolStripButtonSiguiente.Enabled = false;
                    toolStripButtonFinal.Enabled = false;
                }

                if (clienteBindingSource.Count == 0)
                {
                    EstadoControlesInicioApp();
                }

                if (clienteBindingSource.Position +1 == clienteBindingSource.Count)
                {
                    toolStripButtonSiguiente.Enabled = false;
                    toolStripButtonFinal.Enabled = false;
                }
            }

            RefrescarToolstripLabelCliente();

        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Editar cliente";
            EstadoControlesEditar();
            ComprobarDatosIntroducidos();
        }

        private void EstadoControlesEditar()
        {
            //Botones
            buttonAceptar.Visible = true;
            buttonCancelar.Visible = true;

            //Campos
            nombreTextBox.Enabled = true;
            apellidosTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            sexoComboBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            estadoCivilComboBox.Enabled = true;
            provinciaComboBox.Enabled = true;
            fechaNacimientoDateTimePicker.Enabled = true;
            tipoClienteComboBox.Enabled = true;
            cuentaCorrienteTextBox.Enabled = true;
            imagenPictureBox.Enabled = true;

            //Botones barra
            toolStripButtonAnadir.Enabled = false;
            toolStripButtonAnterior.Enabled = false;
            toolStripButtonInicio.Enabled = false;
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;
            toolStripButtonEditar.Enabled = false;
            toolStripButtonEliminar.Enabled = false;
            toolStripButtonGuardar.Enabled = false;
            toolStripButtonBuscar.Enabled = false;
            toolStripComboBoxBuscarClientes.Enabled = false;
            toolStripTextBoxBuscar.Enabled = false;
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {

            ComprobarDatosIntroducidos();
          
            this.clienteTableAdapter.Update(this.hotelDataSet); //Guarda en la base de datos

            EstadoControlesGuardar();
            RefrescarToolstripLabelCliente();

            MessageBox.Show("Guardado con éxito", " Guardado con exito ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void EstadoControlesGuardar()
        {
            toolStripButtonAnadir.Enabled = true;
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;
            toolStripButtonGuardar.Enabled = false;
            toolStripButtonBuscar.Enabled = true;

            //Controla estado flechas
            if (clienteBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (clienteBindingSource.Position + 1 == clienteBindingSource.Count && clienteBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Position + 1 == clienteBindingSource.Count && clienteBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Count > 2 && clienteBindingSource.Position + 1 != clienteBindingSource.Count && clienteBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (clienteBindingSource.Position + 1 == 1 && clienteBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            //Botones
            toolStripButtonEditar.Enabled = true;
            toolStripButtonEliminar.Enabled = true;
            toolStripButtonBuscar.Enabled = true;
            toolStripComboBoxBuscarClientes.Enabled = true;
            toolStripTextBoxBuscar.Enabled = true;

            //Campos
            nombreTextBox.Enabled = false;
            apellidosTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            sexoComboBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            estadoCivilComboBox.Enabled = false;
            provinciaComboBox.Enabled = false;
            fechaNacimientoDateTimePicker.Enabled = false;
            tipoClienteComboBox.Enabled = false;
            cuentaCorrienteTextBox.Enabled = false;
            imagenPictureBox.Enabled = false;
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Buscar cliente";
            try
            {
                if (toolStripButtonBuscar.Equals(""))
                {
                    MessageBox.Show("Introduzca un campo a buscar en el cuadro de texto", " no existe ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Busca por Nombre
                    if (toolStripComboBoxBuscarClientes.Text.Equals("Nombre"))
                    {
                        if (clienteBindingSource.Find("Nombre", toolStripTextBoxBuscar.Text) == -1)
                        {
                            MessageBox.Show("El cliente no existe");
                            toolStripTextBoxBuscar.Text = String.Empty;
                        }
                        else
                        {
                            clienteBindingSource.Position = clienteBindingSource.Find("Nombre", toolStripTextBoxBuscar.Text);
                        }
                    }

                    //Busca por Id
                    if (toolStripComboBoxBuscarClientes.Text.Equals("Id"))
                    {
                        if (clienteBindingSource.Find("Id", toolStripTextBoxBuscar.Text) == -1)
                        {
                            MessageBox.Show("El cliente no existe");
                            toolStripTextBoxBuscar.Text = String.Empty;
                        }
                        else
                        {
                            clienteBindingSource.Position = clienteBindingSource.Find("Id", toolStripTextBoxBuscar.Text);
                        }
                    }

                }
                RefrescarToolstripLabelCliente();

                EstadoControlesBuscar();

            }
            catch (FormatException)
            {
                MessageBox.Show("El formato del valor introducido no es correcto ", " Error en la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Controla el estado de las flechas en Buscar
        private void EstadoControlesBuscar()
        {

            if (clienteBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (clienteBindingSource.Position + 1 == clienteBindingSource.Count && clienteBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Position + 1 == clienteBindingSource.Count && clienteBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Count > 2 && clienteBindingSource.Position + 1 != clienteBindingSource.Count && clienteBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (clienteBindingSource.Position + 1 == 1 && clienteBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (ComprobarDatosIntroducidos())
            {
                errorProvider1.Clear();
                clienteBindingSource.EndEdit(); //Lo guarda en memoria
                EstadoControlesAceptar();
            } 
        }

        private void EstadoControlesAceptar()
        {
            //Botones
            toolStripButtonAnadir.Enabled = true;
            toolStripButtonEditar.Enabled = true;
            toolStripButtonEliminar.Enabled = true;
            toolStripButtonBuscar.Enabled = true;
            toolStripComboBoxBuscarClientes.Enabled = true;
            toolStripTextBoxBuscar.Enabled = true;
            toolStripButtonGuardar.Enabled = true;

            //Campos
            nombreTextBox.Enabled = false;
            apellidosTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            sexoComboBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            estadoCivilComboBox.Enabled = false;
            provinciaComboBox.Enabled = false;
            fechaNacimientoDateTimePicker.Enabled = false;
            tipoClienteComboBox.Enabled = false;
            cuentaCorrienteTextBox.Enabled = false;
            imagenPictureBox.Enabled = false;

            //Botones
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Flechas
            if (clienteBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (clienteBindingSource.Position + 1 == clienteBindingSource.Count && clienteBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Position + 1 == clienteBindingSource.Count && clienteBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Count > 2 && clienteBindingSource.Position + 1 != clienteBindingSource.Count && clienteBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (clienteBindingSource.Position + 1 == 1 && clienteBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

        }

        private bool ComprobarDatosIntroducidos()
        {
            //Nombre
            if (nombreTextBox.Text.Length==0)
            {
                errorProvider1.SetError(nombreTextBox, " Nombre obligatorio");
                nombreTextBox.Clear();
                return false;
            }

            else if (nombreTextBox.Text.Length > 30)
            {
                errorProvider1.SetError(nombreTextBox, "No debe superar los 30 dígitos introducidos");
                nombreTextBox.Clear();
                return false;
            }

            else if (!ContieneSoloLetras(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Solo puede introducir letras en el campo nombre");
                nombreTextBox.Clear();
                return false;
            }

            //Apellidos 
            if (apellidosTextBox.Text.Length==0)
            {
                errorProvider1.SetError(apellidosTextBox, " Apellidos obligatorios");
                apellidosTextBox.Clear();
                return false;
            }

            else if (apellidosTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(apellidosTextBox, "No debe superar los 50 dígitos introducidos ");
                apellidosTextBox.Clear();
                return false;
            }

            else if (!ContieneSoloLetras(apellidosTextBox.Text))
            {
                errorProvider1.SetError(apellidosTextBox, "Solo puede introducir letras en el campo apellidos ");
                apellidosTextBox.Clear();
                return false;
            }

            //Telefono
            if (ContieneNumeros(telefonoTextBox.Text) == false && (telefonoTextBox.Text.Length != 0))
            {
                errorProvider1.SetError(telefonoTextBox, "Solo puede introducir números ");
                telefonoTextBox.Clear();
                return false;
            }

            else if ((telefonoTextBox.Text.Length != 9) && (telefonoTextBox.Text.Length != 0))
            {
                errorProvider1.SetError(telefonoTextBox, "Debe tener 9 dígitos");
                telefonoTextBox.Clear();
                return false;
            }

            //Cuenta corriente
            if (cuentaCorrienteTextBox.Text.Length == 0)
            {
                errorProvider1.SetError(cuentaCorrienteTextBox, "Cuenta corriente obligatoria, debe seguir este formato (ES12 1234 1234 12 0123456789)");
                cuentaCorrienteTextBox.Clear();
                return false;
            }

            else if ((cuentaCorrienteTextBox.Text.Length != 28) && (cuentaCorrienteTextBox.Text.Length != 0)) //24 DÍGITOS Y 4 ESPACIOS  Ejemplo:(ES12 1234 1234 12 0123456789)
            {
                errorProvider1.SetError(cuentaCorrienteTextBox, "Debe seguir este formato (ES12 1234 1234 12 0123456789)");
                cuentaCorrienteTextBox.Clear();
                return false;
            }

            //si todo es valido
            return true;
        }

        //Controla mayusculas,minusculas,Ñ,ñ y vocales acentuadas
        private bool ContieneSoloLetras(String campo)
        {
            bool devolver = true;

            foreach (char letra in campo)
            {
                if ((letra >= 65 && letra <= 90) || (letra >= 97 && letra <= 122) || (letra >= 160 && letra <= 165) || (letra == 130)
                    || (letra == 181) || (letra == 144) || (letra == 214) || (letra == 224) || (letra == 233))
                {
                    devolver = true;
                }
                else
                {
                    devolver = false;
                }

            }
            return devolver;
        }

        //Comprueba números del 0 al 9
        private bool ContieneNumeros(String campo)
        {
            bool devolver = true;

            foreach (char num in campo)
            {
                if (num >= 48 && num <= 57)
                {
                    devolver = true;
                }
                else
                {
                    devolver = false;
                }

            }
            return devolver;
        }

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (nombreTextBox.Text.Length > 30)
            {
                errorProvider1.SetError(nombreTextBox, "No debe superar los 30 dígitos introducidos");
                nombreTextBox.Clear();
            }
            else if (!ContieneSoloLetras(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Solo puede introducir letras en el campo nombre");
                nombreTextBox.Clear();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void apellidosTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (apellidosTextBox.TextLength > 50)
            {
                errorProvider1.SetError(apellidosTextBox, "No debe superar los 50 dígitos introducidos ");
                apellidosTextBox.Clear();
            }

            else if (!ContieneSoloLetras(apellidosTextBox.Text))
            {
                errorProvider1.SetError(apellidosTextBox, "Solo puede introducir letras en el campo apellidos ");
                apellidosTextBox.Clear();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void telefonoTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (ContieneNumeros(telefonoTextBox.Text) == false)
            {
                errorProvider1.SetError(telefonoTextBox, "Solo puede introducir números ");
                telefonoTextBox.Clear();
            }

            else if ((telefonoTextBox.Text.Length != 9) && (telefonoTextBox.Text.Length != 0))
            {
                errorProvider1.SetError(telefonoTextBox, "Debe tener 9 dígitos");
                telefonoTextBox.Clear();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cuentaCorrienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if ((cuentaCorrienteTextBox.Text.Length != 28) && (cuentaCorrienteTextBox.Text.Length != 0)) //24 DÍGITOS Y 4 ESPACIOS  Ejemplo:(ES12 1234 1234 12 0123456789)
            {
                errorProvider1.SetError(cuentaCorrienteTextBox, "Debe seguir este formato (ES12 1234 1234 12 0123456789)");
                cuentaCorrienteTextBox.Clear();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Quiere cancelar la operación?", "Confirmación botón cancelar", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                clienteBindingSource.CancelEdit();
                EstadoControlesCancelar();
                errorProvider1.Clear();
            }

            RefrescarToolstripLabelCliente();

        }

        private void EstadoControlesCancelar()
        {
            //Botones
            toolStripButtonAnadir.Enabled = true;
            toolStripButtonEditar.Enabled = true;
            toolStripButtonEliminar.Enabled = true;
            toolStripButtonBuscar.Enabled = true;
            toolStripComboBoxBuscarClientes.Enabled = true;
            toolStripTextBoxBuscar.Enabled = true;

            //Campos
            nombreTextBox.Enabled = false;
            apellidosTextBox.Enabled = false;
            direccionTextBox.Enabled = false; 
            sexoComboBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            estadoCivilComboBox.Enabled = false;
            provinciaComboBox.Enabled = false;
            fechaNacimientoDateTimePicker.Enabled = false;  
            tipoClienteComboBox.Enabled = false;
            cuentaCorrienteTextBox.Enabled = false;
            imagenPictureBox.Enabled = false;

            //Botones
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Flechas
            if (clienteBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (clienteBindingSource.Position + 1 == clienteBindingSource.Count && clienteBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Position + 1 == clienteBindingSource.Count && clienteBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (clienteBindingSource.Count > 2 && clienteBindingSource.Position + 1 != clienteBindingSource.Count && clienteBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (clienteBindingSource.Position + 1 == 1 && clienteBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }
        }

        private void RefrescarToolstripLabelCliente()
        {
            this.toolstripLabelContadorClientes.Text = $"Cliente {clienteBindingSource.Position + 1} de {clienteBindingSource.Count}";
        }

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Volviendo...";
            var volver = MessageBox.Show("¿Quiere volver a la ventana principal?", "Cerrar clientes", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void imagenPictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagen = openFileDialog1.FileName;
                imagenPictureBox.Image = Image.FromFile(imagen);
                imagenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                imagenPictureBox.Image = null;
            }
        }

        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Pulse F1 para abrir ayuda";
      
        }

        private void toolStripButtonImprimir_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Imprimiendo...";

            string id = idLabel2.Text;
            string nombre = nombreTextBox.Text;
            string apellidos = apellidosTextBox.Text;
            string direccion = direccionTextBox.Text;
            string sexo = sexoComboBox.Text;
            string telefono = telefonoTextBox.Text;
            string estadoCivil = estadoCivilComboBox.Text;
            string provincia = provinciaComboBox.Text;
            string fechaNacimiento = fechaNacimientoDateTimePicker.Text;
            string tipoCliente = tipoClienteComboBox.Text;
            string cuentaCorriente = cuentaCorrienteTextBox.Text;
            Image imagen = imagenPictureBox.Image;


            PrintDialog printDialog1 = new PrintDialog();

            printDialog1.AllowPrintToFile = false;
            printDialog1.AllowSelection = false;
            printDialog1.AllowSomePages = false;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                    e1.Graphics.DrawString("Id: " + id, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 100, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Nombre: " + nombre, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 125, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Apellidos: " + apellidos, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 150, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Dirección: " + direccion, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 175, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Sexo: " + sexo, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 200, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Teléfono: " + telefono, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 225, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Estado Civil: " + estadoCivil, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 250, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Provincia: " + provincia, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 275, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Fecha de nacimiento: " + fechaNacimiento, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 300, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Tipo de cliente: " + tipoCliente, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 325, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Cuenta corriente: " + cuentaCorriente, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 350, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    Point loc = new Point(100, 500);
                    e1.Graphics.DrawImage(imagen, loc);

                };
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                try
                {
                    printDocument1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de impresión al imprimir el formulario", "Imprimir formulario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void toolStripButtonInforme_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Informe Clientes";
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(InformeClientes))
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Normal;
                    }
                    frm.BringToFront();
                    abierto = true;
                    break;
                }

            }
            if (!abierto)
            {
                InformeClientes informeClientes = new InformeClientes();
                informeClientes.ShowDialog();
            }
        }

        private void Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(hotelDataSet.GetChanges() is null))
            {
                if (MessageBox.Show("¿Desea guardar antes de salir?\nSi no lo hace perderá los datos", this.Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.clienteBindingSource.CancelEdit();
                    this.tableAdapterManager.UpdateAll(this.hotelDataSet);
                }
            }
        }
    }
}

