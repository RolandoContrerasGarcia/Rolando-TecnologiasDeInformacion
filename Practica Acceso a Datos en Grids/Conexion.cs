using System.Data;
using System.Data.SqlClient;
namespace Practica_Acceso_a_Datos_en_Grids
{
    internal class Conexion
    {
        static SqlConnection cdmx;
        static string cadena = "Data Source=DESKTOP-MNC8131;Initial Catalog=SISTEMA;Integrated Security=True";
        private static void Conectar()
        {
            cdmx = new SqlConnection(cadena);
            cdmx.Open();
        }
        private static void Desconectar()=>cdmx.Close();
        public static DataTable EjecutaSeleccion(string consulta)
        {
            DataTable dt = new DataTable();
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter(consulta, cdmx);
            da.Fill(dt);
            Desconectar();
            return dt;
        }
    }
}