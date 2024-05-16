using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ReporteService
    {
        ReporteRepository reporteRepository = new ReporteRepository();

        public List<Reporte> CargarRegistro()
        {
            var msg = reporteRepository.CargarRegistro();
            return msg;
        }

        public List<Reporte> CargarRegistroPorId(int id)
        {
            var msg = reporteRepository.CargarRegistroPorId(id);
            return msg;
        }

        public string EliminarRegistros(Reporte reporte)
        {
            var msg = reporteRepository.EliminarRegistros(reporte);
            return msg;
        }

        public string Guardar(Reporte reporte)
        {
            var msg = reporteRepository.GuardarRegistros(reporte);
            return msg;
        }

    }
}
