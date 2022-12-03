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
    public partial class AccidentesReportados : Form
    {
        public AccidentesReportados()
        {
            InitializeComponent();
        }

        private void AccidentesReportados_Load(object sender, EventArgs e)
        {
            ConexionSQL.conexion();

            dataGridView1.DataSource = llenar_grid();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
