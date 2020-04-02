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
    public partial class AdminGrado : Form
    {
        GradoController objetoGrado;
        public AdminGrado()
        {
            InitializeComponent();
            objetoGrado = new GradoController();
        }

        public void Llenar_TablaGrados()
        {
            objetoGrado.ConsultarGrado(dgvGrado);
        }

        private void dgvGrado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numerofila = dgvGrado.SelectedCells[0].RowIndex;
            DataGridViewRow FilaSeleccionada = dgvGrado.Rows[numerofila];

            String id = "" + FilaSeleccionada.Cells["id"].Value;
            String nombre = "" + FilaSeleccionada.Cells["nombre"].Value;
            txtId.Text = id;
            txtNombre.Text = nombre;
        }

        private void AdminGrado_Load(object sender, EventArgs e)
        {
            Llenar_TablaGrados();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Grados.Registrar mostrarRegistrar = new Grados.Registrar();
            this.Hide();
            mostrarRegistrar.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Se Deben Llenar Todos Los Campos");
            }
            else
            {
                DateTime FechaActualizacion = DateTime.Now;
                objetoGrado.ActualizarGrado(int.Parse(txtId.Text), txtNombre.Text, FechaActualizacion.ToString("yyyy-MM-dd HH:mm:ss"));
                txtId.Text = "";
                txtNombre.Text = "";
                Llenar_TablaGrados();
            }
        }
    }
}