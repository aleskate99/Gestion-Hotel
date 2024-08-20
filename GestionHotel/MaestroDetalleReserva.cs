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
    public partial class MaestroDetalleReserva : Form
    {
        /*private string userName = string.Empty;

        public MaestroDetalleReserva()
        {
            InitializeComponent();
            AjustarImagenes();
            toolStripStatusLabel1.Text = "Inicio";
            RefrescarToolstripLabelReserva();
        }

        public MaestroDetalleReserva(string usuario)
        {
            userName = usuario;
            InitializeComponent();
            AjustarImagenes();
            toolStripStatusLabel1.Text = "Inicio";
            RefrescarToolstripLabelReserva();
        }*/

        public MaestroDetalleReserva()
        {
            InitializeComponent();
        }

        private void MaestroDetalleReserva_Load(object sender, EventArgs e)
        {
            this.detalleReservaTableAdapter.Fill(this.hotelDataSet.DetalleReserva);
            this.reservaTableAdapter.Fill(this.hotelDataSet.Reserva);

            EstadoControlesInicioApp();
            AjustarImagenes();
            RefrescarToolstripLabelReserva();
            toolStripStatusLabel1.Text = "Inicio";
            estadoControlesInicioDetalle();
        }

        private void toolStripButtonInforme_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Informe Reservas";
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(InformeReservas))
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
                InformeReservas informeReservas = new InformeReservas();
                informeReservas.ShowDialog();
            }
        }

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            var volver = MessageBox.Show("¿Quiere volver a la ventana principal?", "Cerrar maestro detalle reservas", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
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
            toolStripStatusLabel1.Text = "Inicio";
            RefrescarToolstripLabelReserva();

            //Botones
            toolStripButtonInicio.Enabled = false;
            toolStripButtonAnterior.Enabled = false;

            //Campos
            idReservaLabel1.Enabled = false;
            fechaEntradaDateTimePicker.Enabled = false;
            fechaSalidaDateTimePicker.Enabled = false;
            idClienteTextBox.Enabled = false;
            precioTotalLabel1.Enabled = false;
            tipoDePagoComboBox.Enabled = false;

            //Aceptar y cancelar invisibles hasta que se realice una operación
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Control estado flechas
            if (reservaBindingSource.Count < 1)
            {
                toolStripButtonEliminar.Enabled = false;
                toolStripButtonEditar.Enabled = false;
                toolStripButtonGuardar.Enabled = false;
                toolStripComboBoxBuscarReserva.Enabled = false;
                toolStripTextBoxBuscar.Enabled = false;
                toolStripButtonBuscar.Enabled = false;

                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }
            else if (reservaBindingSource.Count == 1)
            {
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;

                toolStripButtonEliminar.Enabled = true;
                toolStripButtonEditar.Enabled = true;
                toolStripButtonGuardar.Enabled = false;
                toolStripComboBoxBuscarReserva.Enabled = true;
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
                toolStripComboBoxBuscarReserva.Enabled = true;
                toolStripTextBoxBuscar.Enabled = true;
                toolStripButtonBuscar.Enabled = true;
            }
        }

        private void toolStripButtonInicio_Click(object sender, EventArgs e)
        {
            reservaBindingSource.MoveFirst();
            toolStripButtonInicio.Enabled = false;
            toolStripButtonAnterior.Enabled = false;

            if (reservaBindingSource.Count > 1)
            {
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            RefrescarToolstripLabelReserva();
        }

        private void toolStripButtonAnterior_Click(object sender, EventArgs e)
        {
            reservaBindingSource.MovePrevious();
            if (reservaBindingSource.Position <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
            }

            if (reservaBindingSource.Count > 1)
            {
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            RefrescarToolstripLabelReserva();
        }

        private void toolStripButtonSiguiente_Click(object sender, EventArgs e)
        {
            reservaBindingSource.MoveNext();
            if (reservaBindingSource.Count <= 0 || reservaBindingSource.Position + 1 == reservaBindingSource.Count)
            {
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
            }

            RefrescarToolstripLabelReserva();
        }

        private void toolStripButtonFinal_Click(object sender, EventArgs e)
        {
            reservaBindingSource.MoveLast();
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;

            if (reservaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
            }

            RefrescarToolstripLabelReserva();
        }

        private void RefrescarToolstripLabelReserva()
        {
            this.toolstripLabelContadorReservas.Text = $"Reserva {reservaBindingSource.Position + 1} de {reservaBindingSource.Count}";
        }

        private void toolStripButtonAnadir_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Añadir Reserva";
            toolStripButtonSiguiente.Enabled = false;
            toolStripButtonFinal.Enabled = false;

            reservaBindingSource.AddNew();

            DeshabilitarBotonesEnAnadir();
            HabilitarControlesEnAnadir();
            RefrescarToolstripLabelReserva();
        }

        private void HabilitarControlesEnAnadir()
        {
            //Botones
            buttonAceptar.Visible = true;
            buttonCancelar.Visible = true;
            toolStripButtonGuardar.Enabled = false;

            //Campos
            idReservaLabel1.Enabled = true;
            fechaEntradaDateTimePicker.Enabled = true;
            fechaSalidaDateTimePicker.Enabled = true;
            idClienteTextBox.Enabled = true;
            precioTotalLabel1.Enabled = true;
            tipoDePagoComboBox.Enabled = true;

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
            toolStripComboBoxBuscarReserva.Enabled = false;
            toolStripTextBoxBuscar.Enabled = false;
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Eliminar reserva";

            var resultado = MessageBox.Show("¿Está seguro que desea eliminar la reserva?", "Confirmación eliminar reserva", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                if (reservaBindingSource.Count <= 0)
                {
                    MessageBox.Show("No se puede eliminar la reserva porque no existe en la base de datos ", "Error en la eliminación de una reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    reservaBindingSource.RemoveCurrent();
                }

                if (reservaBindingSource.Count == 1)
                {
                    toolStripButtonAnterior.Enabled = false;
                    toolStripButtonInicio.Enabled = false;
                    toolStripButtonSiguiente.Enabled = false;
                    toolStripButtonFinal.Enabled = false;
                }

                if (reservaBindingSource.Count == 0)
                {
                    EstadoControlesInicioApp();
                }

                if (reservaBindingSource.Position + 1 == reservaBindingSource.Count)
                {
                    toolStripButtonSiguiente.Enabled = false;
                    toolStripButtonFinal.Enabled = false;
                }
            }

            RefrescarToolstripLabelReserva();
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Editar reserva";
            EstadoControlesEditar();
            ComprobarDatosIntroducidos();
        }

        private void EstadoControlesEditar()
        {
            //Botones
            buttonAceptar.Visible = true;
            buttonCancelar.Visible = true;

            //Campos
            idReservaLabel1.Enabled = true;
            fechaEntradaDateTimePicker.Enabled = true;
            fechaSalidaDateTimePicker.Enabled = true;
            idClienteTextBox.Enabled = true;
            precioTotalLabel1.Enabled = true;
            tipoDePagoComboBox.Enabled = true;

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
            toolStripComboBoxBuscarReserva.Enabled = false;
            toolStripTextBoxBuscar.Enabled = false;
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            ComprobarDatosIntroducidos();

            this.reservaTableAdapter.Update(this.hotelDataSet); //Guarda en la base de datos

            EstadoControlesGuardar();
            RefrescarToolstripLabelReserva();



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
            if (reservaBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (reservaBindingSource.Position + 1 == reservaBindingSource.Count && reservaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Position + 1 == reservaBindingSource.Count && reservaBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Count > 2 && reservaBindingSource.Position + 1 != reservaBindingSource.Count && reservaBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (reservaBindingSource.Position + 1 == 1 && reservaBindingSource.Count > 1)
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
            toolStripComboBoxBuscarReserva.Enabled = true;
            toolStripTextBoxBuscar.Enabled = true;

            //Campos
            idReservaLabel1.Enabled = false;
            fechaEntradaDateTimePicker.Enabled = false;
            fechaSalidaDateTimePicker.Enabled = false;
            idClienteTextBox.Enabled = false;
            precioTotalLabel1.Enabled = false;
            tipoDePagoComboBox.Enabled = false;
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Buscar reserva";
            try
            {
                if (toolStripButtonBuscar.Equals(""))
                {
                    MessageBox.Show("Introduzca un campo a buscar en el cuadro de texto", " no existe ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Busca por Id
                    if (toolStripComboBoxBuscarReserva.Text.Equals("IdReserva"))
                    {
                        if (reservaBindingSource.Find("IdReserva", toolStripTextBoxBuscar.Text) == -1)
                        {
                            MessageBox.Show("La reserva no existe");
                            toolStripTextBoxBuscar.Text = String.Empty;
                        }
                        else
                        {
                            reservaBindingSource.Position = reservaBindingSource.Find("IdReserva", toolStripTextBoxBuscar.Text);
                        }
                    }

                }
                RefrescarToolstripLabelReserva();

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

            if (reservaBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (reservaBindingSource.Position + 1 == reservaBindingSource.Count && reservaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Position + 1 == reservaBindingSource.Count && reservaBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Count > 2 && reservaBindingSource.Position + 1 != reservaBindingSource.Count && reservaBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (reservaBindingSource.Position + 1 == 1 && reservaBindingSource.Count > 1)
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
                reservaBindingSource.EndEdit(); //Lo guarda en memoria
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
            toolStripComboBoxBuscarReserva.Enabled = true;
            toolStripTextBoxBuscar.Enabled = true;
            toolStripButtonGuardar.Enabled = true;

            //Campos
            idReservaLabel1.Enabled = false;
            fechaEntradaDateTimePicker.Enabled = false;
            fechaSalidaDateTimePicker.Enabled = false;
            idClienteTextBox.Enabled = false;
            precioTotalLabel1.Enabled = false;
            tipoDePagoComboBox.Enabled = false;

            //Botones
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Flechas
            if (reservaBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (reservaBindingSource.Position + 1 == reservaBindingSource.Count && reservaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Position + 1 == reservaBindingSource.Count && reservaBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Count > 2 && reservaBindingSource.Position + 1 != reservaBindingSource.Count && reservaBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (reservaBindingSource.Position + 1 == 1 && reservaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

        }

        private bool ComprobarDatosIntroducidos()
        {

            if (idClienteTextBox.Text.Length == 0)
            {
                errorProvider1.SetError(idClienteTextBox, "No puede dejar este campo vacío ");
                idClienteTextBox.Clear();
                return false;
            }
            else if (ContieneNumeros(idClienteTextBox.Text) == false && (idClienteTextBox.Text.Length != 0))
            {
                errorProvider1.SetError(idClienteTextBox, "Solo puede introducir números ");
                idClienteTextBox.Clear();
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
                reservaBindingSource.CancelEdit();
                EstadoControlesCancelar();
                errorProvider1.Clear();
            }

            RefrescarToolstripLabelReserva();
        }

        private void EstadoControlesCancelar()
        {
            //Botones
            toolStripButtonAnadir.Enabled = true;
            toolStripButtonEditar.Enabled = true;
            toolStripButtonEliminar.Enabled = true;
            toolStripButtonBuscar.Enabled = true;
            toolStripComboBoxBuscarReserva.Enabled = true;
            toolStripTextBoxBuscar.Enabled = true;

            //Campos
            idReservaLabel1.Enabled = false;
            fechaEntradaDateTimePicker.Enabled = false;
            fechaSalidaDateTimePicker.Enabled = false;
            idClienteTextBox.Enabled = false;
            precioTotalLabel1.Enabled = false;
            tipoDePagoComboBox.Enabled = false;

            //Botones
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;

            //Flechas
            if (reservaBindingSource.Count <= 0)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Position + 1 > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;

            }

            if (reservaBindingSource.Position + 1 == reservaBindingSource.Count && reservaBindingSource.Count > 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Position + 1 == reservaBindingSource.Count && reservaBindingSource.Count == 1)
            {
                toolStripButtonAnterior.Enabled = false;
                toolStripButtonInicio.Enabled = false;
                toolStripButtonSiguiente.Enabled = false;
                toolStripButtonFinal.Enabled = false;
            }

            if (reservaBindingSource.Count > 2 && reservaBindingSource.Position + 1 != reservaBindingSource.Count && reservaBindingSource.Position + 1 != 1)
            {
                toolStripButtonAnterior.Enabled = true;
                toolStripButtonInicio.Enabled = true;
                toolStripButtonSiguiente.Enabled = true;
                toolStripButtonFinal.Enabled = true;
            }

            if (reservaBindingSource.Position + 1 == 1 && reservaBindingSource.Count > 1)
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

            string idReserva = idReservaLabel1.Text;
            string fechaEntrada = fechaEntradaDateTimePicker.Text;
            string fechaSalida = fechaSalidaDateTimePicker.Text;
            string idCliente = idClienteTextBox.Text;
            string precioTotal = precioTotalLabel1.Text;
            string tipoPago = tipoDePagoComboBox.Text;

            PrintDialog printDialog1 = new PrintDialog();

            printDialog1.AllowPrintToFile = false;
            printDialog1.AllowSelection = false;
            printDialog1.AllowSomePages = false;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                    e1.Graphics.DrawString("Id reserva: " + idReserva, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 100, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Fecha entrada: " + fechaEntrada, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 125, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Fecha salida: " + fechaSalida, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 150, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Id cliente: " + idCliente, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 175, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Precio total: " + precioTotal, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 200, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Tipo de pago: " + tipoPago, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 225, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    
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

        private void buttonAyudaInicio_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Pulse F1 para abrir ayuda";
        }

        private void idClienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (idClienteTextBox.Equals(""))
            {
                MessageBox.Show("Introduzca un campo a buscar en el cuadro de texto", " no existe ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Busca por Id
                if (idClienteTextBox.Text.Equals("IdCliente"))
                {
                    if (reservaBindingSource.Find("IdCliente", idClienteTextBox.Text) == -1)
                    {
                        MessageBox.Show("El cliente no existe");
                        idClienteTextBox.Text = String.Empty;
                    }
                    else
                    {
                        reservaBindingSource.Position = reservaBindingSource.Find("IdCliente", idClienteTextBox.Text);
                    }
                }

            }
        }

        private void estadoControlesInicioDetalle()
        {
            //Campos
            idDetalleReservaLabel1.Enabled = false;
            idHabitacionTextBox.Enabled = false;
            idReservaLabel3.Enabled = false;
            precioTextBox.Enabled = false;

            //Botones
            buttonAceptarDetalleReserva.Visible = false;
            buttonCancelarDetalleReserva.Visible = false;
        }

        private void buttonAniadirLinea_Click(object sender, EventArgs e)
        {
            detalleReservaBindingSource.AddNew();

            //Campos
            idDetalleReservaLabel1.Enabled = true;
            idHabitacionTextBox.Enabled = true;
            idReservaLabel3.Enabled = true;
            precioTextBox.Enabled = true;

            //Botones
            buttonAceptarDetalleReserva.Visible = true;
            buttonCancelarDetalleReserva.Visible = true;
        }

        private void buttonBorrarLinea_Click(object sender, EventArgs e)
        {
            if (detalleReservaBindingSource.Count <= 0)
            {
                MessageBox.Show("No se puede eliminar la línea porque no hay ninguna ", "Error en la eliminación de un cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                detalleReservaBindingSource.RemoveCurrent();
                this.reservaTableAdapter.Update(this.hotelDataSet);
            }
            
        }


        private void buttonEditarLinea_Click_1(object sender, EventArgs e)
        {
            //Campos
            idDetalleReservaLabel1.Enabled = true;
            idHabitacionTextBox.Enabled = true;
            idReservaLabel3.Enabled = true;
            precioTextBox.Enabled = true;

            //Botones
            buttonAceptarDetalleReserva.Visible = true;
            buttonCancelarDetalleReserva.Visible = true;
        }

        private void buttonAceptarDetalleReserva_Click(object sender, EventArgs e)
        {
            if (ComprobarDatosIntroducidos2()==true) {

                this.detalleReservaBindingSource.EndEdit();
                this.detalleReservaTableAdapter.Update(this.hotelDataSet);
                this.reservaTableAdapter.Update(this.hotelDataSet);
                precioTotalLabel1.Text = (Convert.ToInt32(precioTotalLabel1.Text) + Convert.ToInt32(precioTextBox.Text)).ToString();

                //Campos
                idDetalleReservaLabel1.Enabled = false;
                idHabitacionTextBox.Enabled = false;
                idReservaLabel3.Enabled = false;
                precioTextBox.Enabled = false;

                //Botones
                buttonAceptarDetalleReserva.Visible = false;
                buttonCancelarDetalleReserva.Visible = false;
            }
            
        }

        private bool ComprobarDatosIntroducidos2()
        {

            if (idHabitacionTextBox.Text.Length == 0)
            {
                errorProvider1.SetError(idHabitacionTextBox, "No puede dejar este campo vacío ");
                idHabitacionTextBox.Clear();
                return false;
            }
            else if (ContieneNumeros(idHabitacionTextBox.Text) == false && (idHabitacionTextBox.Text.Length != 0))
            {
                errorProvider1.SetError(idHabitacionTextBox, "Solo puede introducir números ");
                idHabitacionTextBox.Clear();
                return false;
            }


            //si todo es valido
            return true;
        }

        private void buttonCancelarDetalleReserva_Click(object sender, EventArgs e)
        {
            this.detalleReservaBindingSource.CancelEdit();

            //Campos
            idDetalleReservaLabel1.Enabled = false;
            idHabitacionTextBox.Enabled = false;
            idReservaLabel3.Enabled = false;
            precioTextBox.Enabled = false;

            //Botones
            buttonAceptarDetalleReserva.Visible = false;
            buttonCancelarDetalleReserva.Visible = false;
        }

        private void MaestroDetalleReserva_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(hotelDataSet.GetChanges() is null))
            {
                if (MessageBox.Show("¿Desea guardar antes de salir?\nSi no lo hace perderá los datos", this.Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.reservaBindingSource.CancelEdit();
                    this.detalleReservaBindingSource.CancelEdit();
                    this.tableAdapterManager.UpdateAll(this.hotelDataSet);
                }
            }
        }
    }
}
