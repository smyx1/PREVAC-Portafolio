using CapaConexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
     public class registrarCliente
    {
        private ConexionSQL conexion = new ConexionSQL();
        private SqlCommand command = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarRol()
        {
            DataTable Tabla = new DataTable();
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "ListarRol";
            command.CommandType = CommandType.StoredProcedure;
            LeerFilas = command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.ConexionCerrar();
            return Tabla;
        }

        public DataTable ListarEstado()
        {
            DataTable Tabla = new DataTable();
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "ListarEstado";
            command.CommandType = CommandType.StoredProcedure;
            LeerFilas = command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.ConexionCerrar();
            return Tabla;
        }

    }

    //public void InsertarCliente();

}
