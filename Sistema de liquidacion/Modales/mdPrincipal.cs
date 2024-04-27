using Logica;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Sistema_de_liquidacion.Modales
{
    public partial class mdPrincipal : Form
    {
        GraficoService graficoService = new GraficoService();

        public mdPrincipal()
        {
            InitializeComponent();
        }

        private void CargarDashBoard()
        {
        }

        private void CargarGraficos()
        {
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

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

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void mdPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();

            BorderRadiusPanel(panel1, 20);
            BorderRadiusPanel(panel2, 20);
            BorderRadiusPanel(panel3, 20);
            BorderRadiusPanel(panel4, 20);
            BorderRadiusPanel(panel5, 20);
            BorderRadiusPanel(panel7, 20);

            CargarGraficos();
            CargarDashBoard();
        }

        private void icoEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void icoGraficoEmplXCargo_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void chEmpXcategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
