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
using FontAwesome.Sharp;
using Sistema_de_liquidacion.Modales;

namespace Sistema_de_liquidacion
{
    public partial class FrmMenuPrincipal : Form
    {
        private Usuario oUsuario;

        private static Form FormularioActivo = null;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        // ---------------------------------
        bool SliderExpand;

        public FrmMenuPrincipal(Usuario oUsuario)
        {
            InitializeComponent();

            this.oUsuario = oUsuario;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            SlideContenedor.Controls.Add(leftBorderBtn);
        }
        
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel1, 15);
            BorderRadiusPanel(panel2, 15);
            BorderRadiusPanel(panel5, 15);
            BorderRadiusPanel(panel9, 20);

            ContenedorPrincipal();
            CargarUsuario();
            Permisos();
            ToolTipButtons();
        }

        private void Permisos()
        {
            List<Permiso> permisoList = new PermisoService().ValidacionPermiso(Convert.ToString(oUsuario.IdPersona));

            foreach (Control control in SlideContenedor.Controls)
            {
                if (control is Button button)
                {
                    bool encontrado = permisoList.Any(m => m.NPermiso == button.Text);
                    button.Visible = encontrado;
                }
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            btnEstadoFrm.IconChar = IconChar.Home;
            btnEstadoFrm.IconColor = Color.MediumPurple;
            lblEstado.Text = "Inicio";
        }

        private void ToolTipButtons()
        {

            toolTip1.ToolTipTitle = "Menu Principal";  // Título del ToolTip
            toolTip1.ToolTipIcon = ToolTipIcon.Info;

            toolTip1.SetToolTip(btnInicio, "Menu principal");
            toolTip1.SetToolTip(btnLiquidacionTotal, "Estado nominal de liquidaciones");
            toolTip1.SetToolTip(btnMantenedorEmpleado, "Gestion de informacion del empleado");
            toolTip1.SetToolTip(btnGestionEmpleado, "Gestion de liquidacion del empleado");
            toolTip1.SetToolTip(btnGestionCargo, "Gestion de cargos empresariales");
            toolTip1.SetToolTip(btnGestionRol, "Gestion de roles de usuarios");
            toolTip1.SetToolTip(btnGestionUsuario, "Gestion de usuarios");
            toolTip1.SetToolTip(btnGestionPermisos, "Gestion de permisos de usuarios");
            toolTip1.SetToolTip(btnReporte, "Gestion de reportes de liquidacion");
        }

        private void CargarUsuario()
        {
            lblUsuario.Text = oUsuario.Nombre.ToUpper();

        }

        private void Inicio(Form Formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            Reset();
            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;
            Formulario.FormBorderStyle = FormBorderStyle.None;

            Contenedor.Controls.Add(Formulario);
            Formulario.Show();
        }

        private void AbrirFormularios(Button Menu, Form Formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;
            Formulario.FormBorderStyle = FormBorderStyle.None;

            Contenedor.Controls.Add(Formulario);
            Formulario.Show();
            lblEstado.Text = FormularioActivo.Text;
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

        private void SliderBar()
        {
            if (SliderExpand)
            {
                SlideContenedor.Width += 10;
                if (SlideContenedor.Width == SlideContenedor.MaximumSize.Width)
                {
                    SliderExpand = false;
                    SlideTimer.Stop();

                }
            }
            else
            {
                SlideContenedor.Width -= 10;
                if (SlideContenedor.Width == SlideContenedor.MinimumSize.Width)
                {
                    SliderExpand = true;
                    SlideTimer.Stop();

                }
            }
        }

        private void VisiblePanel()
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            SliderBar();
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            SlideTimer.Start();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio(new mdPrincipal());
        }

        private void ContenedorPrincipal()
        {
            Inicio(new mdPrincipal());
        }

        private void btnGestionEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormularios((Button)sender, new FrmGestionEmpleados(oUsuario));
        }

        private void btnLiquidacionTotal_Click_1(object sender, EventArgs e)
        {
            AbrirFormularios((Button)sender, new FrmNomina());
        }

        private void btnMantenedorEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormularios((Button)sender, new FrmMantenedorEmpleado());
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            AbrirFormularios((Button)sender, new FrmGestionCargo());
        }

        private void btnGestionRol_Click(object sender, EventArgs e)
        {
            AbrirFormularios((Button)sender, new FrmGestionRol());
        }

        private void btnGestionUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularios((Button)sender, new FrmGestionUsuario());
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            AbrirFormularios((Button)sender, new FrmReporte(oUsuario));
        }

        private void btnGestionPermisos_Click(object sender, EventArgs e)
        {
            AbrirFormularios((Button)sender, new FrmGestionPermiso(oUsuario));
        }

        private void alphaGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
