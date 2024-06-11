using Entidad;
using Logica;
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

namespace Sistema_de_liquidacion.Modales
{
    public partial class mdArchivo : Form
    {
        ReporteService reporteService = new ReporteService();
        private Usuario oUsuario;

        OpenFileDialog dlg = new OpenFileDialog();

        public mdArchivo(Usuario oUsuario)
        {
            InitializeComponent();
            this.oUsuario = oUsuario;
        }

        private void GuardarArchivo()
        {
            if (!ValidarCampos()) { return; }

            try
            {
                byte[] archivo = null;
                Stream MyStream = dlg.OpenFile();
                MemoryStream memoryStream = new MemoryStream();
                MyStream.CopyTo(memoryStream);
                archivo = memoryStream.ToArray();

                Reporte oReporte = new Reporte
                {
                    NombreReporte = txtNombreArchivo.Texts,
                    Documento = archivo,
                    Extension = dlg.SafeFileName,
                    Usuario = new Usuario
                    {
                        IdPersona = oUsuario.IdPersona,
                        Nombre = oUsuario.Nombre
                    },
                };

                var msg = reporteService.Guardar(oReporte);
                MessageBox.Show(msg, "Gestión de reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Gestión de reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool ValidarCampos()
        {
            if (txtRutaArchivo.Texts == "Ruta del archivo")
            {
                MessageBox.Show("Error, ruta del archivo sin establecer", "Gestión de reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtRutaArchivo.Texts == "")
            {
                MessageBox.Show("Error, ruta del archivo sin establecer", "Gestión de reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtNombreArchivo.Texts == "Nombre del archivo")
            {
                MessageBox.Show("Error, nombre del archivo sin establecer", "Gestión de reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtNombreArchivo.Texts == "")
            {
                MessageBox.Show("Error, nombre del archivo sin establecer", "Gestión de reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarArchivo();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscarDoc_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "C:\\Documentos";
            dlg.Filter = "Todos los archivos (*.*)|*.*";
            dlg.FilterIndex = 1;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRutaArchivo.Texts = dlg.FileName;
            }
        }
    }
}
