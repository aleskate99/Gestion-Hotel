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
    public partial class InicioCliente : Form
    {
        public InicioCliente()
        {
            InitializeComponent();
        }

        private void InicioCliente_Load(object sender, EventArgs e)
        {

        }

        private void buttonReserva_Click(object sender, EventArgs e)
        {
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(MaestroDetalleReserva))
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
                MaestroDetalleReserva maestroDetalleReserva = new MaestroDetalleReserva();
                maestroDetalleReserva.ShowDialog();
            }
        }

        private void buttonHabitaciones_Click(object sender, EventArgs e)
        {
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(HabitacionesCliente))
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
                HabitacionesCliente habitacionesCliente = new HabitacionesCliente();
                habitacionesCliente.ShowDialog();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Login))
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
                Login login = new Login();
                login.Show();
            }

            this.Dispose();
        }

        private void buttonSalirInicio_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Quiere cerrar la aplicacion?", "Cerrar app", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void buttonServiciosExtra_Click(object sender, EventArgs e)
        {
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ServiciosExtra))
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
                ServiciosExtra serviciosExtra = new ServiciosExtra();
                serviciosExtra.ShowDialog();
            }

        }
    }
}
