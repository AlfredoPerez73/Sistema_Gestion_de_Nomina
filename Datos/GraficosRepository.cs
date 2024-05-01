using Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class GraficosRepository:ConexionRepository
    {
        public GraficosRepository() : base()
        {

        }

        public Tuple<List<string>, List<decimal>> GraficoGanancia()
        {
            List<string> Año = new List<string>();
            List<decimal> Total = new List<decimal>();

            string Consulta = "Ganancias";

            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                command.CommandType = CommandType.StoredProcedure;
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Año.Add(reader.GetString(0));
                    Total.Add(reader.GetDecimal(1));
                }

                reader.Close();
                CerrarConnection();

                return Tuple.Create(Año, Total);
            }
            catch (Exception)
            {
                return Tuple.Create(new List<string>(), new List<decimal>());
            }
        }

        public Tuple<List<string>, List<int>> CargarGraficoEmplXCargo()
        {
            List<string> Cargo = new List<string>();
            List<int> CantEmp = new List<int>();

            string Consulta = "EmplXCargo";

            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                command.CommandType = CommandType.StoredProcedure;
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cargo.Add(reader.GetString(0));
                    CantEmp.Add(reader.GetInt32(1));
                }

                reader.Close();
                CerrarConnection();

                return Tuple.Create(Cargo, CantEmp);
            }
            catch (Exception)
            {
                return Tuple.Create(new List<string>(), new List<int>());
            }
        }

        public Tuple<List<string>, List<int>> CargarGraficoEmplMasLiquidados()
        {
            List<string> Emp = new List<string>();
            List<int> Liqui = new List<int>();

            string Consulta = "EmplMasLiquidados";

            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                command.CommandType = CommandType.StoredProcedure;
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Emp.Add(reader.GetString(0));
                    Liqui.Add(reader.GetInt32(1));
                }

                reader.Close();
                CerrarConnection();

                return Tuple.Create(Emp, Liqui);
            }
            catch (Exception)
            {
                return Tuple.Create(new List<string>(), new List<int>());
            }
        }

        public Tuple<int, int, int, decimal> CargarDashBoard()
        {
            string Consulta = "DashBoardDatos";

            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter TotalEmpleados_ = new SqlParameter("@TotalEmpleados", 0); TotalEmpleados_.Direction = ParameterDirection.Output;
                SqlParameter TotalUsuarios_ = new SqlParameter("@TotalUsuarios", 0); TotalUsuarios_.Direction = ParameterDirection.Output;
                SqlParameter TotalReportes_ = new SqlParameter("@TotalReportes", 0); TotalReportes_.Direction = ParameterDirection.Output;
                SqlParameter NominaTotal_ = new SqlParameter("@NominaTotal", 0); NominaTotal_.Direction = ParameterDirection.Output;

                command.Parameters.Add(TotalEmpleados_);
                command.Parameters.Add(TotalUsuarios_);
                command.Parameters.Add(TotalReportes_);
                command.Parameters.Add(NominaTotal_);

                AbrirConnection();
                var index = command.ExecuteNonQuery();

                int totalEmpleadosValue = Convert.ToInt32(command.Parameters["@TotalEmpleados"].Value.ToString());
                int totalUsuariosValue = Convert.ToInt32(command.Parameters["@TotalUsuarios"].Value.ToString());
                int totalReportesValue = Convert.ToInt32(command.Parameters["@TotalReportes"].Value.ToString());
                decimal nominaTotalValue = Convert.ToDecimal(command.Parameters["@NominaTotal"].Value.ToString());

                CerrarConnection();

                return Tuple.Create(totalEmpleadosValue, totalUsuariosValue, totalReportesValue, nominaTotalValue);
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
