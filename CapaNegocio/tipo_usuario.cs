using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;

namespace CapaDTO
{
    public class tipo_usuario
    {

        //CREAR INSERT COMBOBOX

        public DataTable CargarCombo()
        {
            ConexionSQL.conexion();

            SqlDataAdapter da = new SqlDataAdapter("SP_CARGARCOMBOBOX", ConexionSQL.conexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
