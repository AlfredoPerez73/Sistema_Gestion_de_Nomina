using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class GraficoService
    {
        GraficosRepository graficosRepository = new GraficosRepository();

        public Tuple<List<string>, List<int>> CargarGraficos()
        {
            return graficosRepository.CargarGraficoEmplXCargo();
        }

        public Tuple<List<string>, List<int>> CargarGraficos2()
        {
            return graficosRepository.CargarGraficoEmplMasLiquidados();
        }

        public Tuple<List<string>, List<decimal>> CargarGraficos3()
        {
            return graficosRepository.GraficoGanancia();
        }

        public Tuple<int, int, int, decimal> CargarDashBoard()
        {
            return graficosRepository.CargarDashBoard();
        }
    }
}
