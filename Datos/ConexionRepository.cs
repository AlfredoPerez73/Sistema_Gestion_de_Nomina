using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConexionRepository
    {
        protected SqlConnection Connection;
        protected string StringConnection = "Server=.\\SQLEXPRESS;DataBase=BDSISTEMA_LIQUIDACION;Integrated Security=True";

        public ConexionRepository()
        {
            Connection = new SqlConnection(StringConnection);
        }

        public string AbrirConnection()
        {
            try
            {
                Connection.Open();
                return Connection.State.ToString();
            }
            catch (SqlException ex)
            {
                return $"Error: {ex.Message} REVISA LA CONEXION...";
            }
        }

        public string CerrarConnection()
        {
            try
            {
                Connection.Close();
                return Connection.State.ToString();
            }
            catch (SqlException ex)
            {
                return $"Error: {ex.Message} REVISA LA CONEXION...";
            }
        }
    }
}
