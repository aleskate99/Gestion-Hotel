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
    public partial class MaestroDetalleIncidencia : Form
    {
        public MaestroDetalleIncidencia()
        {
            InitializeComponent();
        }

        private void parteReparacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.parteReparacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void MaestroDetalleIncidencia_Load(object sender, EventArgs e)
        {
            this.detalleParteTableAdapter.Fill(this.hotelDataSet.DetalleParte);
            this.parteReparacionTableAdapter.Fill(this.hotelDataSet.ParteReparacion);

            EstadoControlesInicioApp();
            AjustarImagenes();
            RefrescarToolstripLabelParte();
            toolStripStatusLabel1.Text = "Inicio";
            estadoControlesInicioDetalle();
        }

        //detalleParteBindingSource.EndEdit();
        //detalleParteDataGridView.Refresh();

       
        //PARTE DE REPARACIÓN
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
            toolStripStatusLabel1.Text = "Inicio";

            //Botones
            toolStripButtonInicio.Enabled = false;
            toolStripButtonAnterior.Enabled = false;

            //Campos
            idParteReparacionLabel2.Enabled = false;
            idHabitacionTextBox.Enabled = false;
            fechaDateTimePicker.Enabled = false;
            precioTotalLabel2.Enabled = false;
            observacionesTextBox.Enabled = false;

            //Aceptar y cancelar invisibles hasta que se realice una operación
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Control estado flechas
            if (parteReparacionBindingSource.Count < 1)
            {
                toolStripButtonEliminar.Enabled = false;
                toolStripButtonEditar.Enabled = false;
                toolStripButtonGuardar.Enabled = false;
                toolStripComboBoxBuscarParte.Enabled = false;
                toolStripTextBoxBuscar.Enabled = false;
                toolStripButtonBuscar.Enabled = false;

                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }
            else if (parteReparacionBindingSource.Count == 1)
            {
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;

                toolStripButtonEliminar.Enabled = true;
                toolStripButtonEditar.Enabled = true;
                toolStripButtonGuardar.Enabled = false;
                toolStripComboBoxBuscarParte.Enabled = true;
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
                toolStripComboBoxBuscarParte.Enabled = true;
                toolStripTextBoxBuscar.Enabled = true;
                toolStripButtonBuscar.Enabled = true;
            }
        }

        private void toolStripButtonInicio_Click(object sender, EventArgs e)
        {
            parteReparacionBindingSource.MoveFirst();
            toolStripButtonInicio.Enabled = false;
            toolStripButtonAnterior.Enabled = false;

            if (parteReparacionBindingSource.Count > 1)
            {
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            RefrescarToolstripLabelParte();
        }

        private void toolStripButtonAnterior_Click(object sender, EventArgs e)
        {
            parteReparacionBindingSource.MovePrevious();
            if (parteReparacionBindingSource.Position <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
            }

            if (parteReparacionBindingSource.Count > 1)
            {
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            RefrescarToolstripLabelParte();
        }

        private void toolStripButtonSiguiente_Click(object sender, EventArgs e)
        {
            parteReparacionBindingSource.MoveNext();
            if (parteReparacionBindingSource.Count <= 0 || parteReparacionBindingSource.Position + 1 == parteReparacionBindingSource.Count)
            {
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
            }

            RefrescarToolstripLabelParte();
        }

        private void toolStripButtonFinal_Click(object sender, EventArgs e)
        {
            parteReparacionBindingSource.MoveLast();
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;

            if (parteReparacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
            }

            RefrescarToolstripLabelParte();
        }

        private void RefrescarToolstripLabelParte()
        {
            this.toolstripLabelContadorParteReparacion.Text = $"Parte {parteReparacionBindingSource.Position + 1} de {parteReparacionBindingSource.Count}";
        }

        private void toolStripButtonAnadir_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Añadir Parte de reparación";
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;

            parteReparacionBindingSource.AddNew();

            DeshabilitarBotonesEnAnadir();
            HabilitarControlesEnAnadir();
            RefrescarToolstripLabelParte();
        }

        private void HabilitarControlesEnAnadir()
        {
            //Botones
            buttonAceptar.Visible = true;
            buttonCancelar.Visible = true;
            toolStripButtonGuardar.Enabled = false;

            //Campos
            idParteReparacionLabel2.Enabled = true;
            idHabitacionTextBox.Enabled = true;
            fechaDateTimePicker.Enabled = true;
            precioTotalLabel2.Enabled = true;
            observacionesTextBox.Enabled = true;

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
            toolStripComboBoxBuscarParte.Enabled = false;
            toolStripTextBoxBuscar.Enabled = false;
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Eliminar parte de reparación";

            var resultado = MessageBox.Show("¿Está seguro que desea eliminar el parte de reparación?", "Confirmación eliminar parte", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                if (parteReparacionBindingSource.Count <= 0)
                {
                    MessageBox.Show("No se puede eliminar el parte porque no existe en la base de datos ", "Error en la eliminación de un parte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    parteReparacionBindingSource.RemoveCurrent();
                }

                if (parteReparacionBindingSource.Count == 1)
                {
                    toolStripButtonAnterior.Enabled = false;
                    toolStripButtonInicio.Enabled = false;
                    toolStripButtonSiguiente.Enabled = false;
                    toolStripButtonFinal.Enabled = false;
                }

                if (parteReparacionBindingSource.Count == 0)
                {
                    EstadoControlesInicioApp();
                }

                if (parteReparacionBindingSource.Position + 1 == parteReparacionBindingSource.Count)
                {
                    toolStripButtonSiguiente.Enabled = false;
                    toolStripButtonFinal.Enabled = false;
                }
            }

            RefrescarToolstripLabelParte();
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Editar parte de reparación";
            EstadoControlesEditar();
            ComprobarDatosIntroducidos();
        }

        private void EstadoControlesEditar()
        {
            //Botones
            buttonAceptar.Visible = true;
            buttonCancelar.Visible = true;

            //Campos
            idParteReparacionLabel2.Enabled = true;
            idHabitacionTextBox.Enabled = true;
            fechaDateTimePicker.Enabled = true;
            precioTotalLabel2.Enabled = true;
            observacionesTextBox.Enabled = true;

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
            toolStripComboBoxBuscarParte.Enabled = false;
            toolStripTextBoxBuscar.Enabled = false;
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            ComprobarDatosIntroducidos();

            this.parteReparacionTableAdapter.Update(this.hotelDataSet); //Guarda en la base de datos

            EstadoControlesGuardar();
            RefrescarToolstripLabelParte();

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
            if (parteReparacionBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (parteReparacionBindingSource.Position + 1 == parteReparacionBindingSource.Count && parteReparacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Position + 1 == parteReparacionBindingSource.Count && parteReparacionBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Count > 2 && parteReparacionBindingSource.Position + 1 != parteReparacionBindingSource.Count && parteReparacionBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (parteReparacionBindingSource.Position + 1 == 1 && parteReparacionBindingSource.Count > 1)
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
            toolStripComboBoxBuscarParte.Enabled = true;
            toolStripTextBoxBuscar.Enabled = true;

            //Campos
            idParteReparacionLabel2.Enabled = false;
            idHabitacionTextBox.Enabled = false;
            fechaDateTimePicker.Enabled = false;
            precioTotalLabel2.Enabled = false;
            observacionesTextBox.Enabled = false;
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Buscar parte";
            try
            {
                if (toolStripButtonBuscar.Equals(""))
                {
                    MessageBox.Show("Introduzca un campo a buscar en el cuadro de texto", " no existe ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Busca por Id
                    if (toolStripComboBoxBuscarParte.Text.Equals("Id"))
                    {
                        if (parteReparacionBindingSource.Find("IdParteReparacion", toolStripTextBoxBuscar.Text) == -1)
                        {
                            MessageBox.Show("El parte no existe");
                            toolStripTextBoxBuscar.Text = String.Empty;
                        }
                        else
                        {
                            parteReparacionBindingSource.Position = parteReparacionBindingSource.Find("IdParteReparacion", toolStripTextBoxBuscar.Text);
                        }
                    }

                }
                RefrescarToolstripLabelParte();

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

            if (parteReparacionBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (parteReparacionBindingSource.Position + 1 == parteReparacionBindingSource.Count && parteReparacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Position + 1 == parteReparacionBindingSource.Count && parteReparacionBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Count > 2 && parteReparacionBindingSource.Position + 1 != parteReparacionBindingSource.Count && parteReparacionBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (parteReparacionBindingSource.Position + 1 == 1 && parteReparacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //MAESTRO DETALLE 
            buttonAniadirLinea.Enabled = true;
            buttonBorrarLinea.Enabled = true;
            buttonEditarLinea.Enabled = true;

            if (ComprobarDatosIntroducidos())
            {
                errorProvider1.Clear();
                parteReparacionBindingSource.EndEdit(); //Lo guarda en memoria
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
            toolStripComboBoxBuscarParte.Enabled = true;
            toolStripTextBoxBuscar.Enabled = true;
            toolStripButtonGuardar.Enabled = true;

            //Campos
            idParteReparacionLabel2.Enabled = false;
            idHabitacionTextBox.Enabled = false;
            fechaDateTimePicker.Enabled = false;
            precioTotalLabel2.Enabled = false;
            observacionesTextBox.Enabled = false;

            //Botones
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Flechas
            if (parteReparacionBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (parteReparacionBindingSource.Position + 1 == parteReparacionBindingSource.Count && parteReparacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Position + 1 == parteReparacionBindingSource.Count && parteReparacionBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Count > 2 && parteReparacionBindingSource.Position + 1 != parteReparacionBindingSource.Count && parteReparacionBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (parteReparacionBindingSource.Position + 1 == 1 && parteReparacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

        }
        private bool ComprobarDatosIntroducidos()
        {

            //idHabitacion
            if (idHabitacionTextBox.Text.Length == 0)
            {
                errorProvider1.SetError(idHabitacionTextBox, " Id Habitación obligatorio");
                idHabitacionTextBox.Clear();
                return false;
            }



            //si todo es valido
            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Quiere cancelar la operación?", "Confirmación botón cancelar", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                parteReparacionBindingSource.CancelEdit();
                EstadoControlesCancelar();
                errorProvider1.Clear();
            }

            RefrescarToolstripLabelParte();
        }

        private void EstadoControlesCancelar()
        {
            //Botones
            toolStripButtonAnadir.Enabled = true;
            toolStripButtonEditar.Enabled = true;
            toolStripButtonEliminar.Enabled = true;
            toolStripButtonBuscar.Enabled = true;
            toolStripComboBoxBuscarParte.Enabled = true;
            toolStripTextBoxBuscar.Enabled = true;

            //Campos
            idParteReparacionLabel2.Enabled = false;
            idHabitacionTextBox.Enabled = false;
            fechaDateTimePicker.Enabled = false;
            precioTotalLabel2.Enabled = false;
            observacionesTextBox.Enabled = false;

            //Botones
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Flechas
            if (parteReparacionBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (parteReparacionBindingSource.Position + 1 == parteReparacionBindingSource.Count && parteReparacionBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Position + 1 == parteReparacionBindingSource.Count && parteReparacionBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (parteReparacionBindingSource.Count > 2 && parteReparacionBindingSource.Position + 1 != parteReparacionBindingSource.Count && parteReparacionBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (parteReparacionBindingSource.Position + 1 == 1 && parteReparacionBindingSource.Count > 1)
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

            string idParte = idParteReparacionLabel2.Text;
            string idHabitacion = idHabitacionTextBox.Text;
            string fecha = fechaDateTimePicker.Text;
            string precio = precioTotalLabel2.Text;
            string observaciones = observacionesTextBox.Text;

            PrintDialog printDialog1 = new PrintDialog();

            printDialog1.AllowPrintToFile = false;
            printDialog1.AllowSelection = false;
            printDialog1.AllowSomePages = false;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                    e1.Graphics.DrawString("Id parte de reparación: " + idParte, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 100, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Id habitación: " + idHabitacion, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 125, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Fecha: " + fecha, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 150, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Precio: " + precio, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 175, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Observaciones: " + observaciones, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 200, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    
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
            toolStripStatusLabel1.Text = "Informe Parte de reparación";
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
                InformeParteReparacion informeParteReparacion = new InformeParteReparacion();
                informeParteReparacion.ShowDialog();
            }
        }

        private void MaestroDetalleIncidencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(hotelDataSet.GetChanges() is null))
            {
                if (MessageBox.Show("¿Desea guardar antes de salir?\nSi no lo hace perderá los datos", this.Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.parteReparacionBindingSource.CancelEdit();
                    this.tableAdapterManager.UpdateAll(this.hotelDataSet);
                }
            }
        }

        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Pulse F1 para abrir la ayuda";
        }

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            var volver = MessageBox.Show("¿Quiere volver a la ventana de incidencias?", "Cerrar maestro detalle incidencias", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
        }

        //DETALLE PARTE

        private void estadoControlesInicioDetalle() {
            //Campos
            idDetalleParteLabel2.Enabled = false;
            idIncidenciaTextBox.Enabled = false;
            cantidad_TextBox.Enabled = false;
            precioTextBox.Enabled = false;
            idParteReparacionLabel3.Enabled = false;

            //Botones
            buttonAceptarDetalleParte.Visible = false;
            buttonCancelarDetalleParte.Visible = false;
        }

        private void buttonAceptarDetalleParte_Click(object sender, EventArgs e)
        {
            this.detalleParteBindingSource.EndEdit();
            this.detalleParteTableAdapter.Update(this.hotelDataSet);
            this.parteReparacionTableAdapter.Update(this.hotelDataSet);
            precioTotalLabel2.Text = (Convert.ToInt32(precioTotalLabel2.Text) + Convert.ToInt32(precioTextBox.Text)).ToString();

            //Campos
            idDetalleParteLabel2.Enabled = false;
            idIncidenciaTextBox.Enabled = false;
            cantidad_TextBox.Enabled = false;
            precioTextBox.Enabled = false;
            idParteReparacionLabel3.Enabled = false;

            //Botones
            buttonAceptarDetalleParte.Visible = false;
            buttonCancelarDetalleParte.Visible = false;
        }

        private void buttonCancelarDetalleParte_Click(object sender, EventArgs e)
        {
            this.detalleParteBindingSource.CancelEdit();

            //Campos
            idDetalleParteLabel2.Enabled = false;
            idIncidenciaTextBox.Enabled = false;
            cantidad_TextBox.Enabled = false;
            precioTextBox.Enabled = false;
            idParteReparacionLabel3.Enabled = false;

            //Botones
            buttonAceptarDetalleParte.Visible = false;
            buttonCancelarDetalleParte.Visible = false;
        }

        //AÑADIR LINEA
        private void buttonAniadirLinea_Click(object sender, EventArgs e)
        {
            detalleParteBindingSource.AddNew();

            //Campos
            idDetalleParteLabel2.Enabled = true;
            idIncidenciaTextBox.Enabled = true;
            cantidad_TextBox.Enabled = true;
            precioTextBox.Enabled = true;
            idParteReparacionLabel3.Enabled = true;

            //Botones
            buttonAceptarDetalleParte.Visible = true;
            buttonCancelarDetalleParte.Visible = true;

        }

        //BORRAR LINEA
        private void buttonBorrarLinea_Click(object sender, EventArgs e)
        {
            if (detalleParteBindingSource.Count <= 0)
            {
                MessageBox.Show("No se puede eliminar la línea porque no hay ninguna ", "Error en la eliminación de un cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                detalleParteBindingSource.RemoveCurrent();
                this.detalleParteTableAdapter.Update(this.hotelDataSet);
            }
            
        }

        private void buttonEditarLinea_Click(object sender, EventArgs e)
        {
            //Campos
            idDetalleParteLabel2.Enabled = true;
            idIncidenciaTextBox.Enabled = true;
            cantidad_TextBox.Enabled = true;
            precioTextBox.Enabled = true;
            idParteReparacionLabel3.Enabled = true;

            //Botones
            buttonAceptarDetalleParte.Visible = true;
            buttonCancelarDetalleParte.Visible = true;
        }
    }
}
