using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class Usuario : Form
    {
        public Usuario(string nombre)
        {
            InitializeComponent();
            lblmensajeUsuario.Text = nombre;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        private void lblmensajeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormularios<FormularioAbrir>() where FormularioAbrir : Form, new()
        {
            Form Formularios;

            Formularios = PanelForm.Controls.OfType<FormularioAbrir>().FirstOrDefault();

            if (Formularios == null)
            {
                Formularios = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };

                PanelForm.Controls.Add(Formularios);

                PanelForm.Tag = Formularios;

                Formularios.Show();

                Formularios.BringToFront();
            }
            else
            {
                Formularios.BringToFront();
            }
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLateral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();//Cierra toda la aplicación finalizando todos los procesos.
            new Login().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAccidente_Click(object sender, EventArgs e)
        {
            AbrirFormularios<ReporteAccidente>();
        }
    }
}
