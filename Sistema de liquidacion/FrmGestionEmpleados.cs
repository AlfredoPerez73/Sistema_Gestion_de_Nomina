using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidad;
using Sistema_de_liquidacion.Modales;
using System.Collections;
using static Logica.LiquidacionService;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Windows.Shapes;

namespace Sistema_de_liquidacion
{
    public partial class FrmGestionEmpleados : Form
    {
        private Usuario oUsuario;
        ReporteService reporteService = new ReporteService();
        Reporte oReporte = new Reporte();

        private DetalleLiquidacionService detalleLiquidacionService = new DetalleLiquidacionService();

        public FrmGestionEmpleados(Usuario oUsuario)
        {
            InitializeComponent();
            this.oUsuario = oUsuario;
        }

        private DetalleLiquidacion RegistroLiquidaciones()
        {
            DetalleLiquidacion detalleLiquidacion = new DetalleLiquidacion
            {
                Codigo = txtCodigo.Texts,
                empleado = new Empleado
                {
                    IdPersona = Convert.ToInt32(txtIdProducto.Texts),
                    Documento = txtDocumento2.Texts,
                    Nombre = txtNombre.Texts,
                    Cargo = new Cargo
                    {
                        CargoDesempeñado = cboCargo.Texts,
                    },
                    Contrato = new Contrato
                    {

                        Salario = Convert.ToDecimal(txtSalario2.Texts),
                    },
                    Estado = txtEstado.Texts,
                },
                liquidacion = new Liquidacion
                {
                    IdFactura = Convert.ToInt32(txtLiquidacion.Texts),
                    Año = Convert.ToInt32(txtAño.Texts),
                    Mes = Convert.ToInt32(txtMes.Texts),

                },
                usuario = new Usuario
                {
                    IdPersona = oUsuario.IdPersona,
                    Nombre = oUsuario.Nombre,
                },
                DiasTrabajados = Convert.ToInt32(txtDiasTrabajados.Texts),
                HorasExtras = Convert.ToInt32(txtHorasExtras.Texts),
            };

            detalleLiquidacion.ActualizarDetalles(detalleLiquidacion.empleado, detalleLiquidacion.liquidacion);

            return detalleLiquidacion;
        }

