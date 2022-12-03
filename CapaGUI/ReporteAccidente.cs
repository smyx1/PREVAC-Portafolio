using CapaConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class ReporteAccidente : Form
    {
        public ReporteAccidente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReporteAccidente_Load(object sender, EventArgs e)
        {
            ConexionSQL.conexion();

           
        }

        public DataTable llenar_grid()
        {
            ConexionSQL.conexion();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM reporteAccidente";
            SqlCommand cmd = new SqlCommand(consulta, ConexionSQL.conexion());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConexionSQL.conexion();
            string insertar = "INSERT INTO reporteAccidente (nombreCliente, Rut, Direccion, Area, Fecha, Descripcion, Tarea)VALUES(@nombreCliente,@Rut,@Direccion,@Area,@Fecha,@Descripcion,@Tarea)";
            SqlCommand cmd1 = new SqlCommand(@insertar, ConexionSQL.conexion());
            cmd1.Parameters.AddWithValue("@nombreCliente", txtNombreCliente.Text);
            cmd1.Parameters.AddWithValue("@Rut", txtRut.Text);
            cmd1.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            cmd1.Parameters.AddWithValue("@Area", txtArea.Text);
            cmd1.Parameters.AddWithValue("@Fecha", txtFecha.Text);
            cmd1.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
            cmd1.Parameters.AddWithValue("@Tarea", txtTareas.Text);


            cmd1.ExecuteNonQuery();
            MessageBox.Show("Reporte ingresado con éxito");

            
        }
    }
}
