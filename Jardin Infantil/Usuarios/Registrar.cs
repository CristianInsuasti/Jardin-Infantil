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

namespace Jardin_Infantil.Usuarios
{
    public partial class RegistrarUsuario : Form
    {
        UsuarioController objetoUsuario;
        public RegistrarUsuario()
        {
            InitializeComponent();
            objetoUsuario = new UsuarioController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtUsuario.Text == "" || txtContraseña.Text == "" || txtPerfil.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("Se Deben Llenar Todos Los Campos");
            }
            else
            {
                string Estado = "Activo";
                string Descripcion = "Ninguna";
                DateTime FechaRegistro = DateTime.Now;
                DateTime FechaActualizacion = DateTime.Now;
                DateTime time = DateTime.Now;
                objetoUsuario.InsertarUsuario(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtContraseña.Text, Estado, txtPerfil.Text, txtDireccion.Text
                    , txtCorreo.Text, Descripcion, long.Parse(txtTelefono.Text), FechaRegistro.ToString("yyyy-MM-dd HH:mm:ss"), FechaActualizacion.ToString("yyyy-MM-dd HH:mm:ss"));
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtPerfil.Text = "";
                txtDireccion.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                AdminUsuario mostrarAdmin = new AdminUsuario();
                this.Hide();
                mostrarAdmin.Show();
            }
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}