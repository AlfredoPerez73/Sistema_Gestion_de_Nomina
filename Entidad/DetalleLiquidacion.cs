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
        public Empleado empleado { get; set; }
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
        public decimal Vacaciones { get; set; }
        public decimal Cesantia { get; set; }
        public decimal InteresesCesantia { get; set; }
        public decimal Devengado { get; set; }
        public DateTime FechaRegistro { get; set; }

        public void ActualizarDetalles()
        {
            Salud = empleado.Contrato.Salario * 0.04m;
            Pension = empleado.Contrato.Salario * 0.04m;
            AuxTransporte = empleado.Contrato.Salario <= (1300000 * 2) ? 162000 : 0;
            AuxAlimentacion = empleado.Contrato.Salario / DiasTrabajados;

            if (empleado.Contrato.TipoContrato == "CONTRATO FIJO" || empleado.Contrato.TipoContrato == "TERMINO INDEFINIDO")
            {
                BonificacionServicios = empleado.Contrato.Salario < 1400000 ? empleado.Contrato.Salario * 0.5m : 0;
                PrimaServicios = liquidacion.Mes == 6 ? (empleado.Contrato.Salario * DiasTrabajados) / 180 :
                                                        liquidacion.Mes == 12 ? (empleado.Contrato.Salario * DiasTrabajados) / 360 : 0;
                PrimaNavidad = liquidacion.Mes == 12 ? empleado.Contrato.Salario * 0.5m : 0;
                Vacaciones = (empleado.Contrato.Salario * DiasTrabajados) / 720;
                Cesantia = (empleado.Contrato.Salario * DiasTrabajados) / 360;
                InteresesCesantia = Cesantia * 0.12m;
                ValorHorasExtra = HorasExtras > 0 ? empleado.Contrato.Salario / HorasExtras : 0;
            }

            if (empleado.Contrato.TipoContrato == "PRESTACION DE SERVICIO")
            {
                Salud = 0;
                Pension = 0;
                AuxTransporte = 0;
                AuxAlimentacion = 0;
                ValorHorasExtra = 0;
            }
            Devengado = empleado.Contrato.Salario - Salud - Pension + AuxTransporte + BonificacionServicios +
                        PrimaServicios + AuxAlimentacion + PrimaNavidad + ValorHorasExtra + Cesantia +
                        InteresesCesantia + Vacaciones;
        }
    }
}
