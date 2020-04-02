using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;

namespace Controlador
{
    public class MateriaController
    {
        public void ConsultarMateria(DataGridView dgvMateria)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                string consulta = "select id, nombre, intensidad_horaria from materia;";
                dgvMateria.DataSource = objeto.Consulta(consulta);
                objeto.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudieron Consultar Las Areas.");
            }
        }

        public void InsertarMateria(string Nombre, int IntensidadHoraria, string FechaRegistro, string FechaActualizacion, int AreaId)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                string consulta = "insert into materia values ('" + Nombre + "'," +  IntensidadHoraria + ", '" + FechaRegistro + "', '" + FechaActualizacion + "'," + AreaId + ", null);";
                objeto.EjecutarComando(consulta);
                objeto.CerrarConexion();
                MessageBox.Show("Se Realizó El Registro Correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudo Registrar La Persona");
            }
        }

        public void ActualizarMateria(int Id, string Nombre, int IntensidadHoraria, string FechaActualizacion, int AreaId)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                string consulta = "update materia set nombre = '" + Nombre + "', intensidad_horaria = " + IntensidadHoraria + ", fecha_actualizacion = '" + FechaActualizacion + "', area_id = " + AreaId + " where id = " + Id + ";";
                objeto.EjecutarComando(consulta);
                objeto.CerrarConexion();
                MessageBox.Show("Se Realizó La Actualización Correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudo Actualizar La Materia");
            }
        }
    }
}