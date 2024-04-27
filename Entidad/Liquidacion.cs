using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Liquidacion
    {
        public int IdFactura { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public decimal SalarioTotal { get; set; }
        public decimal SaludTotal { get; set; }
        public decimal PensionTotal { get; set; }
        public decimal AuxTransporte { get; set; }
        public decimal BonificacionServiciosTotal { get; set; }
        public decimal PrimaServiciosTotal { get; set; }
        public decimal AuxAlimentacionTotal { get; set; }
        public decimal PrimaNavidadTotal { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaRegistro { get; set; }

        public void CalcularTotales(List<DetalleLiquidacion> detalles)
        {
            SalarioTotal = detalles.Sum(dl => dl.Devengado);
            SaludTotal = detalles.Sum(dl => dl.Salud);
            PensionTotal = detalles.Sum(dl => dl.Pension);
            AuxTransporte = detalles.Sum(dl => dl.AuxTransporte);
            BonificacionServiciosTotal = detalles.Sum(dl => dl.BonificacionServicios);
            PrimaServiciosTotal = detalles.Sum(dl => dl.PrimaServicios);
            AuxAlimentacionTotal = detalles.Sum(dl => dl.AuxAlimentacion);
            PrimaNavidadTotal = detalles.Sum(dl => dl.PrimaNavidad);
            Total = detalles.Sum(dl => dl.Devengado + dl.Salud + dl.Pension + dl.AuxTransporte + dl.BonificacionServicios + dl.PrimaServicios + dl.AuxAlimentacion + dl.PrimaNavidad);
        }
    }
}
