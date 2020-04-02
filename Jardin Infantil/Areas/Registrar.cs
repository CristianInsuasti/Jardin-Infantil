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

namespace Jardin_Infantil.Areas
{
    public partial class Registrar : Form
    {
        AreaController objetoArea;
        public Registrar()
        {
            InitializeComponent();
            objetoArea = new AreaController();
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
                objetoArea.InsertarArea(txtNombre.Text, FechaRegistro.ToString("yyyy-MM-dd HH:mm:ss"), FechaActualizacion.ToString("yyyy-MM-dd HH:mm:ss"));
                txtNombre.Text = "";
                AdminArea mostrarArea = new AdminArea();
                this.Hide();
                mostrarArea.Show();
            }
        }
    }
}
