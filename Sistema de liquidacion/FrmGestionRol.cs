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
using System.Drawing.Drawing2D;

namespace Sistema_de_liquidacion
{
    public partial class FrmGestionRol : Form
    {
        private RolService rolService = new RolService();

        public FrmGestionRol()
        {
            InitializeComponent();
        }

        private Rol RegistrarRol()
        {
            Rol rol = new Rol
            {
                NRol = txtRol.Texts,
            };
            return rol;
        }

        private void GuardarRegistro()
        {
            if (!ValidarCampos()) { return; }

        }

        private bool ValidarCampos()
        {
            if (txtRol.Texts == "")
            {
                MessageBox.Show("Por favor llenar el campo de cargos", "Gestion de rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtRol.Texts == "Rol")
            {
                MessageBox.Show("Por favor llenar el campo de cargos", "Gestion de rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void ModificarRegistro()
        {
            if (!ValidarCampos()) { return; }

        }

        private void CargarRegistro()
        {
            Visualizer(rolService.CargarRegistro());
        }

        private void Nuevo()
        {
            txtRol.Texts = "Rol";
        }

        private void FiltroCargos()
        {
            var filtro = txtBuscar.Texts;
            var lista = rolService.BuscarX(filtro);
            Visualizer(lista);
        }

        private void Visualizer(List<Rol> lista)
        {
            tblRegistroRol.Rows.Clear();

            if (lista != null)
            {
                foreach (var item in lista)
                {
                    int index = tblRegistroRol.Rows.Add();
                    DataGridViewRow row = tblRegistroRol.Rows[index];
                    row.Cells["IdRol"].Value = item.IdRol;
                    row.Cells["Rol"].Value = item.NRol;
                    row.Cells["FechaRegistro"].Value = item.FechaRegistro.ToString("d");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void FrmGestionRol_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel2, 20);
            BorderRadiusPanel(panel4, 20);
            BorderRadiusPanel(panel9, 20);

            CargarRegistro();
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
            if (tblRegistroRol.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    btnGuardar.Enabled = false;
                    txtIdRol.Texts = tblRegistroRol.Rows[index].Cells["IdRol"].Value.ToString();
                    txtRol.Texts = tblRegistroRol.Rows[index].Cells["Rol"].Value.ToString();

                }
            }

            if (tblRegistroRol.Columns[e.ColumnIndex].Name == "btnSEliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int IdRol = Convert.ToInt32(tblRegistroRol.Rows[index].Cells["IdRol"].Value);

                        Rol rol = new Rol
                        {
                            IdRol = IdRol,
                        };

                        var msg = rolService.EliminarRegistro(rol);
                        MessageBox.Show(msg, "Gestion de rol", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tblRegistroRol.Rows.RemoveAt(index);
                    }
                }
            }
        }

        private void tblRegistroRol_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "Buscar:")
            { Visualizer(rolService.CargarRegistro()); }
            else if (txtBuscar.Texts == "") { Visualizer(rolService.CargarRegistro()); }
            else
            { FiltroCargos(); }
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

        private void txtIdRol_Enter(object sender, EventArgs e)
        {
            if (txtIdRol.Texts == "Id de Rol")
            {
                txtIdRol.Texts = "";
                txtIdRol.ForeColor = Color.LightGray;
            }
        }

        private void txtIdRol_Leave(object sender, EventArgs e)
        {
            if (txtIdRol.Texts == "")
            {
                txtIdRol.Texts = "Id de Rol";
                txtIdRol.ForeColor = Color.LightGray;
            }
        }

        private void txtRol_Enter(object sender, EventArgs e)
        {
            if (txtRol.Texts == "Rol")
            {
                txtRol.Texts = "";
                txtRol.ForeColor = Color.LightGray;
            }
        }

        private void txtRol_Leave(object sender, EventArgs e)
        {
            if (txtRol.Texts == "")
            {
                txtRol.Texts = "Rol";
                txtRol.ForeColor = Color.LightGray;
            }
        }

        private void tblRegistroRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick(sender, e);
        }
    }
}
