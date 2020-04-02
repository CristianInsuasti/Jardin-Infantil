using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Controlador
{
    public class UsuarioController
    {
        public void Ingresar(string Usuario, string Contraseña, Label Perfil)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                SqlConnection conexion;
                conexion = new SqlConnection("Data Source=HOGAR\\SQLEXPRESS;Initial Catalog=jardinDB;integrated security = true");
                conexion.Open();//abro conexion
                string consulta = "select perfil from usuario where usuario = '"  + Usuario + "' and contraseña = '" + Encriptar(Contraseña) + "';";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    Perfil.Text = reader["perfil"].ToString();
                }
                else
                {
                    Perfil.Text = "No aplica";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudieron Consultar Los usuarios." + e);
            }
        }
        public void ConsultarUsuario(DataGridView dgvUsuario)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                string consulta = "Select id, nombre, apellido, usuario, contraseña, perfil, direccion, telefono, correo, descripcion from usuario where estado = 'Activo';";
                dgvUsuario.DataSource = objeto.Consulta(consulta);
                objeto.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudieron Consultar Los usuarios.");
            }
        }

        public void InsertarUsuario(string Nombre, string Apellido, string Usuario, string Contraseña, string Estado, string Perfil, string Direccion, string Correo, string Descripcion, long Telefono, string FechaRegistro, string FechaActualizacion)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                string consulta = "insert into usuario values ( '" + Nombre + "', '" + Apellido + "', '" + Usuario + "', '" + Encriptar(Contraseña) + "', '" + Estado + "', '" + Perfil + "', '" + Direccion + "', '" + Correo + "', '" + Descripcion + "', " + Telefono + ", '" + FechaRegistro + "', '" + FechaActualizacion + "', null);";
                objeto.EjecutarComando(consulta);
                objeto.CerrarConexion();
                MessageBox.Show("Se Realizó El Registro Correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudo Registrar La Persona");
            }
        }

        public void ActualizarUsuario(int Id, string Nombre, string Apellido, string Usuario, string Contraseña, string Perfil, string Direccion, string Correo, string Descripcion, long Telefono, string FechaActualizacion)
        {
            Modelo.Conexion objeto = new Modelo.Conexion();
            try
            {
                string consulta = "update usuario set nombre = '"+ Nombre +"', apellido = '" + Apellido + "', usuario = '" + Usuario + "', contraseña = '" + Encriptar(Contraseña) + "', perfil = '" + Perfil + "', direccion = '" + Direccion + "', correo = '" + Correo + "', descripcion = '" + Descripcion + "', telefono = '" + Telefono + "', Fecha_actualizacion = '" + FechaActualizacion + "' where id = " + Id + ";";
                objeto.EjecutarComando(consulta);
                objeto.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudo Actualizar La Persona");
            }
        }

        /// Encripta una cadena
        public static string Encriptar(string contraseña)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(contraseña);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(string contraseña)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(contraseña);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}