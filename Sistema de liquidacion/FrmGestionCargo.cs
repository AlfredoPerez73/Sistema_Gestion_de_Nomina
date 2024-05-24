using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Sistema_de_liquidacion
{
    public partial class FrmGestionCargo : Form
    {
        CargoService cargoService = new CargoService();

        public FrmGestionCargo()
        {
            InitializeComponent();
        }

        private Cargo RegistrarCargo()
        {
            Cargo cargo = new Cargo
            {
                CargoDesempeñado = txtCargo.Texts,
            };
            return cargo;
        }

        private void GuardarRegistro()
        {
            if (!ValidarCampos()) { return; }

            var cargos = RegistrarCargo();
            var ID = cargoService.BuscarId(txtCargo.Texts);
            if (ID != true)
            {
                var msg = cargoService.Guardar(cargos);
                MessageBox.Show(msg, "Gestion de cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarRegistro();
                Nuevo();
            }
            else
            {
                MessageBox.Show($"El registro {txtCargo.Texts} " +
                    $"ya existe!", "Gestion de cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarCampos()
        {
            if (txtCargo.Texts == "")
            {
                MessageBox.Show("Por favor llenar el campo de cargos", "Gestion de cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtCargo.Texts == "Cargo")
            {
                MessageBox.Show("Por favor llenar el campo de cargos", "Gestion de cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void ModificarRegistro()
        {
            if (!ValidarCampos()) { return; }

            Cargo cargo = new Cargo
            {
                CargoDesempeñado = txtCargo.Texts,
                IdCargo = Convert.ToInt32(txtIdCargo.Texts)
            };
            if (cargo != null)
            {
                var msg = cargoService.ModificarRegistros(cargo);
                MessageBox.Show(msg, "Gestion de cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarRegistro();
                Nuevo();
            }
            else
            {
                MessageBox.Show($"El registro {txtCargo.Texts} " +
                    $"ya existe!", "Gestion de cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarRegistro()
        {
            Visualizer(cargoService.CargarRegistro());
        }

        private void Nuevo()
        {
            txtCargo.Texts = "Cargo";
        }

        private void FiltroCargos()
        {
            var filtro = txtBuscar.Texts;
            var lista = cargoService.BuscarX(filtro);
            Visualizer(lista);
        }

        private void Visualizer(List<Cargo> lista)
        {
            tblRegistroCargo.Rows.Clear();

            if (lista != null)
            {
                foreach (var item in lista)
                {
                    int index = tblRegistroCargo.Rows.Add();
                    DataGridViewRow row = tblRegistroCargo.Rows[index];
                    row.Cells["IdCargo"].Value = item.IdCargo;
                    row.Cells["Cargo"].Value = item.CargoDesempeñado;
                    row.Cells["FechaRegistro"].Value = item.FechaRegistro.ToString("d");
                }
            }
        }

        private void FrmGestionCargo_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel3, 20);
            BorderRadiusPanel(panel4, 20);
            BorderRadiusPanel(panel9, 20);

            CargarRegistro();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Nuevo();
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
            if (tblRegistroCargo.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    btnGuardar.Enabled = false;
                    txtIdCargo.Texts = tblRegistroCargo.Rows[index].Cells["IdCargo"].Value.ToString();
                    txtCargo.Texts = tblRegistroCargo.Rows[index].Cells["Cargo"].Value.ToString();

                }
            }

            if (tblRegistroCargo.Columns[e.ColumnIndex].Name == "btnSEliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int IdCargo = Convert.ToInt32(tblRegistroCargo.Rows[index].Cells["IdCargo"].Value);

                        Cargo cargo = new Cargo
                        {
                            IdCargo = IdCargo,
                        };

                        var msg = cargoService.EliminarRegistros(cargo);
                        MessageBox.Show(msg, "Gestion de cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tblRegistroCargo.Rows.RemoveAt(index);
                    }
                }
            }
        }

        private void tblRegistroCargo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "Buscar:")
            { Visualizer(cargoService.CargarRegistro()); }
            else if (txtBuscar.Texts == "") { Visualizer(cargoService.CargarRegistro()); }
            else
            { FiltroCargos(); }
        }

        private void txtIdCargo_Enter(object sender, EventArgs e)
        {
            if (txtIdCargo.Texts == "Id de Cargo")
            {
                txtIdCargo.Texts = "";
                txtIdCargo.ForeColor = Color.LightGray;
            }
        }

        private void txtIdCargo_Leave(object sender, EventArgs e)
        {
            if (txtIdCargo.Texts == "")
            {
                txtIdCargo.Texts = "Id de Cargo";
                txtIdCargo.ForeColor = Color.LightGray;
            }
        }

        private void txtCargo_Enter(object sender, EventArgs e)
        {
            if (txtCargo.Texts == "Cargo")
            {
                txtCargo.Texts = "";
                txtCargo.ForeColor = Color.LightGray;
            }
        }

        private void txtCargo_Leave(object sender, EventArgs e)
        {
            if (txtCargo.Texts == "Cargo")
            {
                txtCargo.Texts = "";
                txtCargo.ForeColor = Color.LightGray;
            }
        }

        private void tblRegistroCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick(sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
