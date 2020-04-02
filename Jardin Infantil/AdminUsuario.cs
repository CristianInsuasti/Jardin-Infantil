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
    public partial class AdminUsuario : Form
    {
        UsuarioController objetoUsuario;
        public AdminUsuario()
        {
            InitializeComponent();
            objetoUsuario = new UsuarioController();
        }

        public void Llenar_TablaUsuarios()
        {
            objetoUsuario.ConsultarUsuario(dgvUsuario);
        }

        private void AdminUsuario_Load(object sender, EventArgs e)
        {
            Llenar_TablaUsuarios();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtUsuario.Text == "" || txtContraseña.Text == "" || txtPerfil.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Se Deben Llenar Todos Los Campos");
            }
            else
            {
                DateTime FechaActualizacion = DateTime.Now;
                DateTime time = DateTime.Now;
                objetoUsuario.ActualizarUsuario(int.Parse(txtId.Text), txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtContraseña.Text, txtPerfil.Text, txtDireccion.Text
                    , txtCorreo.Text, txtDescripcion.Text, long.Parse(txtTelefono.Text),FechaActualizacion.ToString("yyyy-MM-dd HH:mm:ss"));
                txtId.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtPerfil.Text = "";
                txtDireccion.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                txtDescripcion.Text = "";
                Llenar_TablaUsuarios();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuarios.RegistrarUsuario mostrarRegistrar = new Usuarios.RegistrarUsuario();
            this.Hide();
            mostrarRegistrar.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numerofila = dgvUsuario.SelectedCells[0].RowIndex;
            DataGridViewRow FilaSeleccionada = dgvUsuario.Rows[numerofila];

            String id = "" + FilaSeleccionada.Cells["id"].Value;
            String nombre = "" + FilaSeleccionada.Cells["nombre"].Value;
            String apellido = "" + FilaSeleccionada.Cells["apellido"].Value;
            String usuario = "" + FilaSeleccionada.Cells["usuario"].Value;
            String contraseña = "" + FilaSeleccionada.Cells["contraseña"].Value;
            String perfil = "" + FilaSeleccionada.Cells["perfil"].Value;
            String direccion = "" + FilaSeleccionada.Cells["direccion"].Value;
            String telefono = "" + FilaSeleccionada.Cells["telefono"].Value;
            String correo = "" + FilaSeleccionada.Cells["correo"].Value;
            String descripcion = "" + FilaSeleccionada.Cells["descripcion"].Value;
            txtId.Text = id;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtUsuario.Text = usuario;
            txtContraseña.Text = contraseña;
            txtPerfil.Text = perfil;
            txtDireccion.Text = direccion;
            txtTelefono.Text = telefono;
            txtCorreo.Text = correo;
            txtDescripcion.Text = descripcion;
        }
    }
}
