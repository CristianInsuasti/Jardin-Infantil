using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Materia
    {
        private int id;
        private string nombre;
        private int intensidadHorario;
        private DateTime fechaRegistro;
        private DateTime fechaActualizacion;
        private int area_id;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IntensidadHorario { get => intensidadHorario; set => intensidadHorario = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public DateTime FechaActualizacion { get => fechaActualizacion; set => fechaActualizacion = value; }
        public int Area_id { get => area_id; set => area_id = value; }
    }
}