        private void GuardarRegistroDetalleLiquidacion()
        {
            if (!ValidarCampos()) { return; }

            var detalleLiquidacion = RegistroLiquidaciones();
            if (detalleLiquidacion != null)
            {
                var VAL = detalleLiquidacionService.BuscarIdLiquidacion(Convert.ToInt32(txtAño.Texts),
                                                                        Convert.ToInt32(txtMes.Texts),
                                                                        txtIdProducto.Texts,
                                                                        Convert.ToInt32(txtLiquidacion.Texts));
                if (!VAL)
                {
                    var msg = detalleLiquidacionService.Guardar(detalleLiquidacion);
                    MessageBox.Show(msg, "Gestion de liquidaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarRegistro();
                    Nuevo();
                }
                else
                {
                    MessageBox.Show($"La liquidacion con el producto identificado {txtIdProducto.Texts} " +
                                    $"el mes {txtMes.Texts} en el año {txtAño.Texts} ya existe!",
                                    "Gestion de liquidaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var msg = detalleLiquidacionService.Guardar(detalleLiquidacion);
                MessageBox.Show(msg, "Gestion de liquidaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo();
            }
        }

        private bool ValidarCampos()
        {
            if (txtNombre.Texts == "" || txtNombre.Texts == "Nombre")
            {
                MessageBox.Show("Por favor llenar el campo de nombre", "Gestion de liquidacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtSalario2.Texts == "" || txtSalario2.Texts == "Salario")
            {
                MessageBox.Show("Por favor llenar el campo de salario", "Gestion de liquidacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtAño.Texts == "" || txtAño.Texts == "Año")
            {
                MessageBox.Show("Por favor llenar el campo de año", "Gestion de liquidacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtMes.Texts == "" || txtMes.Texts == "Mes")
            {
                MessageBox.Show("Por favor llenar el campo de mes", "Gestion de liquidacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }


        private void Nuevo()
        {
            txtDocumento2.Texts = "Documento";
            txtNombre.Texts = "Nombre";
            txtSalario2.Texts = "Salario";
            txtDetalle.Focus();
            txtLiquidacion.Texts = "Id de liquidacion";
            txtDetalle.Texts = "Id de detalle";
            txtAño.Texts = "Año";
            txtMes.Texts = "Mes";
        }

        private void CargarEstados()
        {
            cboFiltroEstado.Items.Clear();
            cboFiltroEstado.Items.Add("");
            cboFiltroEstado.Items.Add("ACTIVO");
            cboFiltroEstado.Items.Add("INACTIVO");
            cboFiltroEstado.SelectedIndex = 0;
        }

        private void FiltroProducto()
        {

        }

        private void FiltroProductoEstado()
        {

        }

        private void FiltrarLiquidaciones()
        {

        }

        private void CargarRegistro()
        {
            Visualizer(detalleLiquidacionService.CargarRegistro());
        }

        private void Visualizer(List<DetalleLiquidacion> lista)
        {
            tblRegistroLiquidaciones.Rows.Clear();

            if (lista != null)
            {
                foreach (var item in lista)
                {
                    int index = tblRegistroLiquidaciones.Rows.Add();
                    DataGridViewRow row = tblRegistroLiquidaciones.Rows[index];
                    row.Cells["IdDetalle"].Value = item.IdDetalle;
                    row.Cells["Codigo"].Value = item.Codigo;
                    row.Cells["IdFactura2"].Value = item.liquidacion.IdFactura;
                    row.Cells["Año2"].Value = item.liquidacion.Año;
                    row.Cells["Mes2"].Value = item.liquidacion.Mes;
                    row.Cells["DiasTrabajados"].Value = item.DiasTrabajados;
                    row.Cells["HorasTrabajadas"].Value = item.HorasExtras;
                    row.Cells["ValHorasExtras"].Value = item.ValorHorasExtra.ToString("C");
                    row.Cells["IdProducto2"].Value = item.empleado.IdPersona;
                    row.Cells["Documento2"].Value = item.empleado.Documento;
                    row.Cells["Nombre"].Value = item.empleado.Nombre;
                    row.Cells["Cargo2"].Value = item.empleado.Cargo.CargoDesempeñado;
                    row.Cells["Salario2"].Value = item.empleado.Contrato.Salario.ToString("C");
                    row.Cells["Estado2"].Value = item.empleado.Estado;
                    row.Cells["Salud"].Value = item.Salud.ToString("C");
                    row.Cells["Pension"].Value = item.Pension.ToString("C");
                    row.Cells["AuxT"].Value = item.AuxTransporte.ToString("C");
                    row.Cells["Bonificacion"].Value = item.BonificacionServicios.ToString("C");
                    row.Cells["PrimaServicios"].Value = item.PrimaServicios.ToString("C");
                    row.Cells["AuxAlimentacion"].Value = item.AuxAlimentacion.ToString("C");
                    row.Cells["PrimaNavidad"].Value = item.PrimaNavidad.ToString("C");
                    row.Cells["Devengado"].Value = item.Devengado.ToString("C");
                    row.Cells["IdUsuario"].Value = item.usuario.IdPersona;
                    row.Cells["Usuario"].Value = item.usuario.Nombre;
                    row.Cells["FechaRegistro3"].Value = item.FechaRegistro.ToString("d");

                }
            }
        }

        public string GenerarContenidoHTML()
        {
            string read_Html = null;
            return read_Html;
        }

        public byte[] GenerarPDF(string contenidoHtml)
        {
            using (MemoryStream stream = new MemoryStream())
            {

                return stream.ToArray();
            }
        }

        public void GuardarPDFBD()
        {

        }

        public string GuardarPDFLocal(byte[] pdfBytes)
        {


            return null;
        }


        private void FrmGestionEmpleados_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel1, 20);
            BorderRadiusPanel(panel2, 15);
            BorderRadiusPanel(panel3, 20);
            BorderRadiusPanel(panel4, 15);
            BorderRadiusPanel(panel5, 15);
            BorderRadiusPanel(panel6, 20);
            BorderRadiusPanel(panel9, 20);

            CargarEstados();
            CargarRegistro();

        }

        private void btnGuardarLiquidacion_Click(object sender, EventArgs e)
        {
            GuardarRegistroDetalleLiquidacion();
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {

        }

        private void tblRegistroLiquidaciones_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void cboFiltroEstado_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FiltroProductoEstado();
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {

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

        private void btnBuscarEmpleado_Click_1(object sender, EventArgs e)
        {
            using (var modal = new mdEmpleado())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdProducto.Texts = modal.producto.IdPersona.ToString();
                    txtDocumento2.Texts = modal.producto.Documento.ToString();
                    txtNombre.Texts = modal.producto.Nombre.ToString();
                    txtcargo.Texts = modal.producto.Cargo.IdCargo.ToString();
                    cboCargo.Texts = modal.producto.Cargo.CargoDesempeñado.ToString();
                    fecha.Texts = modal.producto.Cargo.FechaRegistro.ToString("d");
                    txtSalario2.Texts = modal.producto.Contrato.Salario.ToString();
                    txtEstado.Texts = modal.producto.Estado.ToString();
                    fecha2.Texts = modal.producto.FechaRegistro.ToString("d");
                }
            }
        }

        private void txtLiquidacion_Enter(object sender, EventArgs e)
        {
            if (txtLiquidacion.Texts == "Codigo de liquidacion")
            {
                txtLiquidacion.Texts = "";
                txtLiquidacion.ForeColor = Color.LightGray;
            }
        }

        private void txtLiquidacion_Leave(object sender, EventArgs e)
        {
            if (txtLiquidacion.Texts == "")
            {
                txtLiquidacion.Texts = "Codigo de liquidacion";
                txtLiquidacion.ForeColor = Color.LightGray;
            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Texts == "Codigo de detalle de liquidacion")
            {
                txtCodigo.Texts = "";
                txtCodigo.ForeColor = Color.LightGray;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Texts == "")
            {
                txtCodigo.Texts = "Codigo de detalle de liquidacion";
                txtCodigo.ForeColor = Color.LightGray;
            }
        }

        private void txtAño_Enter(object sender, EventArgs e)
        {
            if (txtAño.Texts == "Año")
            {
                txtAño.Texts = "";
                txtAño.ForeColor = Color.LightGray;
            }
        }

        private void txtAño_Leave(object sender, EventArgs e)
        {
            if (txtAño.Texts == "")
            {
                txtAño.Texts = "Año";
                txtAño.ForeColor = Color.LightGray;
            }
        }

        private void txtMes_Enter(object sender, EventArgs e)
        {
            if (txtMes.Texts == "Mes")
            {
                txtMes.Texts = "";
                txtMes.ForeColor = Color.LightGray;
            }
        }

        private void txtMes_Leave(object sender, EventArgs e)
        {
            if (txtMes.Texts == "")
            {
                txtMes.Texts = "Mes";
                txtMes.ForeColor = Color.LightGray;
            }
        }

        private void txtDiasTrabajados_Enter(object sender, EventArgs e)
        {
            if (txtDiasTrabajados.Texts == "Dias trabajados")
            {
                txtDiasTrabajados.Texts = "";
                txtDiasTrabajados.ForeColor = Color.LightGray;
            }
        }

        private void txtDiasTrabajados_Leave(object sender, EventArgs e)
        {
            if (txtDiasTrabajados.Texts == "")
            {
                txtDiasTrabajados.Texts = "Dias trabajados";
                txtDiasTrabajados.ForeColor = Color.LightGray;
            }
        }

        private void txtHorasExtras_Enter(object sender, EventArgs e)
        {
            if (txtHorasExtras.Texts == "Horas extras")
            {
                txtHorasExtras.Texts = "";
                txtHorasExtras.ForeColor = Color.LightGray;
            }
        }

        private void txtHorasExtras_Leave(object sender, EventArgs e)
        {
            if (txtHorasExtras.Texts == "")
            {
                txtHorasExtras.Texts = "Horas extras";
                txtHorasExtras.ForeColor = Color.LightGray;
            }
        }

        private void txtDocumento2_Enter(object sender, EventArgs e)
        {
            if (txtDocumento2.Texts == "Documento")
            {
                txtDocumento2.Texts = "";
                txtDocumento2.ForeColor = Color.LightGray;
            }
        }

        private void txtDocumento2_Leave(object sender, EventArgs e)
        {
            if (txtDocumento2.Texts == "")
            {
                txtDocumento2.Texts = "Documento";
                txtDocumento2.ForeColor = Color.LightGray;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Texts == "Nombre")
            {
                txtNombre.Texts = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Texts == "")
            {
                txtNombre.Texts = "Nombre";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void cboCargo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCargo.Texts == "Cargo desempeñado")
            {
                cboCargo.Texts = "";
                cboCargo.ForeColor = Color.LightGray;
            }
        }

        private void txtSalario2_Enter(object sender, EventArgs e)
        {
            if (txtSalario2.Texts == "Salario")
            {
                txtSalario2.Texts = "";
                txtSalario2.ForeColor = Color.LightGray;
            }
        }

        private void txtSalario2_Leave(object sender, EventArgs e)
        {
            if (txtSalario2.Texts == "")
            {
                txtSalario2.Texts = "Salario";
                txtSalario2.ForeColor = Color.LightGray;
            }
        }

        private void txtEstado_Enter(object sender, EventArgs e)
        {
            if (txtEstado.Texts == "Estado")
            {
                txtEstado.Texts = "";
                txtEstado.ForeColor = Color.LightGray;
            }
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            if (txtEstado.Texts == "")
            {
                txtEstado.Texts = "Estado";
                txtEstado.ForeColor = Color.LightGray;
            }
        }

        private void cboFiltroEstado_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            FiltroProductoEstado();
        }

        private void dpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            FiltrarLiquidaciones();
        }

        private void dpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            FiltrarLiquidaciones();
        }
    }
}
