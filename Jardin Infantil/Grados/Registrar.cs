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

namespace Jardin_Infantil.Grados
{
    public partial class Registrar : Form
    {
        GradoController objetoGrado;
        public Registrar()
        {
            InitializeComponent();
            objetoGrado = new GradoController();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Se Deben Llenar Todos Los Campos");
            }
            else
            {                
                DateTime FechaRegistro = DateTime.Now;
                DateTime FechaActualizacion = DateTime.Now;
                DateTime time = DateTime.Now;
                objetoGrado.InsertarGrado(txtNombre.Text, FechaRegistro.ToString("yyyy-MM-dd HH:mm:ss"), FechaActualizacion.ToString("yyyy-MM-dd HH:mm:ss"));
                txtNombre.Text = "";
                AdminGrado mostrarGrado = new AdminGrado();
                this.Hide();
                mostrarGrado.Show();
            }
        }
    }
}
