using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel
{
    public partial class InformeParteReparacion : Form
    {
        public InformeParteReparacion()
        {
            InitializeComponent();
        }

        private void InformeParteReparacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.ParteReparacion' Puede moverla o quitarla según sea necesario.
            this.parteReparacionTableAdapter.Fill(this.hotelDataSet.ParteReparacion);

            this.reportViewer1.RefreshReport();
        }

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            var volver = MessageBox.Show("¿Quiere volver a la ventana parte de reparación?", "Cerrar informe parte de reparación", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void buttonQuitarFiltro_Click(object sender, EventArgs e)
        {
            parteReparacionBindingSource.RemoveFilter();
            reportViewer1.RefreshReport();
            textBoxFiltrarIdHabitacion.Clear();
            textBoxFiltrarPrecio.Clear();
        }

        private void buttonFiltrarIdHabitacion_Click(object sender, EventArgs e)
        {
            parteReparacionBindingSource.Filter = "IdHabitacion='" + textBoxFiltrarIdHabitacion.Text + "'";
            reportViewer1.RefreshReport();
            textBoxFiltrarIdHabitacion.Clear();
        }

        private void buttonFiltrarTelefono_Click(object sender, EventArgs e)
        {
            parteReparacionBindingSource.Filter = "PrecioTotal='" + textBoxFiltrarPrecio.Text + "'";
            reportViewer1.RefreshReport();
            textBoxFiltrarPrecio.Clear();
        }

      
    }
}
