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
    public partial class InformeClientes : Form
    {
        public InformeClientes()
        {
            InitializeComponent();
        }

        private void InformeCliente_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.hotelDataSet.Cliente);
            this.reportViewer1.RefreshReport();
        }

        private void buttonQuitarFiltro_Click(object sender, EventArgs e)
        {
            clienteBindingSource.RemoveFilter();
            reportViewer1.RefreshReport();
            textBoxFiltrar.Clear();
            textBoxFiltrarTelefono.Clear();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.Filter = "Nombre='" + textBoxFiltrar.Text + "'";
            reportViewer1.RefreshReport();
            textBoxFiltrar.Clear();

        }

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            var volver = MessageBox.Show("¿Quiere volver a la ventana de clientes?", "Cerrar informe clientes", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clienteBindingSource.Filter = "Telefono='" + textBoxFiltrarTelefono.Text + "'";
            reportViewer1.RefreshReport();
            textBoxFiltrarTelefono.Clear();
        }

        private void buttonFiltrarSexo_Click(object sender, EventArgs e)
        {
            clienteBindingSource.Filter = "Sexo='" + comboBoxSexo.Text + "'";
            reportViewer1.RefreshReport();
            comboBoxSexo.Text = (" ");
        }
    }
}
