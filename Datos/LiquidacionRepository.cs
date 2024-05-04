using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class LiquidacionRepository : ConexionRepository
    {
        public LiquidacionRepository() : base()
        {

        }

        public List<Liquidacion> CargarRegistro()
        {
            List<Liquidacion> liquidacionList = new List<Liquidacion>();
            string Consulta = "SELECT * FROM LIQUIDACION";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    liquidacionList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return liquidacionList;
        }

        private Liquidacion Map(SqlDataReader reader)
        {
            Liquidacion liquidacion = new Liquidacion
            {
                IdFactura = Convert.ToInt32(reader["IdFactura"]),
                Año = Convert.ToInt32(reader["Año"]),
                Mes = Convert.ToInt32(reader["Mes"]),
                SalarioTotal = Convert.ToDecimal(reader["SalarioTotal"]),
                SaludTotal = Convert.ToDecimal(reader["SaludTotal"]),
                PensionTotal = Convert.ToDecimal(reader["PensionTotal"]),
                AuxTransporte = Convert.ToDecimal(reader["AuxTransporte"]),
                BonificacionServiciosTotal = Convert.ToDecimal(reader["BonificacionServiciosTotal"]),
                PrimaServiciosTotal = Convert.ToDecimal(reader["PrimaServiciosTotal"]),
                AuxAlimentacionTotal = Convert.ToDecimal(reader["AuxAlimentacionTotal"]),
                PrimaNavidadTotal = Convert.ToDecimal(reader["PrimaNavidadTotal"]),
                Total = Convert.ToDecimal(reader["Total"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
            };

            return liquidacion;
        }

        public Liquidacion ObtenerLiquidacion(int IdFactura, int Año, int Mes)
        {
            return CargarRegistro().Find(c => c.IdFactura == IdFactura && c.Año == Año && c.Mes == Mes);
        }

    }
}
