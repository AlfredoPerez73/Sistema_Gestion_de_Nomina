using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Sistema_de_liquidacion.Modales;

namespace Sistema_de_liquidacion
{
    public partial class FrmGestionPermiso : Form
    {
        private PermisoService permisoService = new PermisoService();

        private Button[] botones;
        private Usuario usuario;

        public FrmGestionPermiso(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private Permiso RegistrarPermisos()
        {
            Rol RoleIndex = (Rol)cboRoles.SelectedItem;
            Permiso permiso = new Permiso
            {
                NPermiso = cboHerramienta.Texts,
                Rol = RoleIndex,
            };
            return permiso;
        }

        private void GuardarPermiso()
        {
            if (!ValidarCampos()) { return; }

            var permisos = RegistrarPermisos();
            var ID = permisoService.BuscarId(cboHerramienta.Texts, cboRoles.Texts);
            if (ID != true)
            {
                var msg = permisoService.Guardar(permisos);
                MessageBox.Show(msg, "Gestion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo();
            }
            else
            {
                MessageBox.Show($"El registro con la ID {cboHerramienta.Texts} " +
                    $"ya existe!", "Gestion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarCampos()
        {
            if (cboHerramienta.Texts == "")
            {
                MessageBox.Show("Por favor llenar el campo de permisos", "Gestion de permisos",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cboHerramienta.Texts == "Permisos")
            {
                MessageBox.Show("Por favor llenar el campo de permisos", "Gestion de permisos",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cboRoles.Texts == "")
            {
                MessageBox.Show("Por favor llenar el campo de roles", "Gestion de permisos",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cboRoles.Texts == "Rol desempeñado")
            {
                MessageBox.Show("Por favor llenar el campo de roles", "Gestion de permisos",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void CargarRegistro()
        {
            Visualizer(permisoService.CargarRegistro());
        }

        private void Visualizer(List<Permiso> lista)
        {
            tblRegistroPermiso.Rows.Clear();

            if (lista != null)
            {
                foreach (var item in lista)
                {
                    int index = tblRegistroPermiso.Rows.Add();
                    DataGridViewRow row = tblRegistroPermiso.Rows[index];
                    row.Cells["IdPermiso"].Value = item.IdPermiso;
                    row.Cells["Permisos"].Value = item.NPermiso;
                    row.Cells["IdRol"].Value = item.Rol.IdRol;
                    row.Cells["Rol"].Value = item.Rol.NRol;
                    row.Cells["FechaRegistro"].Value = item.FechaRegistro.ToString("d");
                }
            }
        }

        private void Nuevo()
        {
            cboHerramienta.Texts = "Permisos";
            cboRoles.Texts = "Rol desempeñado";
        }

        private void FiltroPermisos()
        {
            var filtro = txtBuscar.Texts;
            var lista = permisoService.BuscarX(filtro);
            Visualizer(lista);
        }

        private void FiltroRol()
        {
            if (cboFiltroRol.SelectedIndex > 0)
            {
                Rol rolSeleccionado = (Rol)cboFiltroRol.SelectedItem; // Obtener el objeto Rol seleccionado
                string nombreRolSeleccionado = rolSeleccionado.NRol; // Obtener el nombre del rol del objeto Rol
                var lista = permisoService.FiltroRol(nombreRolSeleccionado.ToUpper());
                Visualizer(lista);
            }
            else if (cboFiltroRol.SelectedIndex == 0)
            {
                Visualizer(permisoService.CargarRegistro());
            }
        }

        private void FrmGestionPermiso_Load(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(usuario);

            BorderRadiusPanel(panel2, 20);
            BorderRadiusPanel(panel3, 20);
            BorderRadiusPanel(panel4, 20);
            BorderRadiusPanel(panel5, 20);
            BorderRadiusPanel(panel6, 15);
            BorderRadiusPanel(panel9, 20);

            botones = GetAllButtons(frmMenuPrincipal).ToArray();
            CargarRegistro();
            CargarRoles();
            CargarBotonesEnComboBox();
            cboRoles.Texts = "Rol desempeñado";
        }

        private void CargarBotonesEnComboBox()
        {
            foreach (Button boton in botones)
            {
                cboHerramienta.Items.Add(boton.Text);
            }
        }

        private IEnumerable<Button> GetAllButtons(Control control)
        {
            var botones = control.Controls.OfType<Button>();

            foreach (Control subControl in control.Controls)
            {
                botones = botones.Concat(GetAllButtons(subControl));
            }

            return botones;
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

        private void tblRegistroPermiso_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void CargarRoles()
        {
            RolService rolService = new RolService();
            var roles = rolService.CargarRegistro();

            // Crear una copia de la lista de roles para cada ComboBox
            var rolesCbo1 = new List<Rol>(roles);
            var rolesCbo2 = new List<Rol>(roles);

            // Agregar un índice adicional a cada lista
            rolesCbo1.Insert(0, new Rol { IdRol = -1, NRol = " " });
            rolesCbo2.Insert(0, new Rol { IdRol = -1, NRol = " " });

            cboRoles.DataSource = rolesCbo1;
            cboFiltroRol.DataSource = rolesCbo2;

            cboRoles.DisplayMember = "NRol";
            cboRoles.ValueMember = "IdRol";

            cboFiltroRol.DisplayMember = "NRol";
            cboFiltroRol.ValueMember = "IdRol";

            cboRoles.SelectedIndex = -1;
            cboRoles.DropDownStyle = ComboBoxStyle.DropDownList;

            cboFiltroRol.SelectedIndex = -1;
            cboFiltroRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void cboHerramienta_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDeBotonSeleccionado = cboHerramienta.SelectedItem.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarPermiso();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Nuevo();
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

        private void cboFiltroRol_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FiltroRol();
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "Buscar:")
            { Visualizer(permisoService.CargarRegistro()); }
            else if (txtBuscar.Texts == "") { Visualizer(permisoService.CargarRegistro()); }
            else
            { FiltroPermisos(); }
        }

        private void cboRoles_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
