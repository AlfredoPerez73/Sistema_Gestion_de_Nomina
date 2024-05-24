using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CargoRepository : ConexionRepository
    {
        public CargoRepository() : base()
        {

        }

        public List<Cargo> CargarRegistro()
        {
            List<Cargo> cargoList = new List<Cargo>();
            string Consulta = "SELECT * FROM CARGO";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cargoList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return cargoList;
        }

        public string GuardarRegistros(Cargo cargo)
        {
            try
            {
                string Registro = "INSERT INTO CARGO(NCargo) VALUES" +
                    "('" + cargo.CargoDesempeñado + "');";
                SqlCommand command = new SqlCommand(Registro, Connection);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return $"Se ha registrado el producto {cargo.CargoDesempeñado}";
        }

        public string ModificarRegistros(Cargo cargo)
        {
            try
            {
                string Actualizar = "ModificarCargos";
                SqlCommand command = new SqlCommand(Actualizar, Connection);
                command.Parameters.AddWithValue("@NCargo", cargo.CargoDesempeñado);
                command.Parameters.AddWithValue("@IdCargo", cargo.IdCargo);
                command.CommandType = CommandType.StoredProcedure;
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al modificar el cargo, " +
                    "el cargo se encuentra relacionado con un empleado";
            }

            return $"Se ha modificado el cargo {cargo.CargoDesempeñado} " +
                $"con la ID {cargo.IdCargo}";
        }

        public string EliminarRegistros(Cargo cargo)
        {
            try
            {
                string Eliminar = "EliminarCargos";

                SqlCommand command = new SqlCommand(Eliminar, Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdCargo", cargo.IdCargo);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al eliminar el cargo, " +
                    "el cargo se encuentra relacionado con un empleado";
            }
            return $"Se ha eliminado el cargo {cargo.CargoDesempeñado} " +
                $"con la ID {cargo.IdCargo}";
        }

        private Cargo Map(SqlDataReader reader)
        {
            Cargo cargo = new Cargo
            {
                IdCargo = Convert.ToInt32(reader["IdCargo"]),
                CargoDesempeñado = Convert.ToString(reader["NCargo"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
            };
            return cargo;
        }

        public Cargo ObtenerCategoria(int id, string cargo)
        {
            return CargarRegistro().Find(c => c.IdCargo == id && c.CargoDesempeñado == cargo);
        }

        public Cargo ObtenerCategoria(string cargo)
        {
            return CargarRegistro().Find(c => c.CargoDesempeñado == cargo);
        }

    }
}
