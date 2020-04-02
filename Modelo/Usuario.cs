using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string usuario;
        private string contraseña;
        private string estado;
        private string perfil;
        private string direccion;
        private string correo;
        private string descripcion;
        private long telefono;
        private DateTime fechaRegistro;
        private DateTime fechaActualizacion;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string UsuarioN { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Perfil { get => perfil; set => perfil = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public DateTime FechaActualizacion { get => fechaActualizacion; set => fechaActualizacion = value; }
    }
}
