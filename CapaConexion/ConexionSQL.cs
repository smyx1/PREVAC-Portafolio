using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaConexion
{
    public class ConexionSQL
    {

        static private string conexionCadena = "Server=tcp:appportafolio.database.windows.net,1433;Initial Catalog=prevac;Persist Security Info=False;User ID=portafolioadmin;Password=Matias14+;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection Conexion = new SqlConnection(conexionCadena);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection ConexionCerrar()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }



        private string nombreBaseDatos;
        private string nombreTabla;
        private string cadenaConexion;
        private string cadenaSQL;
        private Boolean esSelect;
        private SqlConnection dbConnection;
        private DataSet dbDataSet;
        private SqlDataAdapter dbDataAdapter;

        public string NombreBaseDatos { get => nombreBaseDatos; set => nombreBaseDatos = value; }
        public string NombreTabla { get => nombreTabla; set => nombreTabla = value; }
        public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
        public string CadenaSQL { get => cadenaSQL; set => cadenaSQL = value; }
        public bool EsSelect { get => esSelect; set => esSelect = value; }
        public SqlConnection DbConnection { get => dbConnection; set => dbConnection = value; }
        public DataSet DbDataSet { get => dbDataSet; set => dbDataSet = value; }
        public SqlDataAdapter DbDataAdapter { get => dbDataAdapter; set => dbDataAdapter = value; }

        //abrir conexion

        public void abrir()
        {
            try
            {
                this.DbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la Conexion " + ex.Message, "Sistema");
            }

        } //Fin abrir

        //cerrar conexion

        public void cerrar()
        {
            try
            {
                this.DbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la Conexion " + ex.Message, "Sistema");
            }

        } //Fin cerrar


        public void conectar()
        {
            if (this.NombreBaseDatos.Length == 0)
            {
                MessageBox.Show("Error nombre base de datos ", "Sistema");
                return;
            }

            if (this.NombreTabla.Length == 0)
            {
                MessageBox.Show("Error nombre tabla ", "Sistema");
                return;
            }

            if (this.cadenaConexion.Length == 0)
            {
                MessageBox.Show("Error cadena conexion ", "Sistema");
                return;
            }

            if (this.CadenaSQL.Length == 0)
            {
                MessageBox.Show("Error cadena sql ", "Sistema");
                return;
            }

            //Se genera instancia de la conexion

            try
            {
                this.DbConnection = new SqlConnection(this.CadenaConexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexion " + ex.Message, "Sistema");
                return;

            }

            this.abrir();

            //Instrucciones SQL

            if (this.EsSelect) //Selec
            {
                this.DbDataSet = new DataSet();
                try
                {
                    this.DbDataAdapter = new SqlDataAdapter(this.CadenaSQL, this.dbConnection);
                    this.DbDataAdapter.Fill(this.DbDataSet, this.NombreTabla);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al cargar dataset " + ex.Message , "Sistema");
                    return;
                }
            }
            else //Insert - Update - Delete
            {
                try
                {
                    SqlCommand variableSQL = new SqlCommand(this.CadenaSQL, this.DbConnection);
                    variableSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error instruccion SQL " + ex.Message, "Sistema");
                    return;
                }


            }

            this.cerrar();

        } //Fin conectar

        public static SqlConnection conexion()
        {
            SqlConnection cn = new SqlConnection("Server=tcp:appportafolio.database.windows.net,1433;Initial Catalog=prevac;Persist Security Info=False;User ID=portafolioadmin;Password=Matias14+;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            cn.Open();

        
            return cn;

            
        }


      
        //public static void Main(String[] args)
        //{
        //    ConexionSQL auxConexion = new ConexionSQL();
        //    auxConexion.NombreBaseDatos = "Prueba";
        //    auxConexion.NombreTabla = "Cliente";
        //    auxConexion.CadenaConexion = "Data Source=DESKTOP-U7RM1GB;Initial Catalog=Prueba;Integrated Security=True";
        //    auxConexion.CadenaSQL = "SELECT * FROM cliente";
        //    auxConexion.EsSelect = true;
        //    auxConexion.conectar();

        //    foreach (DataRow dr in auxConexion.DbDataSet.Tables[auxConexion.NombreTabla].Rows)
        //    {
        //        Console.WriteLine(dr["rut"] + " " + dr["nombre"]);
        //    }

        //    Console.ReadKey();

        //}



    } //Fin Clase
} //Fin namespace
