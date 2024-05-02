using Entidad;
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
using System.Drawing.Drawing2D;
using System.Globalization;

namespace Sistema_de_liquidacion
{
    public partial class FrmMantenedorEmpleado : Form
    {
        private ProductoService productoService = new ProductoService();

        public FrmMantenedorEmpleado()
        {
            InitializeComponent();
        }

        private Producto RegistroProducto()
        {
            Cargo CargoIndex = (Cargo)cboCargos.SelectedItem;
            Producto producto = new Producto
            {
                Documento = txtDocumento.Texts,
                Nombre = txtNombreProducto.Texts.ToUpper(),
                Cargo = CargoIndex,
                Contrato = new Contrato
                {
                    FechaInicio = dpFechaInicial.Value,
                    FechaFin = dpFechaFinal.Value,
                    Salario = Convert.ToDecimal(txtSalario.Texts),
                    TipoContrato = txtContrato.Texts.ToUpper(),
                },
                Estado = cboEstado.Texts.ToUpper(),
            };
            return producto;
        }

        private void GuardarRegistro()
        {
            if (!ValidarCampos()) { return; }
            var producto = RegistroProducto();

            var ID = productoService.BuscarId(txtDocumento.Texts);
            if (ID != true)
            {
                var msg = productoService.Guardar(producto);
                MessageBox.Show(msg, "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarRegistroProducto(productoService.CargarRegistro());
                Nuevo();
            }
            else
            {
                MessageBox.Show($"El registro con la ID {txtDocumento.Texts} " +
                    $"ya existe!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ModificarRegistro()
        {
            if (!ValidarCampos()) { return; }
            Cargo CargoIndex = (Cargo)cboCargos.SelectedItem;
            Producto producto = new Producto
            {
                Documento = txtDocumento.Texts,
                Nombre = txtNombreProducto.Texts.ToUpper(),
                Cargo = CargoIndex,
                Estado = cboEstado.Texts.ToUpper(),
                Contrato = new Contrato
                {
                    IdContrato = Convert.ToInt32(txtIdContrato.Texts),
                    FechaInicio = Convert.ToDateTime(dpFechaInicial.Text),
                    FechaFin = Convert.ToDateTime(dpFechaFinal.Text),
                    Salario = Convert.ToInt32(txtSalario.Texts),
                    TipoContrato = txtContrato.Texts.ToUpper(),
                },
                IdProducto = Convert.ToInt32(txtIdProducto.Texts),
            };
            if (producto != null)
            {
                var msg = productoService.ModificarRegistros(producto);
                MessageBox.Show(msg, "Gestion de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarRegistroProducto(productoService.CargarRegistro());
                Nuevo();
            }
            else
            {
                MessageBox.Show("No se pudo", "Gestion de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool ValidarCampos()
        {
            if (txtDocumento.Texts == "")
            {
                MessageBox.Show("Por favor llenar el campo de documento", "Gestion de empleado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtNombreProducto.Texts == "")
            {
                MessageBox.Show("Por favor llenar el campo de empleado", "Gestion de empleado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtSalario.Texts == "")
            {
                MessageBox.Show("Por favor llenar el campo de salario", "Gestion de empleado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cboEstado.Texts == "")
            {
                MessageBox.Show("Por favor llenar el campo de Estado", "Gestion de empleado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDocumento.Texts == "Documento")
            {
                MessageBox.Show("Por favor llenar el campo de documento", "Gestion de empleado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtNombreProducto.Texts == "Nombre")
            {
                MessageBox.Show("Por favor llenar el campo de empleado", "Gestion de empleado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtSalario.Texts == "Salario")
            {
                MessageBox.Show("Por favor llenar el campo de salario", "Gestion de empleado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cboEstado.Texts == "Estado")
            {
                MessageBox.Show("Por favor llenar el campo de Estado", "Gestion de empleado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Nuevo()
        {
            txtDocumento.Texts = "";
            txtNombreProducto.Texts = "";
            txtSalario.Texts = "";
            txtDocumento.Focus();
        }

        private void CargarRegistroProducto(List<Producto> lista)
        {
            tblRegistro.Rows.Clear();

            if (lista != null)
            {
                foreach (var producto in lista)
                {
                    int index = tblRegistro.Rows.Add();
                    DataGridViewRow row = tblRegistro.Rows[index];
                    row.Cells["IdProducto"].Value = producto.IdProducto;
                    row.Cells["Documento"].Value = producto.Documento;
                    row.Cells["NombreProducto"].Value = producto.Nombre;
                    row.Cells["IdContrato"].Value = producto.Contrato.IdContrato;
                    row.Cells["IdCargo"].Value = producto.Cargo.IdCargo;
                    row.Cells["Cargo"].Value = producto.Cargo.CargoDesempeñado;
                    row.Cells["FechaInicio"].Value = producto.Contrato.FechaInicio.ToString("d");
                    row.Cells["FechaFin"].Value = producto.Contrato.FechaFin.ToString("d");
                    row.Cells["TipoContrato"].Value = producto.Contrato.TipoContrato;
                    row.Cells["Salario"].Value = producto.Contrato.Salario.ToString("C");
                    row.Cells["Estado"].Value = producto.Estado;
                    row.Cells["FechaRegistro2"].Value = producto.FechaRegistro.ToString("d");
                }
            }
        }

        private void FiltroProducto()
        {
            var filtro = txtBuscar.Texts;
            var lista = productoService.BuscarX(filtro);
            CargarRegistroProducto(lista);
        }

        private void FiltroProductoEstado()
        {
            if (cboFiltroEstado.SelectedIndex > 0)
            {
                string estadoSeleccionado = cboFiltroEstado.SelectedItem.ToString();
                var lista = productoService.FiltroEstado(estadoSeleccionado.ToUpper());
                CargarRegistroProducto(lista);
            }
            else if (cboFiltroEstado.SelectedIndex == 0)
            { CargarRegistroProducto(productoService.CargarRegistro()); }
        }

        private void CargarEstados()
        {
            cboFiltroEstado.Items.Clear();
            cboFiltroEstado.Items.Add("");
            cboFiltroEstado.Items.Add("ACTIVO");
            cboFiltroEstado.Items.Add("INACTIVO");
            cboFiltroEstado.SelectedIndex = 0;
            //-------------------------------------
            cboEstado.Items.Clear();
            cboEstado.Items.Add("");
            cboEstado.Items.Add("ACTIVO");
            cboEstado.Items.Add("INACTIVO");
            cboEstado.SelectedIndex = 0;
        }

        private void CargarCargos()
        {
            CargoService cargoService = new CargoService();
            cboCargos.DataSource = cargoService.CargarRegistro();
            cboCargos.DisplayMember = "CargoDesempeñado";
            cboCargos.ValueMember = "IdCargo";
            cboCargos.SelectedIndex = -1;
            cboCargos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void FrmMantenedorEmpleado_Load(object sender, EventArgs e)
        {
            CargarEstados();
            CargarCargos();
            BorderRadiusPanel(panel1, 20);
            BorderRadiusPanel(panel2, 20);
            BorderRadiusPanel(panel3, 15);
            BorderRadiusPanel(panel4, 20);
            BorderRadiusPanel(panel5, 20);
            BorderRadiusPanel(panel9, 20);

            CargarRegistroProducto(productoService.CargarRegistro());
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistro.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    btnGuardar.Enabled = false;
                    txtIdProducto.Texts = tblRegistro.Rows[index].Cells["IdProducto"].Value.ToString();
                    txtDocumento.Texts = tblRegistro.Rows[index].Cells["Documento"].Value.ToString();
                    txtNombreProducto.Texts = tblRegistro.Rows[index].Cells["NombreProducto"].Value.ToString();
                    txtIdContrato.Texts = tblRegistro.Rows[index].Cells["IdContrato"].Value.ToString();
                    txtIdCargo.Texts = tblRegistro.Rows[index].Cells["IdCargo"].Value.ToString();
                    cboCargos.Texts = tblRegistro.Rows[index].Cells["Cargo"].Value.ToString();
                    cboEstado.Texts = tblRegistro.Rows[index].Cells["Estado"].Value.ToString();

                    // Limpia el formato del salario antes de asignarlo
                    string salarioConFormato = tblRegistro.Rows[index].Cells["Salario"].Value.ToString();
                    decimal salarioNumerico = decimal.Parse(salarioConFormato, NumberStyles.Currency);
                    string salarioSinFormato = salarioNumerico.ToString("#,0.##").Replace(".",""); // Formatea el salario con dos decimales máximo
                    txtSalario.Texts = salarioSinFormato;

                    txtContrato.Texts = tblRegistro.Rows[index].Cells["TipoContrato"].Value.ToString();
                    dpFechaInicial.Text = tblRegistro.Rows[index].Cells["FechaInicio"].Value.ToString();
                    dpFechaFinal.Text = tblRegistro.Rows[index].Cells["FechaFin"].Value.ToString();

                }
            }
        }

        private void tblRegistro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

                e.Graphics.DrawImage(Properties.Resources.check_circle, new Rectangle(x, y, w, h));
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

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "Buscar:")
            { CargarRegistroProducto(productoService.CargarRegistro()); }
            else if (txtBuscar.Texts == "") { CargarRegistroProducto(productoService.CargarRegistro()); }
            else
            { FiltroProducto(); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboFiltroEstado_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FiltroProductoEstado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            if (txtDocumento.Texts == "Documento")
            {
                txtDocumento.Texts = "";
                txtDocumento.ForeColor = Color.LightGray;
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (txtDocumento.Texts == "")
            {
                txtDocumento.Texts = "Documento";
                txtDocumento.ForeColor = Color.LightGray;
            }
        }

        private void txtNombreProducto_Enter(object sender, EventArgs e)
        {
            if (txtNombreProducto.Texts == "Nombre")
            {
                txtNombreProducto.Texts = "";
                txtNombreProducto.ForeColor = Color.LightGray;
            }
        }

        private void txtNombreProducto_Leave(object sender, EventArgs e)
        {
            if (txtNombreProducto.Texts == "")
            {
                txtNombreProducto.Texts = "Nombre";
                txtNombreProducto.ForeColor = Color.LightGray;
            }
        }

        private void txtSalario_Enter(object sender, EventArgs e)
        {
            if (txtSalario.Texts == "Salario")
            {
                txtSalario.Texts = "";
                txtSalario.ForeColor = Color.LightGray;
            }
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            if (txtSalario.Texts == "")
            {
                txtSalario.Texts = "Salario";
                txtSalario.ForeColor = Color.LightGray;
            }
        }

        private void txtContrato_Enter(object sender, EventArgs e)
        {
            if (txtContrato.Texts == "Tipo de contrato")
            {
                txtContrato.Texts = "";
                txtContrato.ForeColor = Color.LightGray;
            }
        }

        private void txtContrato_Leave(object sender, EventArgs e)
        {
            if (txtContrato.Texts == "")
            {
                txtContrato.Texts = "Tipo de contrato";
                txtContrato.ForeColor = Color.LightGray;
            }
        }

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick(sender, e);
        }
    }
}
