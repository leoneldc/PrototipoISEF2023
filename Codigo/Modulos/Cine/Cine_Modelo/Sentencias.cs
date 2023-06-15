using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Modelo
{
    public class Sentencias
    {
        Conexion conectar = new Conexion();

        public OdbcDataAdapter llenarmitabla(string tabla, string idProveedor)
        {
            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, conectar.conexion());
            return datatable;
        }
        public OdbcDataAdapter getAsientos(string cine, string pelicula) 
        {
            string sql = "CALL getAsientos('"+ cine + "', '" + pelicula + " 1');";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sql, conectar.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar los asientos");
            }
            return dataTable;
        }

        public int getNewId(string campo, string tabla)
        {
            string sql = "SELECT COALESCE(MAX("+ campo + "), 0) FROM "+ tabla + ";";
            int id = 0;
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener el id de la tabla de "+tabla); }
            return id;
        }
        public List<string> getDatosComboBox(string tabla)
        {
            List<string> results = new List<string>();

            string sql = "SELECT * FROM "+ tabla+";";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener los datos de la tabla "+tabla); }

            return results;
        }
    }
}
