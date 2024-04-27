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
            ContenedorPrincipal();
            CargarUsuario();
            Permisos();

            BorderRadiusPanel(panel1, 15);
            BorderRadiusPanel(panel2, 15);
            BorderRadiusPanel(panel5, 15);
            BorderRadiusPanel(panel9, 20);
        }

        private void Permisos()
        {

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.MediumPurple;
            public static Color color8 = Color.Brown;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                btnEstadoFrm.IconChar = currentBtn.IconChar;
                btnEstadoFrm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
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

        private void ButtonBlock()
        {
            FrmReporte FrmReporte = new FrmReporte();

            btnGestionPermisos.Visible = false;
            btnGestionRol.Visible = false;
            btnGestionUsuario.Visible = false;
            btnGestionCargo.Visible = false;
            FrmReporte.btnEliminarReporte.Visible = false;

        }

        private void CargarUsuario()
        {
            lblUsuario.Text = oUsuario.NombreUsuario.ToUpper();

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
            ActivateButton(sender, RGBColors.color1);
            AbrirFormularios((Button)sender, new FrmGestionEmpleados(oUsuario));
        }

        private void btnLiquidacionTotal_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            AbrirFormularios((Button)sender, new FrmNomina());
        }

        private void btnMantenedorEmpleado_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            AbrirFormularios((Button)sender, new FrmMantenedorEmpleado());
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirFormularios((Button)sender, new FrmGestionCargo());
        }

        private void btnGestionRol_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirFormularios((Button)sender, new FrmGestionRol());
        }

        private void btnGestionUsuario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            AbrirFormularios((Button)sender, new FrmGestionUsuario());
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            AbrirFormularios((Button)sender, new FrmReporte());
        }

        private void btnGestionPermisos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            AbrirFormularios((Button)sender, new FrmGestionPermiso(oUsuario));
        }
    }
}
