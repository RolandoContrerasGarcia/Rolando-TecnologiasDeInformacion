using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace Practica1
{
    internal class Acciones
    {
        public static void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public static void LlenarCombo(string consulta, ComboBox combo)
        {
            DataTable dt;
            dt = Conexion.EjecutaSeleccion(consulta);
            if (dt == null)
            {
                return;
            }
            combo.Items.Clear();
            combo.DataSource = dt;
            combo.ValueMember = "id_empleado";
            combo.DisplayMember = "nombre";
        }

    }
}
