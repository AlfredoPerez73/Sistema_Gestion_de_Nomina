﻿using Entidad;
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

        private void CargarRegistroLiquidacion(List<Liquidacion> lista2)
        {
            tblRegistroDetalleLiquidaciones.Rows.Clear();
            if (lista2 != null)
            {
                foreach (var liquidacion in lista2)
                {
                    int index = tblRegistroDetalleLiquidaciones.Rows.Add();
                    DataGridViewRow row = tblRegistroDetalleLiquidaciones.Rows[index];
                    row.Cells["IdFactura"].Value = liquidacion.IdFactura;
                    row.Cells["Año"].Value = liquidacion.Año;
                    row.Cells["Mes"].Value = liquidacion.Mes;
                    row.Cells["SalarioTotal"].Value = liquidacion.SalarioTotal.ToString("C");
                    row.Cells["SaludTotal"].Value = liquidacion.SaludTotal.ToString("C");
                    row.Cells["PensionTotal"].Value = liquidacion.PensionTotal.ToString("C");
                    row.Cells["AuxTotal"].Value = liquidacion.AuxTransporte.ToString("C");
                    row.Cells["BonificacionTotal"].Value = liquidacion.BonificacionServiciosTotal.ToString("C");
                    row.Cells["PrimaSTotal"].Value = liquidacion.PrimaServiciosTotal.ToString("C");
                    row.Cells["AuxATotal"].Value = liquidacion.AuxAlimentacionTotal.ToString("C");
                    row.Cells["PrimaNTotal"].Value = liquidacion.PrimaNavidadTotal.ToString("C");
                    row.Cells["TotalGeneral"].Value = liquidacion.Total.ToString("C");
                    row.Cells["FechaRegistro"].Value = liquidacion.FechaRegistro.ToString("d");
                }
            }
        }

        private void CargarGraficos()
        {

        }

        private void FiltroLiquidaciones()
        {

        }

        private void FiltrarLiquidaciones()
        {

        }

        private void CargarAños()
        {

        }

        private void FrmLiquidacionTotal_Load(object sender, EventArgs e)
        {
            CargarAños();
            BorderRadiusPanel(panel2, 15);
            BorderRadiusPanel(panel3, 15);
            BorderRadiusPanel(panel4, 20);
            BorderRadiusPanel(panel5, 15);
            BorderRadiusPanel(panel6, 15);
            BorderRadiusPanel(panel7, 20);
            BorderRadiusPanel(panel9, 20);

            cboFiltroAño.OnSelectedIndexChanged += cboFiltroAño_OnSelectedIndexChanged;
            cboFiltroMes.OnSelectedIndexChanged += cboFiltroMes_OnSelectedIndexChanged;

            CargarGraficos();
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