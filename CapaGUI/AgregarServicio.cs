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
using CapaNegocio;


namespace CapaGUI
{
    public partial class AgregarServicio : Form
    {
        registrarServicio objProducto = new registrarServicio();
        public AgregarServicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();    
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

        public void CargarDgvProfesional()
        {

            ////CargarDgvProfesional(Convert.ToInt32(cboProfesional.SelectedValue.ToString()));
            //List<cDTO.rol> datosProfesional = DatosProfesional();
            ////datosProfesional.Insert(0, new cDTO.rol("", "Seleccione rol"));
            //cboProfesional.ValueMember = "id_rol";
            //cboProfesional.DisplayMember = "nombre_rol";
            //cboProfesional.DataSource = datosProfesional;
        }

        public DataTable llenar_grid()
        {
            ConexionSQL.conexion();
            DataTable dt = new DataTable();
            string consulta = "SELECT detalle_asesoria, fecha, extra, profesional, tema, ubicacion, duracion from detalle_servicio";
            SqlCommand cmd = new SqlCommand(consulta, ConexionSQL.conexion());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);



            //dataGridView1.Columns[0].HeaderText = "Id";
            //AGREGAR LA MODIFICACION DE NOMBRE DE COLUMNAS
            return dt;


        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CargarDgvProfesional(Convert.ToInt32(cboProfesional.SelectedValue.ToString()));
            //List<cDTO.rol> datosProfesional = DatosProfesional();
            //datosProfesional.Insert(0, new cDTO.rol("", "Seleccione rol"));
            //cboProfesional.ValueMember = "id_rol";
            //cboProfesional.DisplayMember = "nombre_rol";
            //cboProfesional.DataSource = datosProfesional;

            CargarDgvProfesional();
        }

        //public List<cDTO.rol> DatosProfesional()
        //{
        //    //negocioProfesional negocioProfesional = new negocioProfesional();
        //    //List<cDTO.rol> datosProfesional = negocioProfesional.LeerProfesional();
        //    //return datosProfesional;
        //}

        private void AgregarServicio_Load(object sender, EventArgs e)
        {
            ListarServicios();
            TipoServicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagridServicios.DataSource = llenar_grid();
        }

        
                private void button2_Click(object sender, EventArgs e)
        {
            //objProducto.InsertarServicio(Convert.ToString(txtDetalle.Text),Convert.ToDateTime(dateTimeActividad.Value),Convert.ToString(txtExtra.Text),Convert.ToString(txtTema.Text),Convert.ToString(txtUbicacion.Text),Convert.ToInt16(txtDuracion.Text));
            MessageBox.Show("Servicio Agregado con éxito");
            datagridServicios.DataSource = llenar_grid();
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
        }

        private void ListarServicios()
        {
            registrarServicio objProd = new registrarServicio();
            cboProfesional.DataSource = objProd.ListarServicios();
            cboProfesional.DisplayMember = "Profesional";
            cboProfesional.ValueMember = "profesional";
        }

        private void TipoServicio()
        {
            registrarServicio objProd = new registrarServicio();
            cboTipoServicio.DataSource = objProd.TipoServicio();
            cboTipoServicio.DisplayMember = "Tipo Servicio";
            cboTipoServicio.ValueMember = "nombre_tipo_servicio";
        }

        private void datagridServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
