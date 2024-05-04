using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class LiquidacionService
    {
        private LiquidacionRepository liquidacionRepository = new LiquidacionRepository();

        public List<Liquidacion> CargarRegistro()
        {
            var msg = liquidacionRepository.CargarRegistro();
            return msg;
        }

        public List<Liquidacion> FiltroLiquidaciones(int cboFiltroAño, int cboFiltroMes)
        {
            var listaFiltrada = CargarRegistro();

            if (cboFiltroAño > 0)
            {
                listaFiltrada = listaFiltrada.Where(l => l.Año == Convert.ToInt32(cboFiltroAño)).ToList();
            }
            if (cboFiltroMes > 0)
            {
                listaFiltrada = listaFiltrada.Where(l => l.Mes == Convert.ToInt32(cboFiltroMes)).ToList();
            }
            return listaFiltrada;
        }

        public List<Liquidacion> FiltroLiquidacionesPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            var listaFiltrada = CargarRegistro();

            if (fechaInicio != DateTime.MinValue)
            {
                listaFiltrada = listaFiltrada.Where(dl => dl.FechaRegistro.Date >= fechaInicio.Date).ToList();
            }
            if (fechaFin != DateTime.MinValue)
            {
                fechaFin = fechaFin.Date.AddDays(1).AddTicks(-1);
                listaFiltrada = listaFiltrada.Where(dl => dl.FechaRegistro.Date <= fechaFin.Date).ToList();
            }

            return listaFiltrada;
        }
    }
}
