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

        public Tuple<int, int, int, int, int, decimal, decimal> CargarDashBoard()
        {
            try
            {
                int totalEmpleadosValue = empleadoRepository.CargarRegistro().Count;
                int totalUsuariosValue = usuarioRepository.CargarRegistro().Count;
                int totalReportesValue = reporteRepository.CargarRegistro().Count;
                int totalHorasRealizadas = detalleLiquidacionRepository.CargarRegistro().Sum(d => d.HorasExtras);
                int totalDias = detalleLiquidacionRepository.CargarRegistro().Sum(d => d.DiasTrabajados);
                decimal totalHorasPagadas = detalleLiquidacionRepository.CargarRegistro().Sum(d => d.ValorHorasExtra);
                decimal nominaTotalValue = liquidacionRepository.CargarRegistro().Sum(l => l.Total);

                return Tuple.Create(totalEmpleadosValue, totalUsuariosValue, totalReportesValue, totalHorasRealizadas,
                    totalDias, totalHorasPagadas, nominaTotalValue);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public decimal CargarSalarioTotal()
        {
            decimal totalSalario = empleadoRepository.CargarRegistro().Sum(d => d.Contrato.Salario);
            return totalSalario;
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

        public Tuple<List<string>, List<int>> ObtenerEmpleadosConMasHorasRealizadas()
        {
            try
            {
                var detalles = detalleLiquidacionRepository.CargarRegistro();
                var empleados = empleadoRepository.CargarRegistro();

                var empleadoHoras = detalles.GroupBy(d => d.empleado.IdPersona)
                                            .Select(g => new
                                            {
                                                IdEmpleado = g.Key,
                                                HorasRealizadas = g.Sum(d => d.HorasExtras)
                                            })
                                            .OrderByDescending(eh => eh.HorasRealizadas)
                                            .ToList();

                List<string> nombresEmpleados = new List<string>();
                List<int> horasRealizadas = new List<int>();

                foreach (var empHoras in empleadoHoras)
                {
                    var empleado = empleados.FirstOrDefault(e => e.IdPersona == empHoras.IdEmpleado);
                    if (empleado != null)
                    {
                        nombresEmpleados.Add(empleado.Nombre);
                        horasRealizadas.Add(empHoras.HorasRealizadas);
                    }
                }

                return Tuple.Create(nombresEmpleados, horasRealizadas);
            }
            catch (Exception)
            {
                return Tuple.Create(new List<string>(), new List<int>());
            }
        }

        public Tuple<List<string>, List<decimal>> ObtenerEmpleadosConMasHorasPagadas()
        {
            try
            {
                var detalles = detalleLiquidacionRepository.CargarRegistro();
                var empleados = empleadoRepository.CargarRegistro();

                var empleadoHoras = detalles.GroupBy(d => d.empleado.IdPersona)
                                            .Select(g => new
                                            {
                                                IdEmpleado = g.Key,
                                                HorasPagadas = g.Sum(d => d.ValorHorasExtra)
                                            })
                                            .OrderByDescending(eh => eh.HorasPagadas)
                                            .ToList();

                List<string> nombresEmpleados = new List<string>();
                List<decimal> horasPagadas = new List<decimal>();

                foreach (var empHoras in empleadoHoras)
                {
                    var empleado = empleados.FirstOrDefault(e => e.IdPersona == empHoras.IdEmpleado);
                    if (empleado != null)
                    {
                        nombresEmpleados.Add(empleado.Nombre);
                        horasPagadas.Add(empHoras.HorasPagadas);
                    }
                }

                return Tuple.Create(nombresEmpleados, horasPagadas);
            }
            catch (Exception)
            {
                return Tuple.Create(new List<string>(), new List<decimal>());
            }
        }
    }
}
