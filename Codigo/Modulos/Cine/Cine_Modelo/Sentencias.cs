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
    }
}
