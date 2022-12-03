using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaConexion;
using System.Data;
using System.Data.SqlClient;

using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using iTextSharp.text;
using iTextSharp.tool.xml.css.parser.state;
using System.util;
using CapaDTO;

namespace CapaGUI
{

    public partial class AgregarUsuario : Form
    {


        public AgregarUsuario()
        {
            InitializeComponent();
        }

        

        public void CloseApp()
        {
            if (MessageBox.Show("¿Está seguro de cerrar la aplicación?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();//Cierra toda la aplicación finalizando todos los procesos.
            else
            {
                Close();
            }
        }
        private void X_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        tipo_usuario tpu = new tipo_usuario();
       
        private void CheckListProfesional_Load(object sender, EventArgs e)
        {
            

            //dataGridView1.Columns.Add("Cliente", "Cliente");
            //dataGridView1.Columns.Add("Fecha", "Fecha");
            //dataGridView1.Columns.Add("Profesional", "Profesional");
            //dataGridView1.Columns.Add("Ubicacion", "Ubicacion");
            //dataGridView1.Columns.Add("Comentario", "Comentario");

            ConexionSQL.conexion();

            dataGridView1.DataSource = llenar_grid();

            

        }

        public class Limpiar
        { 
        public void BorrarCampos(Control control)
        {
            foreach(var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if(txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
            }
        }
        }

        public DataTable llenar_grid()
        {
            ConexionSQL.conexion();
            DataTable dt = new DataTable();
            string consulta = "SELECT *  FROM login";
            SqlCommand cmd = new SqlCommand(consulta, ConexionSQL.conexion());
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            

            //dataGridView1.Columns[0].HeaderText = "Id";
            //AGREGAR LA MODIFICACION DE NOMBRE DE COLUMNAS
            return dt;
            
            
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            
            ConexionSQL.conexion();
            string insertar = "INSERT INTO login (Nombre, Usuario, Password, Tipo_Usuario)VALUES(@Nombre,@Usuario,@Password,@Tipo_Usuario)";
            SqlCommand cmd1 = new SqlCommand    (@insertar, ConexionSQL.conexion());
            cmd1.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd1.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            cmd1.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd1.Parameters.AddWithValue("@Tipo_Usuario", cboUsuario.Text);

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Usuario Agregado con éxito");

            dataGridView1.DataSource = llenar_grid();

            
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblTipoUsuario.Text = cboUsuario.Text;
        }
        
    }
}
