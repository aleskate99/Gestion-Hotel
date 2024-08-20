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
    public partial class Incidencias : Form
    {
        public Incidencias()
        {
            InitializeComponent();
        }

        private void Incidencias_Load(object sender, EventArgs e)
        {
            

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            var volver = MessageBox.Show("¿Quiere volver a la ventana principal?", "Cerrar incidencias", MessageBoxButtons.OKCancel);
            if (volver == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void buttonVerIncidencia_Click(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = "Ayuda";
            bool abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(MaestroDetalleIncidencia))
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
                MaestroDetalleIncidencia verIncidencia = new MaestroDetalleIncidencia();
                verIncidencia.ShowDialog();
            }
        }

        private void buttonCrearIncidencia_Click(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = "Ayuda";
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(CrearIncidencia))
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
                CrearIncidencia crearIncidencia = new CrearIncidencia();
                crearIncidencia.ShowDialog();
            }
        }
    }
}
