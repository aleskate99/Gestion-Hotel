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
    public partial class InformeHabitaciones : Form
    {
        public InformeHabitaciones()
        {
            InitializeComponent();
        }

        private void InformeHabitaciones_Load(object sender, EventArgs e)
        {
            this.habitacionTableAdapter.Fill(this.hotelDataSet.Habitacion);
            this.reportViewer1.RefreshReport();
        }

        private void buttonTipo_Click(object sender, EventArgs e)
        {
            habitacionBindingSource.Filter = "TipoHabitacion='" + comboBoxTipo.Text + "'";
            reportViewer1.RefreshReport();
            comboBoxTipo.Text = "";
        }

        private void buttonEstado_Click(object sender, EventArgs e)
        {
            habitacionBindingSource.Filter = "Estado='" + comboBoxEstado.Text + "'";
            reportViewer1.RefreshReport();
            comboBoxEstado.Text = "";
        }

        private void buttonDesayuno_Click(object sender, EventArgs e)
        {
            habitacionBindingSource.Filter = "Desayuno='" + comboBoxDesayuno.Text + "'";
            reportViewer1.RefreshReport();
            comboBoxDesayuno.Text = "";
        }

        private void buttonQuitarFiltro_Click(object sender, EventArgs e)
        {
            habitacionBindingSource.RemoveFilter();
            reportViewer1.RefreshReport();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            var volver = MessageBox.Show("¿Quiere volver a la ventana de habitaciones?", "Cerrar informe habitaciones", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
