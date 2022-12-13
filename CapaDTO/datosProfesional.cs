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
    public class datosProfesional
    {
        //public List<cDTO.rol> LeerProfesional()
        //{
        //    List<cDTO.rol> listaProfesional = new List<cDTO.rol>();
        //    using (var conexion = ConexionSQL.conexion())
        //    {

        //        conexion.Open();
        //        using (var comando = new SqlCommand())
        //        {
        //            comando.Connection = conexion;
        //            comando.CommandText = "SELECT * FROM rol";
        //            SqlDataReader reader = comando.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                //listaProfesional.Add(new cDTO.rol(Convert.ToString(reader[0]), Convert.ToString(reader[1])));
        //            }
        //            return listaProfesional;
        //        }
        //    }
        //}
    }
}
