using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionHotel
{
    public partial class Login : Form
    {
        bool accederPulsado = false;
        bool registrarsePulsado = false;
        bool esUsuario = false;
        bool esAdmin = false;

        public Login()
        {
            //SPLASHSCREEN 

            //Creamos un hilo
            Thread t = new Thread(new ThreadStart(SplashStart));

            //Arrancamos el hilo
            t.Start();

            //Ponemos a dormir la forma principal
            Thread.Sleep(5000);

            //Finalizamos el hilo
            t.Abort();

            InitializeComponent();
        }

        public void SplashStart()
        {
            Application.Run(new Splash());
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.empleadoTableAdapter.Fill(this.hotelDataSet.Empleado);

            this.clienteTableAdapter.Fill(this.hotelDataSet.Cliente);

            this.empleadoTableAdapter.Fill(this.hotelDataSet.Empleado);
 
            estadoControlesInicio();
        }

        private void estadoControlesInicio()
        {
            accederPulsado = false;
            registrarsePulsado = false;

            buttonUsuario.Enabled = true;
            buttonAdmin.Enabled = true;

            buttonUsuario.Visible = true;
            buttonAdmin.Visible = true;

            buttonAcceder.Visible = false;
            buttonRegistrarse.Visible = false;
            buttonEntrar.Visible = false;
            groupBoxAcceder.Visible = false;
            groupBoxRegistrarse.Visible = false;
        }

        private bool comprobarDatosRegistro()
        {
            if (textBoxUsuarioRegistro.Text.Equals(""))
            {
                errorProvider1.SetError(textBoxUsuarioRegistro, "El nombre de usuario no puede estar vacio");
                textBoxUsuarioRegistro.Clear();
                return false;
            }

            else if (textBoxUsuarioRegistro.Text.Length > 30)
            {
                errorProvider1.SetError(textBoxUsuarioRegistro, "El nombre de usuario no debe superar los 30 caracteres introducidos ");
                textBoxUsuarioRegistro.Clear();
                return false;
            }

            if (textBoxPassRegistro.Text.Equals(""))
            {
                errorProvider1.SetError(textBoxPassRegistro, "Porfavor introduzca una contraseña");
                textBoxPassRegistro.Clear();
                return false;
            }
            else if ((textBoxPassRegistro.Text.Length > 30))
            {
                errorProvider1.SetError(textBoxPassRegistro, "La contraseña no debe superar los 30 caracteres introducidos ");
                textBoxPassRegistro.Clear();
                return false;
            }
            if (!(textBoxPassRegistro.Text.Equals("")) && (!passValida(textBoxPassRegistro.Text))) 
            {
                errorProvider1.SetError(textBoxPassRegistro, "Debe introducir mínimo 8 caracteres, entre ellos mínimo 1 mayúscula y 1 número ");
                textBoxPassRegistro.Clear();
                return false;
            }

            errorProvider1.Clear();
            return true;
            
        }

        private bool passValida(String campo)
        {
            int contaNumeros = 0;
            int contaMay = 0;
            int conta = 0;

            foreach (char letra in campo)
            {
                if ((letra >= 65 && letra <= 90))
                {
                    contaMay++;
                    conta++;
                }
                else if (letra >= 48 && letra <= 57)
                {
                    contaNumeros++;
                    conta++;
                }
                else 
                {
                    conta++;
                }

            }

            if (conta >= 8 && (contaNumeros >= 1 && contaMay >= 1) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            //ACCEDER
            if (accederPulsado==true) 
            {

                if (esAdmin == true)
                {   
                    var indiceResultadoBusquedaEmpleado = empleadoBindingSource.Find("Nombre", usuarioAccederTextBox.Text);
                    if (indiceResultadoBusquedaEmpleado != -1)
                    {
                        var empleadoRow = hotelDataSet.Tables["Empleado"].Rows[indiceResultadoBusquedaEmpleado];
                        var passwordEmpleado = empleadoRow["Password"].ToString();
                        if (passwordEmpleado == passwordAccederTextBox.Text)
                        {
                            var userName = usuarioAccederTextBox.Text;
                            usuarioAccederTextBox.Clear();
                            passwordAccederTextBox.Clear();
                            estadoControlesInicio();
                            Inicio inicio = new Inicio(userName);
                            inicio.ShowDialog(this);
                            esAdmin = false;
                            
                        }
                        else
                        {
                            MessageBox.Show("La contraseña no coincide");                            
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nombre de Usuario no encontrado");                       
                        return;
                    }
                }

                if (esUsuario == true)
                {
                    var indiceResultadoBusquedaCliente = clienteBindingSource.Find("Nombre", usuarioAccederTextBox.Text);
                    if (indiceResultadoBusquedaCliente != -1)
                    {
                        var clienteRow = hotelDataSet.Tables["Cliente"].Rows[indiceResultadoBusquedaCliente];
                        var passwordCliente = clienteRow["Password"].ToString();
                        if (passwordCliente == passwordAccederTextBox.Text)
                        {
                            usuarioAccederTextBox.Clear();
                            passwordAccederTextBox.Clear();
                            estadoControlesInicio();
                            InicioCliente inicioCliente = new InicioCliente();
                            inicioCliente.ShowDialog(this);
                            esUsuario = false;

                        }
                        else
                        {
                            MessageBox.Show("La contraseña no coincide");                            
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre de Usuario no encontrado");
                        
                        return;
                    }
                }
               
            }

            //REGISTRARSE
            if(registrarsePulsado==true)
            {
                if (comprobarDatosRegistro() == true)
                {
                    if (esAdmin)
                    {
                        var indiceResultadoBusquedaEmpleado = empleadoBindingSource.Find("Nombre", textBoxUsuarioRegistro.Text);
                        if (indiceResultadoBusquedaEmpleado == -1)
                        {
                            empleadoBindingSource.EndEdit();
                            tableAdapterManager.UpdateAll(hotelDataSet);
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario ya está en uso.");
                            return;
                        }

                    }

                    if (esUsuario)
                    {
                        var indiceResultadoBusquedaCliente = clienteBindingSource.Find("Nombre", textBoxUsuarioRegistro.Text);
                        if (indiceResultadoBusquedaCliente == -1)
                        {
                            clienteBindingSource.EndEdit();
                            tableAdapterManager.UpdateAll(hotelDataSet);
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario ya está en uso.");
                            return;
                        }
                    }
                    
                    MessageBox.Show("¡El registro se llevo a cabo correctamente! ", " Registro", MessageBoxButtons.OK);
                    textBoxUsuarioRegistro.Clear();
                    textBoxPassRegistro.Clear();                    
                    estadoControlesInicio();
                }
                
            }

            buttonAcceder.Enabled = true;
            buttonRegistrarse.Enabled= true;

           
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            esUsuario = true;
            buttonUsuario.Enabled = false;
            buttonAdmin.Visible = false;

            buttonAcceder.Visible = true;
            buttonRegistrarse.Visible = true;

            buttonEntrar.Visible = false;
            groupBoxAcceder.Visible = false;
            groupBoxRegistrarse.Visible = false;
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            esAdmin = true;
            buttonUsuario.Visible = false;
            buttonAdmin.Enabled = false;

            buttonAcceder.Visible = true;
            buttonRegistrarse.Visible = true;

            buttonEntrar.Visible = false;
            groupBoxAcceder.Visible = false;
            groupBoxRegistrarse.Visible = false;
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            registrarsePulsado = true;
           
            if (esUsuario == true) 
            {
                buttonUsuario.Visible = true;
                buttonUsuario.Enabled = false;

                buttonAdmin.Visible = false;

                buttonAcceder.Visible = false;
                buttonRegistrarse.Visible = false;

                buttonEntrar.Visible = true;
                groupBoxAcceder.Visible = false;
                groupBoxRegistrarse.Visible = true;

                textBoxUsuarioRegistro.DataBindings.Clear();
                textBoxPassRegistro.DataBindings.Clear();
                textBoxUsuarioRegistro.DataBindings.Add("Text", clienteBindingSource, "Nombre");
                textBoxPassRegistro.DataBindings.Add("Text", clienteBindingSource, "Password");
                clienteBindingSource.AddNew();
            }

            if (esAdmin == true)
            {
                buttonUsuario.Visible = false;

                buttonAdmin.Visible = true;
                buttonAdmin.Enabled = false;

                buttonAcceder.Visible = false;
                buttonRegistrarse.Visible = false;

                buttonEntrar.Visible = true;
                groupBoxAcceder.Visible = false;
                groupBoxRegistrarse.Visible = true;
                textBoxUsuarioRegistro.DataBindings.Clear();
                textBoxPassRegistro.DataBindings.Clear();
                textBoxUsuarioRegistro.DataBindings.Add("Text", empleadoBindingSource, "Nombre");
                textBoxPassRegistro.DataBindings.Add("Text", empleadoBindingSource, "Password");
                empleadoBindingSource.AddNew();
            }
           
        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            accederPulsado = true;

            if (esUsuario == true)
            {
                buttonUsuario.Visible = true;
                buttonUsuario.Enabled = false;

                buttonAdmin.Visible = false;

                buttonAcceder.Visible = false;
                buttonRegistrarse.Visible = false;

                buttonEntrar.Visible = true;
                groupBoxAcceder.Visible = true;
                groupBoxRegistrarse.Visible = false;
            }

            if (esAdmin == true)
            {
                buttonUsuario.Visible = false;

                buttonAdmin.Visible = true;
                buttonAdmin.Enabled = false;

                buttonAcceder.Visible = false;
                buttonRegistrarse.Visible = false;

                buttonEntrar.Visible = true;
                groupBoxAcceder.Visible = true;
                groupBoxRegistrarse.Visible = false;
            }

        }

        private void buttonMostrarPassAcceder_Click(object sender, EventArgs e)
        {
            passwordAccederTextBox.UseSystemPasswordChar = !passwordAccederTextBox.UseSystemPasswordChar;
        }

        private void buttonMostrasPassRegistro_Click(object sender, EventArgs e)
        {
            textBoxPassRegistro.UseSystemPasswordChar = !textBoxPassRegistro.UseSystemPasswordChar;
        }

        private void textBoxUsuarioRegistro_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxUsuarioRegistro.Text.Length > 30)
            {
                errorProvider1.SetError(textBoxUsuarioRegistro, "El nombre de usuario no debe superar los 30 caracteres introducidos ");
                textBoxUsuarioRegistro.Clear();
            }
            else 
            {
                errorProvider1.Clear();
            }
        }

        private void textBoxUsuarioRegistro_Validated(object sender, EventArgs e)
        {
            // Si todas las condiciones se cumplen se limpia los errores del ErrorProvider
            errorProvider1.SetError(textBoxUsuarioRegistro, "");
            errorProvider1.Clear();
        }

        private void textBoxPassRegistro_Validating(object sender, CancelEventArgs e)
        {
            if ((textBoxPassRegistro.Text.Length > 30))
            {
                errorProvider1.SetError(textBoxPassRegistro, "La contraseña no debe superar los 30 caracteres introducidos ");
                textBoxPassRegistro.Clear();
            }
            else if (!(textBoxPassRegistro.Text.Equals("")) && (!passValida(textBoxPassRegistro.Text)))
            {
                errorProvider1.SetError(textBoxPassRegistro, "Debe introducir mínimo 8 caracteres, entre ellos mínimo 1 mayúscula y 1 número ");
                textBoxPassRegistro.Clear();
            }
            else
            {
                errorProvider1.Clear();
            }
        }


        private void usuarioAccederTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(usuarioAccederTextBox, "");
            errorProvider1.Clear();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            estadoControlesInicio();

            accederPulsado = false;
            registrarsePulsado = false;
            esUsuario = false;
            esAdmin = false;

            textBoxUsuarioRegistro.Clear();
            textBoxPassRegistro.Clear();

            usuarioAccederTextBox.Clear();
            passwordAccederTextBox.Clear();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            var result = MessageBox.Show("¿Quiere cerrar la aplicacion?", "Cerrar app", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
