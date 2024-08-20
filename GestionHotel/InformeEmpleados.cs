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
    public partial class InformeEmpleados : Form
    {
        public InformeEmpleados()
        {
            InitializeComponent();
        }

        private void InformeEmpleados_Load(object sender, EventArgs e)
        {
            this.empleadoTableAdapter.Fill(this.hotelDataSet.Empleado);
            this.reportViewer1.RefreshReport();
        }

        private void buttonQuitarFiltro_Click(object sender, EventArgs e)
        {
            empleadoBindingSource.RemoveFilter();
            reportViewer1.RefreshReport();
            textBoxFiltrar.Clear();
            textBoxFiltrarDNI.Clear();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            empleadoBindingSource.Filter = "Nombre='" + textBoxFiltrar.Text + "'";
            reportViewer1.RefreshReport();
            textBoxFiltrar.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empleadoBindingSource.Filter = "DNI='" + textBoxFiltrarDNI.Text + "'";
            reportViewer1.RefreshReport();
            textBoxFiltrarDNI.Clear();
        }

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            var volver = MessageBox.Show("¿Quiere volver a la ventana de empleados?", "Cerrar informe empleados", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void buttonTiempoEnLaEmpresa_Click(object sender, EventArgs e)
        {
            empleadoBindingSource.Filter = "TiempoEnLaEmpresa='" + comboBoxTiempoEnLaEmpresa.Text + "'";
            reportViewer1.RefreshReport();
            comboBoxTiempoEnLaEmpresa.Text = (" ");
        }
    }
}
