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
    public partial class InformeReservas : Form
    {
        public InformeReservas()
        {
            InitializeComponent();
        }

        private void InformeReservas_Load(object sender, EventArgs e)
        {
            this.reservaTableAdapter.Fill(this.hotelDataSet.Reserva);
            this.reportViewer1.RefreshReport();
        }

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            var volver = MessageBox.Show("¿Quiere volver a la ventana de reservas?", "Cerrar informe reservas", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void buttonFiltrarId_Click(object sender, EventArgs e)
        {
            reservaBindingSource.Filter = "IdReserva='" + textBoxFiltrarIdReserva.Text + "'";
            reportViewer1.RefreshReport();
            textBoxFiltrarIdReserva.Clear();
        }

        private void buttonFiltrarTipoDePago_Click(object sender, EventArgs e)
        {
            reservaBindingSource.Filter = "TipoDePago='" + comboBoxTipoDePago.Text + "'";
            reportViewer1.RefreshReport();
            comboBoxTipoDePago.Text = "";
        }

        private void buttonQuitarFiltro_Click(object sender, EventArgs e)
        {
            reservaBindingSource.RemoveFilter();
            reportViewer1.RefreshReport();
            textBoxFiltrarIdReserva.Clear();
            comboBoxTipoDePago.Text= "";
        }
    }
}
