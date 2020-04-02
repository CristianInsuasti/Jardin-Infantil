using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Modelo
{
    public class Conexion
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataAdapter Adaptador;
        DataTable tabla;
        DataSet ds;
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        public SqlCommand Comando { get => comando; set => comando = value; }

        public Conexion()
        {
            try
            {
                conexion = new SqlConnection("Data Source=HOGAR\\SQLEXPRESS;Initial Catalog=jardinDB;integrated security = true");
                conexion.Open();//abro conexion
                MessageBox.Show("Conectado");
            }
            catch (Exception error)
            {
                MessageBox.Show("No Se Ha Conectado");
            }
        }
        public void AbrirConexion()
        {
            conexion.Open();
        }
        public void CerrarConexion()
        {
            conexion.Close();
        }

        public void EjecutarComando(String consulta)
        {
            try
            {
                comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error Al Ejecutar El Comando" + error);
            }
        }

        public DataTable Consulta(String consulta)
        {
            Adaptador = new SqlDataAdapter(consulta, conexion);
            tabla = new DataTable();
            Adaptador.Fill(tabla);
            return tabla;
        }
    }
}