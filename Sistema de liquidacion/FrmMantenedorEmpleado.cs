﻿using Entidad;
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
        private EmpleadoService empleadoService = new EmpleadoService();

        public FrmMantenedorEmpleado()
        {
            InitializeComponent();
        }

        private Empleado RegistroProducto()
        {
            try
            {
                Cargo CargoIndex = (Cargo)cboCargos.SelectedItem;
                Empleado producto = new Empleado
                {
                    Documento = txtDocumento.Texts,
                    Nombre = txtNombreProducto.Texts.ToUpper(),
                    Cargo = CargoIndex,
                    Contrato = new Contrato
                    {
                        FechaInicio = Convert.ToDateTime(dpFechaInicial.Value.ToString("yyyy-M-d")),
                        FechaFin = Convert.ToDateTime(dpFechaFinal.Value.ToString("yyyy-M-d")),
                        Salario = Convert.ToDecimal(txtSalario.Texts),
                        TipoContrato = cboContrato.Texts.ToUpper(),
                    },
                    Estado = "ACTIVO",
                };
                return producto;
            } catch (FormatException)
            {
                return null;
            }
        }

        private void GuardarRegistro()
        {
            if (!ValidarCampos()) { return; }
            var producto = RegistroProducto();

            var ID = empleadoService.BuscarId(txtDocumento.Texts);
            if (ID != true)
            {
                var msg = empleadoService.Guardar(producto);
                MessageBox.Show(msg, "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarRegistro();
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
            Empleado producto = new Empleado
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
                    TipoContrato = cboContrato.Texts.ToUpper(),
                },
                IdPersona = Convert.ToInt32(txtIdProducto.Texts),
            };
            if (producto != null)
            {
                var msg = empleadoService.ModificarRegistros(producto);
                MessageBox.Show(msg, "Gestion de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarRegistro();
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
            txtDocumento.Texts = "Documento";
            txtNombreProducto.Texts = "Nombre";
            txtSalario.Texts = "Salario";
            cboCargos.Texts = "Cargos desempeñados";
            cboContrato.Texts = "Contrato";
            cboEstado.Texts = "Estado";
            txtDocumento.Focus();
        }

        private void CargarRegistro()
        {
            Visualizer(empleadoService.CargarRegistro());
        }

        private void Visualizer(List<Empleado> lista)
        {
            tblRegistro.Rows.Clear();

            if (lista != null)
            {
                foreach (var item in lista)
                {
                    int index = tblRegistro.Rows.Add();
                    DataGridViewRow row = tblRegistro.Rows[index];
                    row.Cells["IdProducto"].Value = item.IdPersona;
                    row.Cells["Documento"].Value = item.Documento;
                    row.Cells["NombreProducto"].Value = item.Nombre;
                    row.Cells["IdContrato"].Value = item.Contrato.IdContrato;
                    row.Cells["IdCargo"].Value = item.Cargo.IdCargo;
                    row.Cells["Cargo"].Value = item.Cargo.CargoDesempeñado;
                    row.Cells["FechaInicio"].Value = item.Contrato.FechaInicio.ToString("d");
                    row.Cells["FechaFin"].Value = item.Contrato.FechaFin.ToString("d");
                    row.Cells["TipoContrato"].Value = item.Contrato.TipoContrato;
                    row.Cells["Salario"].Value = item.Contrato.Salario.ToString("C");
                    row.Cells["Estado"].Value = item.Estado;
                    row.Cells["FechaRegistro2"].Value = item.FechaRegistro.ToString("d");
                }
            }
        }

        private void MessageTable()
        {
            if (tblRegistro.Rows.Count > 0)
            {
                lbltbl.Visible = false;
            }
            else
            {
                lbltbl.Visible = true;
            }

        }

        private void FiltroProducto()
        {
            var filtro = txtBuscar.Texts;
            var lista = empleadoService.BuscarX(filtro);
            Visualizer(lista);
        }

        private void FiltroProductoEstado()
        {
            if (cboFiltroEstado.SelectedIndex > 0)
            {
                string estadoSeleccionado = cboFiltroEstado.SelectedItem.ToString();
                var lista = empleadoService.FiltroEstadoConParametro(estadoSeleccionado.ToUpper());
                Visualizer(lista);
            }
            else if (cboFiltroEstado.SelectedIndex == 0)
            { Visualizer(empleadoService.CargarRegistro()); }
        }

        private void CargarEstados()
        {
            cboFiltroEstado.Items.Clear();
            cboFiltroEstado.Items.Add("");
            cboFiltroEstado.Items.Add("ACTIVO");
            cboFiltroEstado.Items.Add("INACTIVO");
            cboFiltroEstado.SelectedIndex = 0;
        }

        private void CargarContratos()
        {
            cboContrato.Items.Clear();
            cboContrato.Items.Add("");
            cboContrato.Items.Add("CONTRATO FIJO");
            cboContrato.Items.Add("TERMINO INDEFINIDO");
            cboContrato.Items.Add("PRESTACION DE SERVICIO");
            cboContrato.Items.Add("POR EL ESTADO");
            cboContrato.SelectedIndex = 0;
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
            CargarContratos();
            CargarCargos();
            BorderRadiusPanel(panel1, 30);
            BorderRadiusPanel(panel2, 30);
            BorderRadiusPanel(panel3, 15);
            BorderRadiusPanel(panel4, 20);
            BorderRadiusPanel(panel5, 20);
            BorderRadiusPanel(panel8, 20);
            BorderRadiusPanel(panel9, 20);

            Nuevo();
            CargarRegistro();
            MessageTable();
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

                    cboContrato.Texts = tblRegistro.Rows[index].Cells["TipoContrato"].Value.ToString();
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
            { Visualizer(empleadoService.CargarRegistro()); }
            else if (txtBuscar.Texts == "") { Visualizer(empleadoService.CargarRegistro()); }
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

        private void txtNombreProducto_Enter(object sender, EventArgs e)
        {
            if (txtNombreProducto.Texts == "Nombre")
            {
                txtNombreProducto.Texts = "";
                txtNombreProducto.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtNombreProducto_Leave(object sender, EventArgs e)
        {
            if (txtNombreProducto.Texts == "")
            {
                txtNombreProducto.Texts = "Nombre";
                txtNombreProducto.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtSalario_Enter(object sender, EventArgs e)
        {
            if (txtSalario.Texts == "Salario")
            {
                txtSalario.Texts = "";
                txtSalario.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            if (txtSalario.Texts == "")
            {
                txtSalario.Texts = "Salario";
                txtSalario.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick(sender, e);
        }
    }
}
