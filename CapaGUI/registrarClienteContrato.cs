using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
