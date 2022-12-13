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
using CapaConexion;
using CapaDTO;


namespace CapaGUI
{
    public partial class registrarClienteContrato : Form
    {
        public registrarClienteContrato()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registrarClienteContrato_Load(object sender, EventArgs e)
        {
          

            ListarRol();
            ListarEstado();
        }

        private void ListarRol()
        {
            registrarCliente objProd = new registrarCliente();
            cmbRol.DataSource = objProd.ListarRol();
            cmbRol.DisplayMember = "rol";
            cmbRol.ValueMember = "nombre_rol";
        }

        private void ListarEstado()
        {
            registrarCliente objPro = new registrarCliente();
            cmbContrato.DataSource = objPro.ListarEstado();
            cmbContrato.DisplayMember = "Estado";
            cmbContrato.ValueMember = "nombre_estado";

            
        }
        public DataTable llenar_grid()
        {
            ConexionSQL.conexion();
            DataTable dt = new DataTable();
            string consulta = "SELECT nombre, apellido_p, apellido_m, fecha_nacimiento, correo, telefono, contrasena, rut_usuario from usuario";
            SqlCommand cmd = new SqlCommand(consulta, ConexionSQL.conexion());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);



            //dataGridView1.Columns[0].HeaderText = "Id";
            //AGREGAR LA MODIFICACION DE NOMBRE DE COLUMNAS
            return dt;


        }
        public class Limpiar
        {
            public void BorrarCampos(Control control)
            {
                foreach (var txt in control.Controls)
                {
                    if (txt is TextBox)
                    {
                        ((TextBox)txt).Clear();
                    }
                    else if (txt is ComboBox)
                    {
                        ((ComboBox)txt).SelectedIndex = 0;
                    }
                }
            }
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblrol_Click(object sender, EventArgs e)
        {

        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario y contrato agregado exitosamente");
            dataGridView1.DataSource = llenar_grid();
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
        }
    }
}
