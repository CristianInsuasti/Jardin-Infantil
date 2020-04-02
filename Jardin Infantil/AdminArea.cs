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
    public partial class AdminArea : Form
    {
        AreaController objetoArea;
        public AdminArea()
        {
            InitializeComponent();
            objetoArea = new AreaController();
        }

        public void Llenar_TablaAreas()
        {
            objetoArea.ConsultarArea(dgvArea);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Areas.Registrar mostrarArea = new Areas.Registrar();
            mostrarArea.Show();
            this.Hide();
        }

        private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numerofila = dgvArea.SelectedCells[0].RowIndex;
            DataGridViewRow FilaSeleccionada = dgvArea.Rows[numerofila];

            String id = "" + FilaSeleccionada.Cells["id"].Value;
            String nombre = "" + FilaSeleccionada.Cells["nombre"].Value;
            txtId.Text = id;
            txtNombre.Text = nombre;
        }

        private void AdminArea_Load(object sender, EventArgs e)
        {
            Llenar_TablaAreas();
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
                objetoArea.ActualizarArea(int.Parse(txtId.Text), txtNombre.Text, FechaActualizacion.ToString("yyyy-MM-dd HH:mm:ss"));
                txtId.Text = "";
                txtNombre.Text = "";
                Llenar_TablaAreas();
            }
        }
    }
}
