using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel
{
    public partial class Habitaciones : Form
    {
        public Habitaciones()
        {
            InitializeComponent();
        }

        private void Habitaciones_Load(object sender, EventArgs e)
        {
            this.habitacionTableAdapter.Fill(this.hotelDataSet.Habitacion);
            EstadoControlesInicioApp();
            AjustarImagenes();
            RefrescarToolstripLabelHabitacion();
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
            tipoHabitacionComboBox.Enabled = false;
            descripcionTextBox.Enabled = false;
            estadoComboBox.Enabled = false;
            numeroHuespedesNumericUpDown.Enabled = false;
            banosComboBox.Enabled = false;
            tipoCamaComboBox.Enabled = false;
            camaSupletoriaComboBox.Enabled = false;
            desayunoComboBox.Enabled = false;
            imagenHabitacionPictureBox.Enabled = false;
            imagenBanoPictureBox1.Enabled = false;

            //Aceptar y cancelar invisibles hasta que se realice una operación
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Control estado flechas
            if (habitacionBindingSource.Count < 1)
            {
                toolStripButtonEliminar.Enabled = false;
                toolStripButtonEditar.Enabled = false;
                toolStripButtonGuardar.Enabled = false;
                toolStripComboBoxBuscarHabitacion.Enabled = false;
                toolStripTextBoxBuscar.Enabled = false;
                toolStripButtonBuscar.Enabled = false;

                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            else if (habitacionBindingSource.Count == 1)
            {
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;

                toolStripButtonEliminar.Enabled = true;
                toolStripButtonEditar.Enabled = true;
                toolStripButtonGuardar.Enabled = false;
                toolStripComboBoxBuscarHabitacion.Enabled = true;
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
                toolStripComboBoxBuscarHabitacion.Enabled = true;
                toolStripTextBoxBuscar.Enabled = true;
                toolStripButtonBuscar.Enabled = true;
            }


        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Volviendo...";
            var volver = MessageBox.Show("¿Quiere volver a la ventana principal?", "Cerrar habitaciones", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void RefrescarToolstripLabelHabitacion()
        {
            this.toolstripLabelContadorHabitaciones.Text = $"Habitación {habitacionBindingSource.Position + 1} de {habitacionBindingSource.Count}";
        }

        private void toolStripButtonInicio_Click(object sender, EventArgs e)
        {
            habitacionBindingSource.MoveFirst();
            toolStripButtonInicio.Enabled = false;
            toolStripButtonAnterior.Enabled = false;

            if (habitacionBindingSource.Count > 1)
            {
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            RefrescarToolstripLabelHabitacion();
        }

        private void toolStripButtonAnterior_Click(object sender, EventArgs e)
        {
            habitacionBindingSource.MovePrevious();
            if (habitacionBindingSource.Position <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;

            }

            if (habitacionBindingSource.Count > 1)
            {
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            RefrescarToolstripLabelHabitacion();
        }

        private void toolStripButtonSiguiente_Click(object sender, EventArgs e)
        {
            habitacionBindingSource.MoveNext();
            if (habitacionBindingSource.Count <= 0 || habitacionBindingSource.Position + 1 == habitacionBindingSource.Count)
            {
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;

            }

            if (habitacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
            }

            RefrescarToolstripLabelHabitacion();
        }

        private void toolStripButtonFinal_Click(object sender, EventArgs e)
        {
            habitacionBindingSource.MoveLast();
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;

            if (habitacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
            }

            RefrescarToolstripLabelHabitacion();
        }

        private void toolStripButtonAnadir_Click(object sender, EventArgs e)
        {
            imagenHabitacionPictureBox.ImageLocation = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\Resources\\camara.png";
            imagenBanoPictureBox1.ImageLocation = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\Resources\\camara.png";
            toolStripStatusLabel1.Text = "Añadir habitación";
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;

            habitacionBindingSource.AddNew();

            DeshabilitarBotonesEnAnadir();
            HabilitarControlesEnAnadir();
            RefrescarToolstripLabelHabitacion();
        }

        private void HabilitarControlesEnAnadir()
        {
            //Botones
            buttonAceptar.Visible = true;
            buttonCancelar.Visible = true;
            toolStripButtonGuardar.Enabled = false;

            //Campos
            tipoHabitacionComboBox.Enabled = true;
            descripcionTextBox.Enabled = true;
            estadoComboBox.Enabled = true;
            numeroHuespedesNumericUpDown.Enabled = true;
            banosComboBox.Enabled = true;
            tipoCamaComboBox.Enabled = true;
            camaSupletoriaComboBox.Enabled = true;
            desayunoComboBox.Enabled = true;
            imagenHabitacionPictureBox.Enabled = true;
            imagenBanoPictureBox1.Enabled = true;

            //ComboBox por defecto a una opción
            tipoHabitacionComboBox.SelectedIndex = 0;
            estadoComboBox.SelectedIndex = 0;
            banosComboBox.SelectedIndex = 0;
            tipoCamaComboBox.SelectedIndex = 0;
            camaSupletoriaComboBox.SelectedIndex = 1;
            desayunoComboBox.SelectedIndex = 0;
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
            toolStripComboBoxBuscarHabitacion.Enabled = false;
            toolStripTextBoxBuscar.Enabled = false;

        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Eliminar habitación";

            var resultado = MessageBox.Show("¿Está seguro que desea eliminar la habitación?", "Confirmación eliminar habitación", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                if (habitacionBindingSource.Count <= 0)
                {
                    MessageBox.Show("No se puede eliminar la habitación porque no existe en la base de datos ", "Error en la eliminación de una habitación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    habitacionBindingSource.RemoveCurrent();
                }

                if (habitacionBindingSource.Count == 1)
                {
                    toolStripButtonAnterior.Enabled = false;
                    toolStripButtonInicio.Enabled = false;
                    toolStripButtonSiguiente.Enabled = false;
                    toolStripButtonFinal.Enabled = false;
                }

                if (habitacionBindingSource.Count == 0)
                {
                    EstadoControlesInicioApp();
                }

                if (habitacionBindingSource.Position + 1 == habitacionBindingSource.Count)
                {
                    toolStripButtonSiguiente.Enabled = false;
                    toolStripButtonFinal.Enabled = false;
                }
            }

            RefrescarToolstripLabelHabitacion();
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Editar habitación";
            EstadoControlesEditar();
            ComprobarDatosIntroducidos();
        }

        private void EstadoControlesEditar()
        {
            //Botones
            buttonAceptar.Visible = true;
            buttonCancelar.Visible = true;
            toolStripButtonGuardar.Enabled = false;


            //Campos
            tipoHabitacionComboBox.Enabled = true;
            descripcionTextBox.Enabled = true;
            estadoComboBox.Enabled = true;
            numeroHuespedesNumericUpDown.Enabled = true;
            banosComboBox.Enabled = true;
            tipoCamaComboBox.Enabled = true;
            camaSupletoriaComboBox.Enabled = true;
            desayunoComboBox.Enabled = true;
            imagenHabitacionPictureBox.Enabled = true;
            imagenBanoPictureBox1.Enabled = true;

            //Botones barra
            toolStripButtonAnadir.Enabled = false;
            toolStripButtonAnterior.Enabled = false;
            toolStripButtonInicio.Enabled = false;
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;
            toolStripButtonEditar.Enabled = false;
            toolStripButtonEliminar.Enabled = false;
            toolStripButtonBuscar.Enabled = false;
            toolStripComboBoxBuscarHabitacion.Enabled = false;
            toolStripTextBoxBuscar.Enabled = false;
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            ComprobarDatosIntroducidos();

            this.habitacionTableAdapter.Update(this.hotelDataSet); //Guarda en la base de datos

            EstadoControlesGuardar();
            RefrescarToolstripLabelHabitacion();

            MessageBox.Show("Guardado con éxito", " Guardado con exito ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EstadoControlesGuardar()
        {
            toolStripButtonAnadir.Enabled = true;
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;
            toolStripButtonGuardar.Enabled = false;
            toolStripButtonBuscar.Enabled = true;


            if (habitacionBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (habitacionBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (habitacionBindingSource.Position + 1 == habitacionBindingSource.Count && habitacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (habitacionBindingSource.Position + 1 == habitacionBindingSource.Count && habitacionBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (habitacionBindingSource.Count > 2 && habitacionBindingSource.Position + 1 != habitacionBindingSource.Count && habitacionBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (habitacionBindingSource.Position + 1 == 1 && habitacionBindingSource.Count > 1)
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
            toolStripComboBoxBuscarHabitacion.Enabled = true;
            toolStripTextBoxBuscar.Enabled = true;

            //Campos
            tipoHabitacionComboBox.Enabled = false;
            descripcionTextBox.Enabled = false;
            estadoComboBox.Enabled = false;
            numeroHuespedesNumericUpDown.Enabled = false;
            banosComboBox.Enabled = false;
            tipoCamaComboBox.Enabled = false;
            camaSupletoriaComboBox.Enabled = false;
            desayunoComboBox.Enabled = false;
            imagenHabitacionPictureBox.Enabled = false;
            imagenBanoPictureBox1.Enabled = false;
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Buscar habitación";
            try
            {
                if (toolStripButtonBuscar.Equals(""))
                {
                    MessageBox.Show("Introduzca un campo a buscar en el cuadro de texto", " no existe ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (toolStripComboBoxBuscarHabitacion.Text.Equals("Id"))
                    {
                        if (habitacionBindingSource.Find("IdHabitacion", toolStripTextBoxBuscar.Text) == -1)
                        {
                            MessageBox.Show("La habitación no existe");
                            toolStripTextBoxBuscar.Text = String.Empty;
                        }
                        else
                        {
                            habitacionBindingSource.Position = habitacionBindingSource.Find("IdHabitacion", toolStripTextBoxBuscar.Text);
                        }
                    }

                }
                RefrescarToolstripLabelHabitacion();

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

            if (habitacionBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (habitacionBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (habitacionBindingSource.Position + 1 == habitacionBindingSource.Count && habitacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (habitacionBindingSource.Position + 1 == habitacionBindingSource.Count && habitacionBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (habitacionBindingSource.Count > 2 && habitacionBindingSource.Position + 1 != habitacionBindingSource.Count && habitacionBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (habitacionBindingSource.Position + 1 == 1 && habitacionBindingSource.Count > 1)
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
                habitacionBindingSource.EndEdit(); //Lo guarda en memoria
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
            toolStripComboBoxBuscarHabitacion.Enabled = true;
            toolStripTextBoxBuscar.Enabled = true;
            toolStripButtonGuardar.Enabled = true;


            //Campos
            tipoHabitacionComboBox.Enabled = false;
            descripcionTextBox.Enabled = false;
            estadoComboBox.Enabled = false;
            numeroHuespedesNumericUpDown.Enabled = false;
            banosComboBox.Enabled = false;
            tipoCamaComboBox.Enabled = false;
            camaSupletoriaComboBox.Enabled = false;
            desayunoComboBox.Enabled = false;
            imagenHabitacionPictureBox.Enabled = false;
            imagenBanoPictureBox1.Enabled = false;

            //Botones
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;


            //Flechas
            if (habitacionBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (habitacionBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (habitacionBindingSource.Position + 1 == habitacionBindingSource.Count && habitacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (habitacionBindingSource.Position + 1 == habitacionBindingSource.Count && habitacionBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (habitacionBindingSource.Count > 2 && habitacionBindingSource.Position + 1 != habitacionBindingSource.Count && habitacionBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (habitacionBindingSource.Position + 1 == 1 && habitacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

        }

        private bool ComprobarDatosIntroducidos()
        {

            if (numeroHuespedesNumericUpDown.Text.Length == 0)
            {
                errorProvider1.SetError(numeroHuespedesNumericUpDown, "Número de huéspedes obligatorio");
                //numeroHuespedesNumericUpDown.Clear();
                return false;
            }
            else if (ContieneNumeros(numeroHuespedesNumericUpDown.Text)== false)
            {
                errorProvider1.SetError(numeroHuespedesNumericUpDown, "Solo puede introducir números");
                //numeroHuespedesTextBox.Clear();
                return false;
            }

            //si todo es valido
            return true;
        }

        private void numeroHuespedesTextBox_Validating_1(object sender, CancelEventArgs e)
        {

            if (ContieneNumeros(numeroHuespedesNumericUpDown.Text) == false)
            {
                errorProvider1.SetError(numeroHuespedesNumericUpDown, "Solo puede introducir números");
                //numeroHuespedesNumericUpDown.Clear();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        //Controla números
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Quiere cancelar la operación?", "Confirmación botón cancelar", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                habitacionBindingSource.CancelEdit();
                EstadoControlesCancelar();
                errorProvider1.Clear();
            }

            RefrescarToolstripLabelHabitacion();
        }

        private void EstadoControlesCancelar()
        {
            //Botones
            toolStripButtonAnadir.Enabled = true;
            toolStripButtonEditar.Enabled = true;
            toolStripButtonEliminar.Enabled = true;
            toolStripButtonBuscar.Enabled = true;
            toolStripComboBoxBuscarHabitacion.Enabled = true;
            toolStripTextBoxBuscar.Enabled = true;


            //Campos
            tipoHabitacionComboBox.Enabled = false;
            descripcionTextBox.Enabled = false;
            estadoComboBox.Enabled = false;
            numeroHuespedesNumericUpDown.Enabled = false;
            banosComboBox.Enabled = false;
            tipoCamaComboBox.Enabled = false;
            camaSupletoriaComboBox.Enabled = false;
            desayunoComboBox.Enabled = false;
            imagenHabitacionPictureBox.Enabled = false;
            imagenBanoPictureBox1.Enabled = false;

            //Botones
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;


            if (habitacionBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (habitacionBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (habitacionBindingSource.Position + 1 == habitacionBindingSource.Count && habitacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (habitacionBindingSource.Position + 1 == habitacionBindingSource.Count && habitacionBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (habitacionBindingSource.Count > 2 && habitacionBindingSource.Position + 1 != habitacionBindingSource.Count && habitacionBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (habitacionBindingSource.Position + 1 == 1 && habitacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }
        }

        private void Habitaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(hotelDataSet.GetChanges() is null))
            {
                if (MessageBox.Show("¿Desea guardar antes de salir?\nSi no lo hace perderá los datos", this.Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.habitacionBindingSource.CancelEdit();
                    this.tableAdapterManager.UpdateAll(this.hotelDataSet);
                }
            }
        }

        private void toolStripButtonImprimir_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Imprimiendo...";

            String id = idHabitacionLabel2.Text;
            String tipoHabitacion = tipoHabitacionComboBox.Text;
            String descripcion = descripcionTextBox.Text;
            String estado = estadoComboBox.Text;
            String numeroHuespedes= numeroHuespedesNumericUpDown.Text;
            String banos = banosComboBox.Text;
            String tipoCama = tipoCamaComboBox.Text;
            String camaSupletoria = camaSupletoriaComboBox.Text;
            String desayuno = desayunoComboBox.Text;
            Image imagenHabitacion = imagenHabitacionPictureBox.Image;
            Image imagenBano = imagenBanoPictureBox1.Image;


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
                    e1.Graphics.DrawString("Tipo de habitación: " + tipoHabitacion, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 125, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Cama supletoria: " + camaSupletoria, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 150, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Estado: " + estado, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 175, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Número de Huéspedes: " + numeroHuespedes, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 200, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Baño: " + banos, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 225, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Tipo de cama: " + tipoCama, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 250, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Desayuno: " + desayuno, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 275, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Descripción: " + descripcion, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 300, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    
                    Point loc = new Point(100, 350);
                    e1.Graphics.DrawImage(imagenHabitacion, loc);
                    Point loc2 = new Point(100, 750);
                    e1.Graphics.DrawImage(imagenBano, loc2);

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

        private void imagenHabitacionPictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagen = openFileDialog1.FileName;
                imagenHabitacionPictureBox.Image = Image.FromFile(imagen);
                imagenHabitacionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                imagenHabitacionPictureBox.Image = null;
            }
        }

        private void imagenBanoPictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagen = openFileDialog1.FileName;
                imagenBanoPictureBox1.Image = Image.FromFile(imagen);
                imagenBanoPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                imagenBanoPictureBox1.Image = null;
            }
        }

        private void toolStripButtonInforme_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Informe Habitaciones";
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(InformeHabitaciones))
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
                InformeHabitaciones informeHabitaciones = new InformeHabitaciones();
                informeHabitaciones.ShowDialog();
            }
        }

        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Pulse F1 para abrir ayuda";
        }
    }
}
