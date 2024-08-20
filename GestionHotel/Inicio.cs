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
    public partial class Inicio : Form
    {
        private string userName = string.Empty;
        public Inicio()
        {
            InitializeComponent();

        }

        public Inicio(string userNameLogin)
        {
            userName = userNameLogin;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Clientes))
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
                Clientes cliente = new Clientes();
                cliente.ShowDialog();
            }
        }

        private void buttonSalirInicio_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Quiere cerrar la aplicacion?", "Cerrar app", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void buttonAyudaInicio_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Empleados))
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
                Empleados empleados = new Empleados();
                empleados.ShowDialog();
            }
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
                MaestroDetalleReserva reservas = new MaestroDetalleReserva();
                reservas.ShowDialog();
            }
        }

        private void buttonHabitaciones_Click(object sender, EventArgs e)
        {
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Habitaciones))
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
                Habitaciones habitaciones = new Habitaciones();
                habitaciones.ShowDialog();
            }
        }

        private void buttonIncidencias_Click(object sender, EventArgs e)
        {
            Boolean abierto = false;

            //comprobamos que no esta abierto el formulario;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Incidencias))
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
                Incidencias incidencias = new Incidencias();
                incidencias.ShowDialog();
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
