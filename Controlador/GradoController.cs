using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;

namespace Controlador
{
    public class GradoController
    {
        public void ConsultarGrado(DataGridView dgvUsuario)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                string consulta = "Select id, nombre from grado;";
                dgvUsuario.DataSource = objeto.Consulta(consulta);
                objeto.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudieron Consultar Los Grados.");
            }
        }

        public void InsertarGrado(string Nombre, string FechaRegistro, string FechaActualizacion)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                string consulta = "insert into grado values ('" + Nombre + "', '" + FechaRegistro + "', '" + FechaActualizacion + "', null);";
                objeto.EjecutarComando(consulta);
                objeto.CerrarConexion();
                MessageBox.Show("Se Realizó El Registro Correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudo Registrar La Persona");
            }
        }

        public void ActualizarGrado(int Id, string Nombre, string FechaActualizacion)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                string consulta = "update grado set nombre = '" + Nombre + "', Fecha_actualizacion = '" + FechaActualizacion + "' where id = " + Id + ";";
                objeto.EjecutarComando(consulta);
                objeto.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudo Actualizar La Persona");
            }
        }
    }
}
