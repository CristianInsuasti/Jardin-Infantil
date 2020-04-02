using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Jardin_Infantil
{
    public partial class Login : Form
    {
        UsuarioController objetoUsuario;
        public Login()
        {
            InitializeComponent();
            objetoUsuario = new UsuarioController();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Se Deben Llenar Todos Los Campos");
            }
            else
            {
                objetoUsuario.Ingresar(txtUsuario.Text, txtContraseña.Text, lblPerfil);
                if (lblPerfil.Text == "Administrador")
                {
                    AdminUsuario mostrarAdmin = new AdminUsuario();
                    MessageBox.Show("Bienvenido Administrador");
                    this.Hide();
                    mostrarAdmin.Show();
                }
                else if (lblPerfil.Text == "No aplica")
                {
                    MessageBox.Show("Datos Incorrectos, por favor intentar de nuevo");
                }
            }
        }
    }
}
