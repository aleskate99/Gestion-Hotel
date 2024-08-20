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
    public partial class InformeServicios : Form
    {
        public InformeServicios()
        {
            InitializeComponent();
        }

        private void InformeServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.ServiciosExtra' Puede moverla o quitarla según sea necesario.
            this.serviciosExtraTableAdapter.Fill(this.hotelDataSet.ServiciosExtra);
            this.reportViewer1.RefreshReport();
        }

        private void buttonQuitarFiltro_Click(object sender, EventArgs e)
        {
            serviciosExtraBindingSource.RemoveFilter();
            reportViewer1.RefreshReport();
            textBoxFiltrarId.Clear();
            comboBoxTrasladoAeropuerto.Text = "";
        }

        private void buttonFiltrarId_Click(object sender, EventArgs e)
        {
            serviciosExtraBindingSource.Filter = "IdServiciosExtra='" + textBoxFiltrarId.Text + "'";
            reportViewer1.RefreshReport();
            textBoxFiltrarId.Clear();
        }

        private void buttonFiltrarTraslado_Click(object sender, EventArgs e)
        {
            serviciosExtraBindingSource.Filter = "TransladoAeropuerto='" + comboBoxTrasladoAeropuerto.Text + "'";
            reportViewer1.RefreshReport();
            comboBoxTrasladoAeropuerto.Text = (" ");
        }

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            var volver = MessageBox.Show("¿Quiere volver a la ventana de servicios extra?", "Cerrar informe servicios", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
