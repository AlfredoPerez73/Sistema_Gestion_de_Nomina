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
        private Usuario oUsuario;
        Reporte reporte = new Reporte();
        ReporteService reporteService = new ReporteService();
        private bool allowEdit = false;

        public FrmReporte(Usuario oUsuario)
        {
            InitializeComponent();
            this.oUsuario = oUsuario;
        }

        private void GuardarRegistro()
        {
            mdArchivo mdArchivo = new mdArchivo(oUsuario);
            mdArchivo.ShowDialog();
            CargarRegistro();

        }
        
        private void VerArchio()
        {
            try
            {
                if (Convert.ToInt32(txtIdReporte.Texts) != 0)
                {
                    int IdReporte = Convert.ToInt32(txtIdReporte.Texts);
                    reporte.IdReporte = IdReporte;

                    var list = reporteService.CargarRegistroPorId(IdReporte);

                    foreach (Reporte reporte in list)
                    {
                        string direccion = AppDomain.CurrentDomain.BaseDirectory;
                        string carpeta = direccion + "/temp/";
                        string UbiCompleta = carpeta + reporte.Extension;

                        if (!Directory.Exists(carpeta))
                        {
                            Directory.CreateDirectory(carpeta);
                        }
                        if (File.Exists(UbiCompleta))
                        {
                            Directory.Delete(UbiCompleta);
                        }
                        File.WriteAllBytes(UbiCompleta, reporte.Documento);
                        Process.Start(UbiCompleta);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe seleccionar un reporte", "Gestion de reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void EliminarArchivo()
        {
            if (Convert.ToInt32(txtIdReporte.Texts) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar este producto?", "Gestion de usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Reporte reporte = new Reporte
                    {
                        IdReporte = Convert.ToInt32(txtIdReporte.Texts)
                    };
                    if (reporte != null)
                    {
                        var msg = reporteService.EliminarRegistros(reporte);
                        MessageBox.Show(msg, "Gestion de reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarRegistro();
                    }
                    else
                    {
                        var msg = reporteService.EliminarRegistros(reporte);
                        MessageBox.Show(msg, "Gestion de reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void CargarRegistro()
        {
            Visualizer(reporteService.CargarRegistro());
        }

        private void Visualizer(List<Reporte> lista)
        {
            tblRegistroReporte.Rows.Clear();

            if (lista != null)
            {
                foreach (var item in lista)
                {
                    int index = tblRegistroReporte.Rows.Add();
                    DataGridViewRow row = tblRegistroReporte.Rows[index];
                    row.Cells["IdReporte"].Value = item.IdReporte;
                    row.Cells["IdUsuario2"].Value = item.Usuario.IdPersona;
                    row.Cells["Usuario2"].Value = item.Usuario.Nombre;
                    row.Cells["Reporte2"].Value = item.NombreReporte;
                    row.Cells["Documento"].Value = item.Documento;
                    row.Cells["Extension"].Value = item.Extension;
                    row.Cells["FechaRegistro"].Value = item.FechaRegistro.ToString("d");
                }
            }
        }

        private void MessageTable()
        {
            if (tblRegistroReporte.Rows.Count > 0)
            {
                lbltbl.Visible = false;
            }
            else
            {
                lbltbl.Visible = true;
            }

        }

        private void FiltroReporte()
        {
            var filtro = txtBuscar.Texts;
            var lista = reporteService.BuscarX(filtro);
            Visualizer(lista);
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel2, 30);
            BorderRadiusPanel(panel3, 30);
            BorderRadiusPanel(panel4, 15);
            BorderRadiusPanel(panel5, 15);
            BorderRadiusPanel(panel7, 20);
            BorderRadiusPanel(panel9, 20);

            CargarRegistro();
            MessageTable();
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

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            if (tblRegistroReporte.Columns[e.ColumnIndex].Name == "btnSEliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int IdReporte = Convert.ToInt32(tblRegistroReporte.Rows[index].Cells["IdReporte"].Value);

                        Reporte reporte = new Reporte
                        {
                            IdReporte = IdReporte,
                        };

                        var msg = reporteService.EliminarRegistros(reporte);
                        MessageBox.Show(msg, "Gestion de reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tblRegistroReporte.Rows.RemoveAt(index);
                    }
                }
            }
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
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.circulo_marca_x_sin_findo.Width;
                var h = Properties.Resources.circulo_marca_x_sin_findo.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.circulo_marca_x_sin_findo, new Rectangle(x, y, w, h));
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
            CellContentClick(sender, e);
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "Buscar:")
            { Visualizer(reporteService.CargarRegistro()); }
            else if (txtBuscar.Texts == "") { Visualizer(reporteService.CargarRegistro()); }
            else
            { FiltroReporte(); }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "Buscar:")
            {
                txtBuscar.Texts = "";
                txtBuscar.ForeColor = Color.LightGray;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "")
            {
                txtBuscar.Texts = "Buscar:";
                txtBuscar.ForeColor = Color.LightGray;
            }
        }

        private void txtReporte_Enter(object sender, EventArgs e)
        {
            if (txtReporte.Texts == "Nombre de reporte")
            {
                txtReporte.Texts = "";
                txtReporte.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtReporte_Leave(object sender, EventArgs e)
        {
            if (txtReporte.Texts == "")
            {
                txtReporte.Texts = "Nombre de reporte";
                txtReporte.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            if (txtDocumento.Texts == "Documento")
            {
                txtDocumento.Texts = "";
                txtDocumento.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (txtDocumento.Texts == "")
            {
                txtDocumento.Texts = "Documento";
                txtDocumento.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtFechaRegistro_Enter(object sender, EventArgs e)
        {
            if (txtFechaRegistro.Texts == "Fecha de registro")
            {
                txtFechaRegistro.Texts = "";
                txtFechaRegistro.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtFechaRegistro_Leave(object sender, EventArgs e)
        {
            if (txtFechaRegistro.Texts == "Fecha de registro")
            {
                txtFechaRegistro.Texts = "";
                txtFechaRegistro.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtExtension_Enter(object sender, EventArgs e)
        {
            if (txtExtension.Texts == "Extension")
            {
                txtExtension.Texts = "";
                txtExtension.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtExtension_Leave(object sender, EventArgs e)
        {
            if (txtExtension.Texts == "")
            {
                txtExtension.Texts = "Extension";
                txtExtension.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtFechaRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }
    }
}
