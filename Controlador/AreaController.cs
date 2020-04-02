using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;

namespace Controlador
{
    public class AreaController
    {
        public void ConsultarArea(DataGridView dgvUsuario)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                string consulta = "select id, nombre from area;";
                dgvUsuario.DataSource = objeto.Consulta(consulta);
                objeto.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudieron Consultar Las Areas.");
            }
        }

        public void InsertarArea(string Nombre, string FechaRegistro, string FechaActualizacion)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                string consulta = "insert into area values ('" + Nombre + "', '" + FechaRegistro + "', '" + FechaActualizacion + "', null);";
                objeto.EjecutarComando(consulta);
                objeto.CerrarConexion();
                MessageBox.Show("Se Realizó El Registro Correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudo Registrar La Persona");
            }
        }

        public void ActualizarArea(int Id, string Nombre, string FechaActualizacion)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                string consulta = "update area set nombre = '" + Nombre + "', fecha_actualizacion = '" + FechaActualizacion + "' where id = " + Id + ";";
                objeto.EjecutarComando(consulta);
                objeto.CerrarConexion();
                MessageBox.Show("Se Realizó La Actualización Correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudo Actualizar La Persona");
            }
        }
    }
}