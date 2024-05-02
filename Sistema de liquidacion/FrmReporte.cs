using Entidad;
using Logica;
using Sistema_de_liquidacion.Modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_liquidacion
{
    public partial class FrmReporte : Form
    {
        Reporte reporte = new Reporte();
        ReporteService reporteService = new ReporteService();

        public FrmReporte()
        {
            InitializeComponent();
        }

        private void GuardarRegistro()
        {
            mdArchivo mdArchivo = new mdArchivo();
            mdArchivo.ShowDialog();
        }
        
        private void VerArchio()
        { 

        }

        private void EliminarArchivo()
        {

        }

        private void CargarRegistroReportes(List<Reporte> lista)
        {
            tblRegistroReporte.Rows.Clear();

            if (lista != null)
            {
                foreach (var producto in lista)
                {
                    int index = tblRegistroReporte.Rows.Add();
                    DataGridViewRow row = tblRegistroReporte.Rows[index];
                    row.Cells["IdReporte"].Value = producto.IdReporte;
                    row.Cells["IdUsuario2"].Value = producto.Usuario.IdPersona;
                    row.Cells["Usuario2"].Value = producto.Usuario.Nombre;
                    row.Cells["Reporte2"].Value = producto.NombreReporte;
                    row.Cells["Documento"].Value = producto.Documento;
                    row.Cells["Extension"].Value = producto.Extension;
                    row.Cells["FechaRegistro"].Value = producto.FechaRegistro.ToString("d");
                }
            }
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel2, 20);
            BorderRadiusPanel(panel3, 20);
            BorderRadiusPanel(panel4, 15);
            BorderRadiusPanel(panel5, 15);
            BorderRadiusPanel(panel7, 20);
            BorderRadiusPanel(panel9, 20);

        }

        private void BorderRadiusPanel(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
            path.AddLine(radio, 0, panel.Width - radio, 0);
            path.AddArc(panel.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);
            path.AddLine(panel.Width, radio, panel.Width, panel.Height - radio);
            path.AddArc(panel.Width - radio * 2, panel.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddLine(panel.Width - radio, panel.Height, radio, panel.Height);
            path.AddArc(0, panel.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void tblRegistroReporte_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check_circle.Width;
                var h = Properties.Resources.check_circle.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_circle, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void btnGuardarReporte_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarArchivo();
        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            VerArchio();
        }

        private void tblRegistroReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistroReporte.Columns[e.ColumnIndex].Name == "btnSeleccionar2")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    btnGuardarReporte.Enabled = false;
                    txtIdReporte.Texts = tblRegistroReporte.Rows[index].Cells["IdReporte"].Value.ToString();
                    txtReporte.Texts = tblRegistroReporte.Rows[index].Cells["Reporte2"].Value.ToString();
                    txtDocumento.Texts = tblRegistroReporte.Rows[index].Cells["Documento"].Value.ToString();
                    txtExtension.Texts = tblRegistroReporte.Rows[index].Cells["Extension"].Value.ToString();
                    txtFechaRegistro.Texts = tblRegistroReporte.Rows[index].Cells["FechaRegistro"].Value.ToString();
                }
            }
        }
    }
}
