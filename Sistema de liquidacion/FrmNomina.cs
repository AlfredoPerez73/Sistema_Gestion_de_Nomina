using Entidad;
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

namespace Sistema_de_liquidacion
{
    public partial class FrmNomina : Form
    {
        private LiquidacionService liquidacionService = new LiquidacionService();
        private GraficoService GraficoService = new GraficoService();

        public FrmNomina()
        {
            InitializeComponent();
        }

        private void CargarRegistro()
        {
            Visualizer(liquidacionService.CargarRegistro());
        }

        private void Visualizer(List<Liquidacion> lista2)
        {
            tblRegistroDetalleLiquidaciones.Rows.Clear();
            if (lista2 != null)
            {
                foreach (var item in lista2)
                {
                    int index = tblRegistroDetalleLiquidaciones.Rows.Add();
                    DataGridViewRow row = tblRegistroDetalleLiquidaciones.Rows[index];
                    row.Cells["IdFactura"].Value = item.IdFactura;
                    row.Cells["Año"].Value = item.Año;
                    row.Cells["Mes"].Value = item.Mes;
                    row.Cells["SalarioTotal"].Value = item.SalarioTotal.ToString("C");
                    row.Cells["SaludTotal"].Value = item.SaludTotal.ToString("C");
                    row.Cells["PensionTotal"].Value = item.PensionTotal.ToString("C");
                    row.Cells["AuxTotal"].Value = item.AuxTransporte.ToString("C");
                    row.Cells["BonificacionTotal"].Value = item.BonificacionServiciosTotal.ToString("C");
                    row.Cells["PrimaSTotal"].Value = item.PrimaServiciosTotal.ToString("C");
                    row.Cells["AuxATotal"].Value = item.AuxAlimentacionTotal.ToString("C");
                    row.Cells["PrimaNTotal"].Value = item.PrimaNavidadTotal.ToString("C");
                    row.Cells["TotalGeneral"].Value = item.Total.ToString("C");
                    row.Cells["FechaRegistro"].Value = item.FechaRegistro.ToString("d");
                }
            }
        }

        private void CargarGraficos()
        {

        }

        private void FiltroLiquidaciones()
        {
            if (cboFiltroAño.SelectedIndex > 0 || cboFiltroMes.SelectedIndex > 0 || cboFiltroAño.SelectedIndex == 0 ||
                cboFiltroMes.SelectedIndex == 0)
            {
                var listaFiltrada = liquidacionService.FiltroLiquidaciones(
                    Convert.ToInt32(cboFiltroAño.SelectedItem),
                    Convert.ToInt32(cboFiltroMes.SelectedItem));

                Visualizer(listaFiltrada);
            }
        }

        private void FiltrarLiquidaciones()
        {
            DateTime fechaInicio = dpFechaInicial.Value;
            DateTime fechaFin = dpFechaFinal.Value;
            var resultado = liquidacionService.FiltroLiquidacionesPorRango(fechaInicio, fechaFin);
            Visualizer(resultado);
        }

        private void CargarAños()
        {
            LiquidacionService liquidacionService = new LiquidacionService();
            var liquidaciones = liquidacionService.CargarRegistro();
            var añosUnicos = liquidaciones.Select(liquidacion => liquidacion.Año).Distinct().ToList();
            var mesesUnicos = liquidaciones.Select(liquidacion => liquidacion.Mes).Distinct().ToList();

            añosUnicos.Insert(0, Convert.ToInt32(null));
            mesesUnicos.Insert(0, Convert.ToInt32(null));
            cboFiltroAño.DataSource = añosUnicos;
            cboFiltroMes.DataSource = mesesUnicos;

            cboFiltroMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroMes.SelectedIndex = 0;
            cboFiltroAño.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroAño.SelectedIndex = 0;
        }

        private void FrmLiquidacionTotal_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel2, 15);
            BorderRadiusPanel(panel3, 15);
            BorderRadiusPanel(panel4, 20);
            BorderRadiusPanel(panel5, 15);
            BorderRadiusPanel(panel6, 15);
            BorderRadiusPanel(panel7, 20);
            BorderRadiusPanel(panel9, 20);

            cboFiltroAño.OnSelectedIndexChanged += cboFiltroAño_OnSelectedIndexChanged;
            cboFiltroMes.OnSelectedIndexChanged += cboFiltroMes_OnSelectedIndexChanged;

            CargarAños();
            CargarGraficos();
            CargarRegistro();
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

        private void cboFiltroAño_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FiltroLiquidaciones();
        }

        private void cboFiltroMes_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FiltroLiquidaciones();
        }

        private void tblRegistroDetalleLiquidaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {

        }

        private void cboFiltroAño_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            FiltrarLiquidaciones();
        }

        private void dpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            FiltrarLiquidaciones();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
