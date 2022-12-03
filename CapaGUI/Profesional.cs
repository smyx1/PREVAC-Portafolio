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
    public partial class Profesional : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        public Profesional(string nombre)
        {
            InitializeComponent();
            lblmensajeProfesional.Text = nombre;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
           new AgregarUsuario().Show();
        }
        public void CloseApp()
        {
            if (MessageBox.Show("¿Está seguro de cerrar la aplicación?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();//Cierra toda la aplicación finalizando todos los procesos.
        }
        private void X_Click(object sender, EventArgs e)
        {
            CloseApp();
        }

        private void Profesional_Load(object sender, EventArgs e)
        {

        }

        private void btnDetalles_Click_1(object sender, EventArgs e)
        {
            new checklist().Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AbrirFormularios<checklist>();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularios<AccidentesReportados>();
        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
