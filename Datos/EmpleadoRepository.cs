using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class EmpleadoRepository : ConexionRepository
    {
        private CargoRepository cargoRepository = new CargoRepository();

        public EmpleadoRepository() : base()
        {

        }

        public List<Empleado> CargarRegistro()
        {
            List<Empleado> productoList = new List<Empleado>();
            string Consulta = "SELECT * FROM vw_EmpleadoEstado";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productoList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return productoList;
        }

        public string GuardarRegistros(Empleado producto)
        {
            try
            {
                string Registro = "INSERT INTO PRODUCTO(Documento,Nombre,Estado,IdCargo,Cargo,FechaInicio,FechaFin," +
                    "Salario,TipoContrato) VALUES" +
                    "('" + producto.Documento + "','" + producto.Nombre + "', '" +
                    producto.Estado + "', '" + producto.Cargo.IdCargo + "', '" + producto.Cargo.CargoDesempeñado + "', '" +
                    producto.Contrato.FechaInicio + "', '" + producto.Contrato.FechaFin + "', '" + producto.Contrato.Salario + "', '" + producto.Contrato.TipoContrato + "'); ";
                SqlCommand command = new SqlCommand(Registro, Connection);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return $"Se ha registrado el producto {producto.Nombre}";
        }

        public string ModificarRegistros(Empleado producto)
        {
            try
            {
                string Actualizar = "ModificarEmpleados";
                SqlCommand command = new SqlCommand(Actualizar, Connection);
                command.Parameters.AddWithValue("@Documento", producto.Documento);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Estado", producto.Estado);
                command.Parameters.AddWithValue("@IdContrato", producto.Contrato.IdContrato);
                command.Parameters.AddWithValue("@IdCargo", producto.Cargo.IdCargo);
                command.Parameters.AddWithValue("@NCargo", producto.Cargo.CargoDesempeñado);
                command.Parameters.AddWithValue("@FechaInicio", producto.Contrato.FechaInicio);
                command.Parameters.AddWithValue("@FechaFin", producto.Contrato.FechaFin);
                command.Parameters.AddWithValue("@Salario", producto.Contrato.Salario);
                command.Parameters.AddWithValue("@TipoContrato", producto.Contrato.TipoContrato);
                command.Parameters.AddWithValue("@IdProducto", producto.IdPersona);
                command.CommandType = CommandType.StoredProcedure;
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al modificar el producto, " +
                    "el producto se encuentra relacionado";
            }

            return $"Se ha modificado el producto {producto.Nombre} " +
                $"con la ID {producto.IdPersona}";
        }

        private Empleado Map(SqlDataReader reader)
        {
            Empleado producto = new Empleado
            {
                IdPersona = Convert.ToInt32(reader["IdProducto"]),
                Documento = Convert.ToString(reader["Documento"]),
                Nombre = Convert.ToString(reader["Nombre"]),
                Estado = Convert.ToString(reader["Estado"]),
                Contrato = new Contrato
                {
                    IdContrato = Convert.ToInt32(reader["IdContrato"]),
                    FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                    FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                    Salario = Convert.ToDecimal(reader["Salario"]),
                    TipoContrato = Convert.ToString(reader["TipoContrato"]),
                },
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
            };
            int IdCargo = Convert.ToInt32(reader["IdCargo"]);
            string Cargo = Convert.ToString(reader["Cargo"]);
            producto.Cargo = cargoRepository.ObtenerCategoria(IdCargo, Cargo);

            return producto;
        }

    }
}

