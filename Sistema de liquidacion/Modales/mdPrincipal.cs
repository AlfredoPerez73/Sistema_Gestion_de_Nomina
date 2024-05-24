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
using Logica;

namespace Sistema_de_liquidacion.Modales
{
    public partial class mdPrincipal : Form
    {
        GraficoService graficoService = new GraficoService();

        public mdPrincipal()
        {
            InitializeComponent();
        }

        private void mdPrincipal_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel10, 20);
            BorderRadiusPanel(panel11, 20);

            CargarDashBoard();
            CargarGraficos();
        }

        private void CargarDashBoard()
        {
            var results = graficoService.CargarDashBoard();
            lblNumEmpleados.Text = Convert.ToString(results.Item1);
            lblNumUsuarios.Text = Convert.ToString(results.Item2);
            lblNumReportes.Text = Convert.ToString(results.Item3);
            lblNominaTotal.Text = results.Item4.ToString("C");
        }

        private void CargarGraficos()
        {
            var result2 = graficoService.GraficoGanancia();

            var result = graficoService.CargarGraficoEmplMasLiquidados();

            List<string> listaEmpl = result.Item1;
            List<int> listaLiquid = result.Item2;

            List<string> AñoMes = result2.Item1;
            List<decimal> Total = result2.Item2;

            chGanancia.Series[0].Points.DataBindXY(AñoMes, Total);
            chEmplMasLiquidados.Series[0].Points.DataBindXY(listaEmpl, listaLiquid);
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

        private void icoEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
