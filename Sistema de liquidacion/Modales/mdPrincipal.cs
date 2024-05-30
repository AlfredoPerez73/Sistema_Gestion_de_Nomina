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
            BorderRadiusPanel(panel1, 20);
            BorderRadiusPanel(panel2, 20);
            BorderRadiusPanel(panel11, 20);
            BorderRadiusPanel(panel11, 20);

            CargarDashBoard();
            CargarGraficos();
        }

        private void CargarDashBoard()
        {
            var results = graficoService.CargarDashBoard();
            var results2 = graficoService.CargarSalarioTotal();
            lblNumEmpleados.Text = Convert.ToString(results.Item1);
            lblNumUsuarios.Text = Convert.ToString(results.Item2);
            lblNumReportes.Text = Convert.ToString(results.Item3);
            lblTotalHoras.Text = Convert.ToString(results.Item4);
            lblDiasTotales.Text = Convert.ToString(results.Item5);
            lblValTotalHoras.Text = results.Item6.ToString("C");
            lblNominaTotal.Text = results.Item7.ToString("C");
            lblTotalSalario.Text = results2.ToString("C");
        }

        private void CargarGraficos()
        {
            var result = graficoService.CargarGraficoEmplMasLiquidados();
            var result2 = graficoService.GraficoGanancia();
            var result3 = graficoService.ObtenerEmpleadosConMasHorasRealizadas();
            var result4 = graficoService.ObtenerEmpleadosConMasHorasPagadas();

            List<string> listaEmpl = result.Item1;
            List<int> listaLiquid = result.Item2;

            List<string> AñoMes = result2.Item1;
            List<decimal> Total = result2.Item2;

            List<string> empleadoHoras = result3.Item1;
            List<int> horas = result3.Item2;

            List<string> empleadoValHoras = result4.Item1;
            List<decimal> valHoras = result4.Item2;

            chGanancia.Series[0].Points.DataBindXY(AñoMes, Total);
            chEmplMasLiquidados.Series[0].Points.DataBindXY(listaEmpl, listaLiquid);
            chHorasRealizadas.Series[0].Points.DataBindXY(empleadoHoras, horas);
            chValorHoras.Series[0].Points.DataBindXY(empleadoValHoras, valHoras);
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
