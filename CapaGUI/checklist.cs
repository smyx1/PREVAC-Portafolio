using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class checklist : Form
    {
        public checklist()
        {
            InitializeComponent();
        }
        private void btndescargar_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Cliente", txtCliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Profesional", txtProfesiona.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvChecklist.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cliente"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Fecha"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Profesional"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Ubicacion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Comentario"].Value.ToString() + "</td>";

                filas += "</tr>";
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());



            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.PREVAC, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }

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

        private void checklist_load(object sender, EventArgs e)
        {
            dgvChecklist.Columns.Add("Cliente", "Cliente");
            dgvChecklist.Columns.Add("Fecha", "Fecha");
            dgvChecklist.Columns.Add("Profesional", "Profesional");
            dgvChecklist.Columns.Add("Ubicacion", "Ubicacion");
            dgvChecklist.Columns.Add("Comentario", "Comentario");
        }

        //private void btnagregar_Click(object sender, EventArgs e)
        //{
        //    int indice_fila = dgvproductos.Rows.Add();
        //    DataGridViewRow row = dgvproductos.Rows[indice_fila];

        //    row.Cells["Cantidad"].Value = txtcantidad.Text;
        //    row.Cells["Descripcion"].Value = txtdescripcion.Text;
        //    row.Cells["PrecioUnitario"].Value = txtprecio.Text;
        //    row.Cells["Importe"].Value = decimal.Parse(txtcantidad.Text) * decimal.Parse(txtprecio.Text);
        //}

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            int indice_fila = dgvChecklist.Rows.Add();
            DataGridViewRow row = dgvChecklist.Rows[indice_fila];

            row.Cells["Cliente"].Value = txtCliente.Text;
            row.Cells["Fecha"].Value = txtFecha.Text;
            row.Cells["Profesional"].Value = txtProfesiona.Text;
            row.Cells["Ubicacion"].Value = txtcantidad.Text;
            row.Cells["Comentario"].Value = txtComentario.Text;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
        }

        private void txtComentario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
