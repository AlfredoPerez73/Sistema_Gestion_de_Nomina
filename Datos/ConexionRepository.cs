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
        protected string StringConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=BDSISTEMA_LIQUIDACION;Integrated Security=True";

        public ConexionRepository()
        {
            Connection = new SqlConnection(StringConnection);
        }

        public string AbrirConnection()
        {
            Connection.Open();
            return Connection.State.ToString();
        }

        public string CerrarConnection()
        {
            Connection.Close();
            return Connection.State.ToString();
        }
    }
}
