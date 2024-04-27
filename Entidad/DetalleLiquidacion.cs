using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DetalleLiquidacion
    {
        public int IdDetalle { get; set; }
        public string Codigo { get; set; }
        public Liquidacion liquidacion { get; set; }
        public Producto producto { get; set; }
        public Usuario usuario { get; set; }
        public int DiasTrabajados { get; set; }
        public int HorasExtras { get; set; }
        public decimal Salud { get; set; }
        public decimal Pension { get; set; }
        public decimal ValorHorasExtra { get; set; }
        public decimal AuxTransporte { get; set; }
        public decimal BonificacionServicios { get; set; }
        public decimal PrimaServicios { get; set; }
        public decimal AuxAlimentacion { get; set; }
        public decimal PrimaNavidad { get; set; }
        public decimal Devengado { get; set; }
        public DateTime FechaRegistro { get; set; }

        public void ActualizarDetalles(Producto producto, Liquidacion liquidacion)
        {
            Salud = producto.Contrato.Salario * 0.05m;
            Pension = producto.Contrato.Salario * 0.1m;
            ValorHorasExtra = HorasExtras > 0 ? producto.Contrato.Salario / HorasExtras : 0;
            AuxTransporte = producto.Contrato.Salario <= (1300000 * 2) ? 106454 : 0;
            BonificacionServicios = producto.Contrato.Salario < 1400000 ? producto.Contrato.Salario * 0.5m : 0;
            PrimaServicios = liquidacion.Mes == 6 ? (producto.Contrato.Salario * DiasTrabajados) / 180 :
                             liquidacion.Mes == 12 ? (producto.Contrato.Salario * DiasTrabajados) / 360 : 0;
            AuxAlimentacion = producto.Contrato.Salario / DiasTrabajados;
            PrimaNavidad = liquidacion.Mes == 12 ? producto.Contrato.Salario * 0.5m : 0;
            Devengado = producto.Contrato.Salario - Salud - Pension + AuxTransporte + BonificacionServicios +
                        PrimaServicios + AuxAlimentacion + PrimaNavidad + ValorHorasExtra;
        }
    }
}
