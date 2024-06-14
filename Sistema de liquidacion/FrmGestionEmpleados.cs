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
using System.Drawing.Drawing2D;
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
        private Reporte oReporte = new Reporte();
        private bool allowEdit = false;

        private DetalleLiquidacionService detalleLiquidacionService = new DetalleLiquidacionService();
        private ReporteService reporteService = new ReporteService();
        private EmpleadoService empleadoService = new EmpleadoService();

        public FrmGestionEmpleados(Usuario oUsuario)
        {
            InitializeComponent();
            this.oUsuario = oUsuario;
        }

        private DetalleLiquidacion RegistroLiquidaciones()
        {
            try
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
                            TipoContrato = cboContrato.Texts,
                            Salario = Convert.ToDecimal(txtSalario2.Texts),
                        },
                        Estado = txtEstado.Texts,
                    },
                    liquidacion = new Liquidacion
                    {
                        IdFactura = Convert.ToInt32(txtLiquidacion.Texts),
                        Año = dpFechaActual.Value.Year,
                        Mes = dpFechaActual.Value.Month,

                    },
                    usuario = new Usuario
                    {
                        IdPersona = oUsuario.IdPersona,
                        Nombre = oUsuario.Nombre,
                    },
                    DiasTrabajados = Convert.ToInt32(txtDiasTrabajados.Texts),
                    HorasExtras = Convert.ToInt32(txtHorasExtras.Texts),
                };

                detalleLiquidacion.ActualizarDetalles();

                return detalleLiquidacion;
            }
            catch (FormatException)
            {
                return null;
            }
        }

        private void GuardarRegistroDetalleLiquidacion()
        {
            if (!ValidarCampos()) { return; }

            var detalleLiquidacion = RegistroLiquidaciones();
            if (detalleLiquidacion != null)
            {
                var VAL = detalleLiquidacionService.BuscarIdLiquidacion(dpFechaActual.Value.Year,
                                                                        dpFechaActual.Value.Month,
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
                                    $"el mes {dpFechaActual.Value.Month} en el año {dpFechaActual.Value.Year} ya existe!",
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
            cboCargo.Texts = "Cargo desempeñado";
            cboContrato.Texts = "Contrato";
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
            var filtro = txtBuscar.Texts;
            var lista = detalleLiquidacionService.BuscarX(filtro);
            Visualizer(lista);
        }

        private void FiltroProductoEstado()
        {
            if (cboFiltroEstado.SelectedIndex > 0)
            {
                string estadoSeleccionado = cboFiltroEstado.SelectedItem.ToString();
                var lista = detalleLiquidacionService.FiltroEstado(estadoSeleccionado.ToUpper());
                Visualizer(lista);
            }
            else if (cboFiltroEstado.SelectedIndex == 0)
            { Visualizer(detalleLiquidacionService.CargarRegistro()); }
        }

        private void FiltrarLiquidaciones()
        {
            DateTime fechaInicio = dpFechaInicial.Value;
            DateTime fechaFin = dpFechaFinal.Value;
            var resultado = detalleLiquidacionService.FiltroLiquidaciones(fechaInicio, fechaFin);
            Visualizer(resultado);
        }

        private void BuscarEmpleado(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var oEmpleado = empleadoService.BuscarEmpleado(textBox1.Text);
                if (oEmpleado != null)
                {
                    textBox1.BackColor = Color.Honeydew;

                    txtDocumento2.BackColor = Color.Honeydew;
                    txtDocumento2.BorderColor = Color.Honeydew;
                    txtIdProducto.Texts = oEmpleado.IdPersona.ToString();
                    txtDocumento2.Texts = oEmpleado.Documento.ToString();
                    txtNombre.Texts = oEmpleado.Nombre.ToString();
                    txtcargo.Texts = oEmpleado.Cargo.IdCargo.ToString();
                    cboCargo.Texts = oEmpleado.Cargo.CargoDesempeñado.ToString();
                    cboContrato.Texts = oEmpleado.Contrato.TipoContrato.ToString();
                    fecha.Texts = oEmpleado.Cargo.FechaRegistro.ToString("d");
                    txtSalario2.Texts = oEmpleado.Contrato.Salario.ToString();
                    txtEstado.Texts = oEmpleado.Estado.ToString();
                    fecha2.Texts = oEmpleado.FechaRegistro.ToString("d");
                }
                else
                {
                    textBox1.BackColor = Color.MistyRose;

                    txtDocumento2.BackColor = Color.MistyRose;
                    txtDocumento2.BorderColor = Color.MistyRose;
                }
            }
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
                    row.Cells["Contrato"].Value = item.empleado.Contrato.TipoContrato;
                    row.Cells["Estado2"].Value = item.empleado.Estado;
                    row.Cells["Salud"].Value = item.Salud.ToString("C");
                    row.Cells["Pension"].Value = item.Pension.ToString("C");
                    row.Cells["AuxT"].Value = item.AuxTransporte.ToString("C");
                    row.Cells["Bonificacion"].Value = item.BonificacionServicios.ToString("C");
                    row.Cells["PrimaServicios"].Value = item.PrimaServicios.ToString("C");
                    row.Cells["AuxAlimentacion"].Value = item.AuxAlimentacion.ToString("C");
                    row.Cells["PrimaNavidad"].Value = item.PrimaNavidad.ToString("C");
                    row.Cells["Vacaciones"].Value = item.Vacaciones.ToString("C");
                    row.Cells["Cesantias"].Value = item.Cesantia.ToString("C");
                    row.Cells["InteresesCesantias"].Value = item.InteresesCesantia.ToString("C");
                    row.Cells["Devengado"].Value = item.Devengado.ToString("C");
                    row.Cells["IdUsuario"].Value = item.usuario.IdPersona;
                    row.Cells["Usuario"].Value = item.usuario.Nombre;
                    row.Cells["FechaRegistro3"].Value = item.FechaRegistro.ToString("d");

                }
            }
        }

        private void MessageTable()
        {
            if (tblRegistroLiquidaciones.Rows.Count > 0)
            {
                lbltbl.Visible = false;
            }
            else
            {
                lbltbl.Visible = true;
            }

        }

        public string GenerarContenidoHTML()
        {
            string read_Html = Properties.Resources.PlantillaLiquidacion.ToString();
            string NombreNegocio = "NOMI";
            string NitNegocio = "35342-212";
            string CorreoNegocio = "alfredojoseperez@unicesar.edu.co";
            string liquidacion = "LIQUIDACION";

            read_Html = read_Html.Replace("@nombrenegocio", NombreNegocio);
            read_Html = read_Html.Replace("@docnegocio", NitNegocio);
            read_Html = read_Html.Replace("@direcnegocio", CorreoNegocio.ToLower());

            read_Html = read_Html.Replace("@tipodocumento", liquidacion.ToUpper());
            read_Html = read_Html.Replace("@numerodocumento", txtDetalle.Texts);

            read_Html = read_Html.Replace("@fecharegistro", dpFechaActual.Value.ToString("d"));
            read_Html = read_Html.Replace("@nombreusuario", oUsuario.Nombre.ToUpper());

            string fils = string.Empty;
            int contadorFilas = 0;

            foreach (DataGridViewRow row in tblRegistroLiquidaciones.Rows)
            {
                contadorFilas++;
                fils += "<tr class='fila-a-imprimir'>";
                fils += "<td>" + row.Cells["Año2"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Mes2"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Usuario"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Documento2"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Nombre"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Cargo2"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Estado2"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["DiasTrabajados"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["HorasTrabajadas"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["ValHorasExtras"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Salario2"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Salud"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Pension"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["AuxT"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["AuxAlimentacion"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Bonificacion"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["PrimaServicios"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["PrimaNavidad"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Vacaciones"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Cesantias"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["InteresesCesantias"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Devengado"].Value.ToString() + "</td>";
                fils += "</tr>";

            }

            read_Html = read_Html.Replace("@filas", fils);
            return read_Html;
        }

        public byte[] GenerarPDF(string contenidoHtml)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                Document PDFdoc = new Document(PageSize.A1, 25, 25, 25, 25);
                PdfWriter writer = PdfWriter.GetInstance(PDFdoc, stream);
                PDFdoc.Open();
                Bitmap bitmap = Properties.Resources.crisis__1_;
                ImageConverter converter = new ImageConverter();
                byte[] imageBytes = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imageBytes);
                image.ScaleToFit(64, 64);
                image.Alignment = iTextSharp.text.Image.UNDERLYING;
                image.SetAbsolutePosition(PDFdoc.Left, PDFdoc.GetTop(40));
                PDFdoc.Add(image);

                using (StringReader reader = new StringReader(contenidoHtml))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, PDFdoc, reader);
                }

                PDFdoc.Close();
                return stream.ToArray();
            }
        }

        public void GuardarPDFBD()
        {
            string contenidoHtml = GenerarContenidoHTML();

            // Generar el PDF
            byte[] pdfBytes = GenerarPDF(contenidoHtml);

            // Obtener la extensión del archivo local
            string extensionArchivo = GuardarPDFLocal(pdfBytes);

            Reporte oReporte = new Reporte
            {
                NombreReporte = string.Format("RegistroLiquidacion{0}", dpFechaActual.Value.ToString("ddMMyyyy")),
                Documento = pdfBytes,
                
                Extension = extensionArchivo,
                Usuario = new Usuario
                {
                    IdPersona = oUsuario.IdPersona,
                    Nombre = oUsuario.Nombre
                },
            };
            var msg = reporteService.Guardar(oReporte);
            MessageBox.Show(msg, "Gestión de liquidacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string GuardarPDFLocal(byte[] pdfBytes)
        {
            SaveFileDialog guardarPDF = new SaveFileDialog();
            guardarPDF.FileName = string.Format("RegistroLiquidacion{0}.pdf", dpFechaActual.Value.ToString("ddMMyyyy"));
            guardarPDF.Filter = "Pdf Files|*.pdf";

            if (guardarPDF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(guardarPDF.FileName, pdfBytes);
                    MessageBox.Show("Informe generado con éxito y guardado localmente!",
                                    "Gestión de liquidacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult result = MessageBox.Show("¿Deseas abrir la liquidacion?",
                        "Gestión de liquidacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(guardarPDF.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudo abrir el archivo. Error: " + ex.Message,
                                            "Error al abrir archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Devolver la extensión del archivo local
                    return System.IO.Path.GetFileName(guardarPDF.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo localmente. Error: " + ex.Message,
                                    "Error al guardar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return null;
        }

        private void FrmGestionEmpleados_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel1, 30);
            BorderRadiusPanel(panel2, 15);
            BorderRadiusPanel(panel3, 30);
            BorderRadiusPanel(panel4, 15);
            BorderRadiusPanel(panel5, 15);
            BorderRadiusPanel(panel6, 20);
            BorderRadiusPanel(panel8, 20);
            BorderRadiusPanel(panel9, 20);

            Nuevo();
            CargarEstados();
            CargarRegistro();
            MessageTable();
        }

        private void btnGuardarLiquidacion_Click(object sender, EventArgs e)
        {
            GuardarRegistroDetalleLiquidacion();
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            if (tblRegistroLiquidaciones.Rows.Count < 0)
            {
                MessageBox.Show("No hay datos en la tabla!",
                    "Gestión de liquidacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GuardarPDFBD();
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
                txtLiquidacion.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtLiquidacion_Leave(object sender, EventArgs e)
        {
            if (txtLiquidacion.Texts == "")
            {
                txtLiquidacion.Texts = "Codigo de liquidacion";
                txtLiquidacion.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Texts == "Codigo de detalle de liquidacion")
            {
                txtCodigo.Texts = "";
                txtCodigo.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Texts == "")
            {
                txtCodigo.Texts = "Codigo de detalle de liquidacion";
                txtCodigo.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtDiasTrabajados_Enter(object sender, EventArgs e)
        {
            if (txtDiasTrabajados.Texts == "Dias trabajados")
            {
                txtDiasTrabajados.Texts = "";
                txtDiasTrabajados.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtDiasTrabajados_Leave(object sender, EventArgs e)
        {
            if (txtDiasTrabajados.Texts == "")
            {
                txtDiasTrabajados.Texts = "Dias trabajados";
                txtDiasTrabajados.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtHorasExtras_Enter(object sender, EventArgs e)
        {
            if (txtHorasExtras.Texts == "Horas extras")
            {
                txtHorasExtras.Texts = "";
                txtHorasExtras.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtHorasExtras_Leave(object sender, EventArgs e)
        {
            if (txtHorasExtras.Texts == "")
            {
                txtHorasExtras.Texts = "Horas extras";
                txtHorasExtras.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtDocumento2_Enter(object sender, EventArgs e)
        {
            if (txtDocumento2.Texts == "Documento")
            {
                txtDocumento2.Texts = "";
                txtDocumento2.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtDocumento2_Leave(object sender, EventArgs e)
        {
            if (txtDocumento2.Texts == "")
            {
                txtDocumento2.Texts = "Documento";
                txtDocumento2.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Documento")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Documento";
                textBox1.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Texts == "Nombre")
            {
                txtNombre.Texts = "";
                txtNombre.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Texts == "")
            {
                txtNombre.Texts = "Nombre";
                txtNombre.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void cboCargo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCargo.Texts == "Cargo desempeñado")
            {
                cboCargo.Texts = "";
                cboCargo.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtSalario2_Enter(object sender, EventArgs e)
        {
            if (txtSalario2.Texts == "Salario")
            {
                txtSalario2.Texts = "";
                txtSalario2.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtSalario2_Leave(object sender, EventArgs e)
        {
            if (txtSalario2.Texts == "")
            {
                txtSalario2.Texts = "Salario";
                txtSalario2.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtEstado_Enter(object sender, EventArgs e)
        {
            if (txtEstado.Texts == "Estado")
            {
                txtEstado.Texts = "";
                txtEstado.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            if (txtEstado.Texts == "")
            {
                txtEstado.Texts = "Estado";
                txtEstado.ForeColor = Color.FromArgb(31, 30, 68);
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

        private void txtDocumento2_KeyDown(object sender, KeyEventArgs e)
        {
            BuscarEmpleado(sender, e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtSalario2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            BuscarEmpleado(sender, e);
        }

        private void txtEstado__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
