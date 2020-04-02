using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Grado
    {
        private int id;
        private string nombre;
        private int idUsuario;
        private DateTime fechaRegistro;
        private DateTime fechaActualizacion;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public DateTime FechaActualizacion { get => fechaActualizacion; set => fechaActualizacion = value; }
    }
}
