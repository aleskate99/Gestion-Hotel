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
    public partial class HabitacionesCliente : Form
    {
        public HabitacionesCliente()
        {
            InitializeComponent();
        }

        private void HabitacionesCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Habitacion' Puede moverla o quitarla según sea necesario.
            this.habitacionTableAdapter.Fill(this.hotelDataSet.Habitacion);
            AjustarImagenes();
            EstadoControlesInicioApp();
            RefrescarToolstripLabelHabitacion();
        }

        private void AjustarImagenes()
        {
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
            tipoHabitacionComboBox.Enabled = false;
            descripcionTextBox.ReadOnly = true;
            estadoComboBox.Enabled = false;
            numeroHuespedesNumericUpDown.ReadOnly = true;
            banosComboBox.Enabled = false;
            tipoCamaComboBox.Enabled = false;
            camaSupletoriaComboBox.Enabled = false;
            desayunoComboBox.Enabled = false;
            imagenHabitacionPictureBox.Enabled = false;
            imagenBanoPictureBox1.Enabled = false;


            if (habitacionBindingSource.Count < 1)
            {
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

                toolStripComboBoxBuscarHabitacion.Enabled = true;
                toolStripTextBoxBuscar.Enabled = true;
                toolStripButtonBuscar.Enabled = true;
            }


        }


        private void RefrescarToolstripLabelHabitacion()
        {
            this.toolstripLabelContadorHabitaciones.Text = $"Habitación {habitacionBindingSource.Position + 1} de {habitacionBindingSource.Count}";
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

        private void habitacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.habitacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

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

        private void toolStripButtonImprimir_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Imprimiendo...";

            String id = idHabitacionLabel1.Text;
            String tipoHabitacion = tipoHabitacionComboBox.Text;
            String descripcion = descripcionTextBox.Text;
            String estado = estadoComboBox.Text;
            String numeroHuespedes = numeroHuespedesNumericUpDown.Text;
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
                    e1.Graphics.DrawString("Desayuno: " + desayuno, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 150, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Estado: " + estado, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 175, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Número de Huéspedes: " + numeroHuespedes, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 200, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Baño: " + banos, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 225, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Tipo de cama: " + tipoCama, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 250, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
                    e1.Graphics.DrawString("Cama supletoria: " + camaSupletoria, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 275, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
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


            }
            catch (FormatException)
            {
                MessageBox.Show("El formato del valor introducido no es correcto ", " Error en la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Pulse F1 para abrir la ayuda";
        }
    }
}
