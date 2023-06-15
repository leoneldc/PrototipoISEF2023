using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_Controlador
{
    public class Controlador
    {
        Cine_Modelo.Sentencias sentencias = new Cine_Modelo.Sentencias();

        public void setNewId(TextBox textBox, string tabla, string campo)
        {
            int id = sentencias.getNewId(campo, tabla) + 1;

            textBox.Text = id.ToString();
        }

        public DataTable mostrarAsientos(string cine, string pelicula)
        {
            OdbcDataAdapter data = sentencias.getAsientos(cine, pelicula);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        public void llenarComboBox(ComboBox comboBox, string tabla)
        {
            comboBox.Items.Clear();
            List<string> almacenes = sentencias.getDatosComboBox(tabla);
            foreach (string almacen in almacenes)
            {
                comboBox.Items.Add(almacen);
            }
        }


    }
}
