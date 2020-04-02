using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Area
    {
        private int id;
        private string nombre;
        private DateTime fechaRegistro;
        private DateTime fechaActualizar;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public DateTime FechaActualizar { get => fechaActualizar; set => fechaActualizar = value; }
    }
}
