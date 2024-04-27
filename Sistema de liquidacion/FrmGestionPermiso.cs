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

        private void Nuevo()
        {
            cboHerramienta.Texts = "Permisos";
            cboRoles.Texts = "Rol desempeñado";
        }

        private void FrmGestionPermiso_Load(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(usuario);

            BorderRadiusPanel(panel2, 20);
            BorderRadiusPanel(panel3, 20);
            BorderRadiusPanel(panel5, 20);

            botones = GetAllButtons(frmMenuPrincipal).ToArray();

            CargarRoles();
            CargarBotonesEnComboBox();
        }

        private void CargarBotonesEnComboBox()
        {

        }

        private IEnumerable<Button> GetAllButtons(Control control)
        {
            var botones = control.Controls.OfType<Button>();

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

        private void CargarRoles()
        {

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
    }
}
