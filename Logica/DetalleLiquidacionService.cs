using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Logica
{
    public class DetalleLiquidacionService
    {
        private DetalleLiquidacionRepository detalleLiquidacionRepository = new DetalleLiquidacionRepository();

        public List<DetalleLiquidacion> CargarRegistro()
        {
            var msg = detalleLiquidacionRepository.CargarRegistro();
            return msg;
        }

        public bool BuscarIdLiquidacion(int año, int mes, string idProducto, int idFactura)
        {
            return CargarRegistro().Any(l => (l.empleado.IdProducto == Convert.ToInt32(idProducto) || l.liquidacion.IdFactura != idFactura)
                                         && l.liquidacion.Año == año
                                         && l.liquidacion.Mes == mes);
        }

        public List<DetalleLiquidacion> FiltroLiquidaciones(DateTime fechaInicio, DateTime fechaFin)
        {
            var listaFiltrada = CargarRegistro();

            if (fechaInicio != DateTime.MinValue)
            {
                listaFiltrada = listaFiltrada.Where(dl => dl.liquidacion.FechaRegistro.Date >= fechaInicio.Date).ToList();
            }
            if (fechaFin != DateTime.MinValue)
            {
                fechaFin = fechaFin.Date.AddDays(1).AddTicks(-1);
                listaFiltrada = listaFiltrada.Where(dl => dl.liquidacion.FechaRegistro.Date <= fechaFin.Date).ToList();
            }

            return listaFiltrada;
        }

        public List<DetalleLiquidacion> FiltroEstado(string estado)
        {
            return CargarRegistro().Where(e => e.empleado.Estado == estado).ToList();
        }

        public string Guardar(DetalleLiquidacion detalle)
        {

            var msg = detalleLiquidacionRepository.GuardarRegistros(detalle);
            return msg;
        }

        public List<DetalleLiquidacion> BuscarX(string valor)
        {
            return CargarRegistro().Where(e => e.empleado.Documento == valor ||
            e.empleado.Nombre == valor.ToUpper() || e.empleado.Cargo.CargoDesempeñado == valor).ToList();
        }
    }
}
