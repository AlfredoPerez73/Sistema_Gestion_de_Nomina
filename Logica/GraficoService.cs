using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class GraficoService
    {
        EmpleadoRepository empleadoRepository = new EmpleadoRepository();
        UsuarioRepository usuarioRepository = new UsuarioRepository();
        ReporteRepository reporteRepository = new ReporteRepository();
        DetalleLiquidacionRepository detalleLiquidacionRepository = new DetalleLiquidacionRepository();
        LiquidacionRepository liquidacionRepository = new LiquidacionRepository();
        Liquidacion liquidacion = new Liquidacion();

        public Tuple<int, int, int, decimal> CargarDashBoard()
        {
            try
            {
                int totalEmpleadosValue = empleadoRepository.CargarRegistro().Count;
                int totalUsuariosValue = usuarioRepository.CargarRegistro().Count;
                int totalReportesValue = reporteRepository.CargarRegistro().Count;
                decimal nominaTotalValue = liquidacionRepository.CargarRegistro().Sum(l => l.Total);

                return Tuple.Create(totalEmpleadosValue, totalUsuariosValue, totalReportesValue, nominaTotalValue);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Tuple<List<string>, List<decimal>> GraficoGanancia()
        {
            try
            {
                var ganancias = liquidacionRepository.CargarRegistro();

                List<string> Fecha = new List<string>();
                List<decimal> Total = new List<decimal>();

                foreach (var ganancia in ganancias)
                {
                    Fecha.Add(ganancia.FechaRegistro.ToString("yyyy-MM-dd"));
                    Total.Add(ganancia.Total);
                }

                return Tuple.Create(Fecha, Total);
            }
            catch (Exception)
            {
                return Tuple.Create(new List<string>(), new List<decimal>());
            }
        }

        public Tuple<List<string>, List<int>> CargarGraficoEmplMasLiquidados()
        {
            try
            {
                var empleados = empleadoRepository.CargarRegistro();
                var liquidaciones = detalleLiquidacionRepository.CargarRegistro();
                
                List<string> Emp = new List<string>();
                List<int> Liqui = new List<int>();
                
                var empLiqui = empleados.Zip(liquidaciones, (emp, liq) => new { Empleado = emp.Nombre, Liquidaciones = detalleLiquidacionRepository.CargarRegistro().Count })
                                        .OrderByDescending(x => x.Liquidaciones)
                                        .ToList();
                
                Emp.AddRange(empLiqui.Select(x => x.Empleado));
                Liqui.AddRange(empLiqui.Select(x => x.Liquidaciones));

                return Tuple.Create(Emp, Liqui);
            }
            catch (Exception)
            {
                return Tuple.Create(new List<string>(), new List<int>());
            }
        }
    }
}
