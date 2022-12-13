using CapaConexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaDTO;
using System.Data;

namespace CapaNegocio
{
    public class registrarServicio
    {

        private ConexionSQL conexion = new ConexionSQL();
        private SqlCommand command = new SqlCommand();
        private SqlDataReader LeerFilas;


        public DataTable ListarServicios()
        {
            DataTable Tabla = new DataTable();
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "ListarServicios";
            command.CommandType = CommandType.StoredProcedure;
            LeerFilas = command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.ConexionCerrar();
            return Tabla;
        }

        public DataTable TipoServicio()
        {
            DataTable Tabla = new DataTable();
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "TipoServicio";
            command.CommandType = CommandType.StoredProcedure;
            LeerFilas = command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.ConexionCerrar();
            return Tabla;
        }

        public void InsertarServicio(string detalle_asesoria, DateTime fecha, string extra, string tema, string ubicacion, int duracion)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "Insert INTO InsertarServicio";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@detalle_asesoria",detalle_asesoria);
            command.Parameters.AddWithValue("@fecha", fecha);
            command.Parameters.AddWithValue("@extra", extra);
            command.Parameters.AddWithValue("@tema", tema);
            command.Parameters.AddWithValue("@ubicacion", ubicacion);
            command.Parameters.AddWithValue("@duracion", duracion);
            command.ExecuteNonQuery();
            command.Parameters.Clear();

        }


    }

    
}
