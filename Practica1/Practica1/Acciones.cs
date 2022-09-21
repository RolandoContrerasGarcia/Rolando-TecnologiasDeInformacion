using System.Windows.Forms;
using System.Data;
using ComboBox = System.Windows.Forms.ComboBox;
namespace Practica1
{
    internal class Acciones
    {
        public static void Mensaje(string mensaje)=>MessageBox.Show(mensaje, "Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        public static void LlenarCombo(string consulta, ComboBox combo, string Id, string Dato)
        {
            DataTable dt;
            dt = Conexion.EjecutaSeleccion(consulta);
            if (dt == null) return;
            DataRow dr = dt.NewRow();
            dr[0] = 0;
            dr[1] = "Todos";
            dt.Rows.InsertAt(dr, 0);
            combo.DataSource = dt;
            combo.ValueMember = Id;
            combo.DisplayMember = Dato;
        }
    }
}