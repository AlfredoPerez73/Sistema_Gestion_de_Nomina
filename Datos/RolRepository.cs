using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RolRepository : ConexionRepository
    {
        public RolRepository() : base()
        {

        }

        public List<Rol> CargarRegistro()
        {
            List<Rol> rolList = new List<Rol>();
            string Consulta = "SELECT * FROM ROL";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    rolList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return rolList;
        }

        public string GuardarRegistros(Rol rol)
        {
            try
            {
                string Registro = "INSERT INTO ROL(Rol) VALUES" +
                    "('" + rol.NRol + "');";
                SqlCommand command = new SqlCommand(Registro, Connection);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return $"Se ha registrado el producto {rol.NRol}";
        }

        private Rol Map(SqlDataReader reader)
        {
            Rol rol = new Rol
            {
                IdRol = Convert.ToInt32(reader["IdRol"]),
                NRol = Convert.ToString(reader["Rol"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };

            return rol;
        }

        public Rol ObtenerRol(int IdRol, string rol)
        {
            return CargarRegistro().Find(c => c.IdRol == IdRol && c.NRol == rol);
        }
        public Rol ObtenerRol(int IdRol)
        {
            return CargarRegistro().Find(c => c.IdRol == IdRol);
        }

    }
}
