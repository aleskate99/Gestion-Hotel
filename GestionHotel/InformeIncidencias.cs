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
    public partial class InformeIncidencias : Form
    {
        public InformeIncidencias()
        {
            InitializeComponent();
        }

        private void InformeIncidencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.Incidencia' Puede moverla o quitarla según sea necesario.
            this.incidenciaTableAdapter.Fill(this.hotelDataSet.Incidencia);

            this.reportViewer1.RefreshReport();
        }

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            var volver = MessageBox.Show("¿Quiere volver a la ventana de incidencias?", "Cerrar informe incidencias", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            incidenciaBindingSource.Filter = "Tipo='" + comboBoxTipo.Text + "'";
            reportViewer1.RefreshReport();
            comboBoxTipo.Text = "";
        }

        private void buttonQuitarFiltro_Click(object sender, EventArgs e)
        {
            incidenciaBindingSource.RemoveFilter();
            reportViewer1.RefreshReport();
        }

        private void buttonEstado_Click(object sender, EventArgs e)
        {
            incidenciaBindingSource.Filter = "Estado='" + comboBoxEstado.Text + "'";
            reportViewer1.RefreshReport();
            comboBoxEstado.Text = "";
        }

        private void buttonGravedad_Click(object sender, EventArgs e)
        {
            incidenciaBindingSource.Filter = "Gravedad='" + comboBoxGravedad.Text + "'";
            reportViewer1.RefreshReport();
            comboBoxGravedad.Text = "";
        }
    }
}
