using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ContratoRepository : ConexionRepository
    {
        public ContratoRepository() : base()
        {

        }

        public List<Contrato> CargarRegistro()
        {
            List<Contrato> contratoList = new List<Contrato>();
            string Consulta = "SELECT * FROM CONTRATO";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    contratoList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return contratoList;
        }

        private Contrato Map(SqlDataReader reader)
        {
            Contrato contrato = new Contrato
            {
                IdContrato = Convert.ToInt32(reader["IdContrato"]),
                FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                Salario = Convert.ToDecimal(reader["Salario"]),
                TipoContrato = Convert.ToString(reader["TipoContrato"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
            };
            return contrato;
        }

    }
}
