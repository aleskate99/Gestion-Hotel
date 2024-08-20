using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel
{
    public partial class CrearIncidencia : Form
    {
        public CrearIncidencia()
        {
            InitializeComponent();
        }

        private void CrearIncidencia_Load(object sender, EventArgs e)
        {
           
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Incidencia' Puede moverla o quitarla según sea necesario.
            this.incidenciaTableAdapter.Fill(this.hotelDataSet.Incidencia);
            AjustarImagenes();
            EstadoControlesInicioApp();
            RefrescarToolstripLabelIncidencia();
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

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            var volver = MessageBox.Show("¿Quiere volver a la ventana de incidencias?", "Cerrar crear incidencias", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void EstadoControlesInicioApp()
        {
            toolStripStatusLabel1.Text = "Inicio";
            //Botones
            toolStripButtonInicio.Enabled = false;
            toolStripButtonAnterior.Enabled = false;

            //Campos
            idIncidenciaLabel1.Enabled = false;
            tipoComboBox.Enabled = false;
            solucionTextBox.Enabled = false;   
            resumenTextBox.Enabled = false;
            estadoComboBox.Enabled = false;
            tiempoEstimadoArregloNumericUpDown.Enabled = false;
            gravedadComboBox.Enabled = false;
            imagenPictureBox.Enabled = false;

            //Aceptar y cancelar invisibles hasta que se realice una operación
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Control estado flechas
            if (incidenciaBindingSource.Count < 1)
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
            else if (incidenciaBindingSource.Count == 1)
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
            incidenciaBindingSource.MoveFirst();
            toolStripButtonInicio.Enabled = false;
            toolStripButtonAnterior.Enabled = false;

            if (incidenciaBindingSource.Count > 1)
            {
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            RefrescarToolstripLabelIncidencia();
        }

        private void toolStripButtonAnterior_Click(object sender, EventArgs e)
        {
            incidenciaBindingSource.MovePrevious();
            if (incidenciaBindingSource.Position <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
            }

            if (incidenciaBindingSource.Count > 1)
            {
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            RefrescarToolstripLabelIncidencia();
        }

        private void toolStripButtonSiguiente_Click(object sender, EventArgs e)
        {
            incidenciaBindingSource.MoveNext();
            if (incidenciaBindingSource.Count <= 0 || incidenciaBindingSource.Position + 1 == incidenciaBindingSource.Count)
            {
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
            }

            RefrescarToolstripLabelIncidencia();
        }

        private void toolStripButtonFinal_Click(object sender, EventArgs e)
        {
            incidenciaBindingSource.MoveLast();
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;

            if (incidenciaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
            }

            RefrescarToolstripLabelIncidencia();
        }

        private void RefrescarToolstripLabelIncidencia()
        {
            this.toolstripLabelContadorIncidencias.Text = $"Incidencia {incidenciaBindingSource.Position + 1} de {incidenciaBindingSource.Count}";
        }

        private void toolStripButtonAnadir_Click(object sender, EventArgs e)
        {
            imagenPictureBox.ImageLocation = "C:\\Users\\Usuario\\source\\repos\\GestionHotel\\GestionHotel\\Resources\\camara.png";
            toolStripStatusLabel1.Text = "Añadir incidencia";
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;

            incidenciaBindingSource.AddNew();

            DeshabilitarBotonesEnAnadir();
            HabilitarControlesEnAnadir();
            RefrescarToolstripLabelIncidencia();
        }

        private void HabilitarControlesEnAnadir()
        {
            //Botones
            buttonAceptar.Visible = true;
            buttonCancelar.Visible = true;
            toolStripButtonGuardar.Enabled = false;

            //Campos
            idIncidenciaLabel1.Enabled = true;
            tipoComboBox.Enabled = true;
            solucionTextBox.Enabled = true;
            resumenTextBox.Enabled = true;
            estadoComboBox.Enabled = true;
            tiempoEstimadoArregloNumericUpDown.Enabled = true;
            gravedadComboBox.Enabled = true;
            imagenPictureBox.Enabled = true;

            //ComboBox por defecto a una opción
            tipoComboBox.SelectedIndex = 0;
            estadoComboBox.SelectedIndex = 0;
            gravedadComboBox.SelectedIndex = 0;
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

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Eliminar incidencia";

            var resultado = MessageBox.Show("¿Está seguro que desea eliminar la incidencia?", "Confirmación eliminar incidencia", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                if (incidenciaBindingSource.Count <= 0)
                {
                    MessageBox.Show("No se puede eliminar la incidencia porque no existe en la base de datos ", "Error en la eliminación de una incidencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    incidenciaBindingSource.RemoveCurrent();
                }

                if (incidenciaBindingSource.Count == 1)
                {
                    toolStripButtonAnterior.Enabled = false;
                    toolStripButtonInicio.Enabled = false;
                    toolStripButtonSiguiente.Enabled = false;
                    toolStripButtonFinal.Enabled = false;
                }

                if (incidenciaBindingSource.Count == 0)
                {
                    EstadoControlesInicioApp();
                }

                if (incidenciaBindingSource.Position + 1 == incidenciaBindingSource.Count)
                {
                    toolStripButtonSiguiente.Enabled = false;
                    toolStripButtonFinal.Enabled = false;
                }
            }

            RefrescarToolstripLabelIncidencia();
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Editar incidencia";
            EstadoControlesEditar();
            ComprobarDatosIntroducidos();
        }

        private void EstadoControlesEditar()
        {
            //Botones
            buttonAceptar.Visible = true;
            buttonCancelar.Visible = true;

            //Campos
            idIncidenciaLabel1.Enabled = true;
            tipoComboBox.Enabled = true;
            solucionTextBox.Enabled = true;
            resumenTextBox.Enabled = true;
            estadoComboBox.Enabled = true;
            tiempoEstimadoArregloNumericUpDown.Enabled = true;
            gravedadComboBox.Enabled = true;
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

            this.incidenciaTableAdapter.Update(this.hotelDataSet); //Guarda en la base de datos

            EstadoControlesGuardar();
            RefrescarToolstripLabelIncidencia();

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
            if (incidenciaBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (incidenciaBindingSource.Position + 1 == incidenciaBindingSource.Count && incidenciaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Position + 1 == incidenciaBindingSource.Count && incidenciaBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Count > 2 && incidenciaBindingSource.Position + 1 != incidenciaBindingSource.Count && incidenciaBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (incidenciaBindingSource.Position + 1 == 1 && incidenciaBindingSource.Count > 1)
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
            idIncidenciaLabel1.Enabled = false;
            tipoComboBox.Enabled = false;
            solucionTextBox.Enabled = false;
            resumenTextBox.Enabled = false;
            estadoComboBox.Enabled = false;
            tiempoEstimadoArregloNumericUpDown.Enabled = false;
            gravedadComboBox.Enabled = false;
            imagenPictureBox.Enabled = false;
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Buscar incidencia";
            try
            {
                if (toolStripButtonBuscar.Equals(""))
                {
                    MessageBox.Show("Introduzca un campo a buscar en el cuadro de texto", " no existe ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Busca por Id
                    if (toolStripComboBoxBuscarClientes.Text.Equals("Id"))
                    {
                        if (incidenciaBindingSource.Find("Id", toolStripTextBoxBuscar.Text) == -1)
                        {
                            MessageBox.Show("La incidencia no existe");
                            toolStripTextBoxBuscar.Text = String.Empty;
                        }
                        else
                        {
                            incidenciaBindingSource.Position = incidenciaBindingSource.Find("IdIncidencia", toolStripTextBoxBuscar.Text);
                        }
                    }

                }
                RefrescarToolstripLabelIncidencia();

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

            if (incidenciaBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (incidenciaBindingSource.Position + 1 == incidenciaBindingSource.Count && incidenciaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Position + 1 == incidenciaBindingSource.Count && incidenciaBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Count > 2 && incidenciaBindingSource.Position + 1 != incidenciaBindingSource.Count && incidenciaBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (incidenciaBindingSource.Position + 1 == 1 && incidenciaBindingSource.Count > 1)
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
                incidenciaBindingSource.EndEdit(); //Lo guarda en memoria
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
            idIncidenciaLabel1.Enabled = false;
            tipoComboBox.Enabled = false;
            solucionTextBox.Enabled = false;
            resumenTextBox.Enabled = false;
            estadoComboBox.Enabled = false;
            tiempoEstimadoArregloNumericUpDown.Enabled = false;
            gravedadComboBox.Enabled = false;
            imagenPictureBox.Enabled = false;

            //Botones
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Flechas
            if (incidenciaBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (incidenciaBindingSource.Position + 1 == incidenciaBindingSource.Count && incidenciaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Position + 1 == incidenciaBindingSource.Count && incidenciaBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Count > 2 && incidenciaBindingSource.Position + 1 != incidenciaBindingSource.Count && incidenciaBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (incidenciaBindingSource.Position + 1 == 1 && incidenciaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

        }

        private bool ComprobarDatosIntroducidos()
        {
            //Tiempo arreglo
            if (tiempoEstimadoArregloNumericUpDown.Text.Length == 0)
            {
                errorProvider1.SetError(tiempoEstimadoArregloNumericUpDown, " Tiempo de arreglo obligatorio");
                //tiempoEstimadoArregloNumericUpDown.Clear();
                return false;
            }
            else if (!ContieneNumeros(tiempoEstimadoArregloNumericUpDown.Text))
            {
                errorProvider1.SetError(tiempoEstimadoArregloNumericUpDown, " Solo puede introducir números en este campo");
                //tiempoEstimadoArregloNumericUpDown.Clear();
                return false;
            }

            //Resumen
            if (resumenTextBox.Text.Length == 0)
            {
                errorProvider1.SetError(resumenTextBox, " Resumen obligatorio");
                resumenTextBox.Clear();
                return false;
            }

            //si todo es valido
            return true;
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Quiere cancelar la operación?", "Confirmación botón cancelar", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                incidenciaBindingSource.CancelEdit();
                EstadoControlesCancelar();
                errorProvider1.Clear();
            }

            RefrescarToolstripLabelIncidencia();
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
            idIncidenciaLabel1.Enabled = false;
            tipoComboBox.Enabled = false;
            solucionTextBox.Enabled = false;
            resumenTextBox.Enabled = false;
            estadoComboBox.Enabled = false;
            tiempoEstimadoArregloNumericUpDown.Enabled = false;
            gravedadComboBox.Enabled = false;
            imagenPictureBox.Enabled = false;

            //Botones
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Flechas
            if (incidenciaBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (incidenciaBindingSource.Position + 1 == incidenciaBindingSource.Count && incidenciaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Position + 1 == incidenciaBindingSource.Count && incidenciaBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (incidenciaBindingSource.Count > 2 && incidenciaBindingSource.Position + 1 != incidenciaBindingSource.Count && incidenciaBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (incidenciaBindingSource.Position + 1 == 1 && incidenciaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }
        }

        private void toolStripButtonImprimir_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Imprimiendo...";

            string id = idIncidenciaLabel1.Text;
            string tipo = tipoComboBox.Text;
            string solucion = solucionTextBox.Text;
            string resumen = resumenTextBox.Text;
            string estado = estadoComboBox.Text;
            string tiempoArreglo= tiempoEstimadoArregloNumericUpDown.Text; 
            string gravedad= gravedadComboBox.Text;
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
                    e1.Graphics.DrawString("Tipo: " + tipo, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 125, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Solución: " + solucion, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 150, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Resumen: " + resumen, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 175, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Estado: " + estado, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 200, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Tiempo estimado Arreglo: " + tiempoArreglo, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 225, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Gravedad: " + gravedad, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 250, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));

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

        private void CrearIncidencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(hotelDataSet.GetChanges() is null))
            {
                if (MessageBox.Show("¿Desea guardar antes de salir?\nSi no lo hace perderá los datos", this.Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.incidenciaBindingSource.CancelEdit();
                    this.tableAdapterManager.UpdateAll(this.hotelDataSet);
                }
            }
        }

        private void imagenPictureBox_Click_1(object sender, EventArgs e)
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

        private void toolStripButtonInforme_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Informe Incidencias";
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(InformeIncidencias))
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
                InformeIncidencias informeIncidencias = new InformeIncidencias();
                informeIncidencias.ShowDialog();
            }
        }

        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Pulse F1 para abrir ayuda";
        }
    }
 }

