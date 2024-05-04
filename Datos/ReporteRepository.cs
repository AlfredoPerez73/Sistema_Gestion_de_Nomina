using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ReporteRepository : ConexionRepository
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();

        public ReporteRepository() : base()
        {

        }

        public List<Reporte> CargarRegistro()
        {
            List<Reporte> reporteList = new List<Reporte>();
            string Consulta = "SELECT * FROM REPORTE";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    reporteList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return reporteList;
        }

        public List<Reporte> CargarRegistroPorId(int IdReporte)
        {
            List<Reporte> reporteList = new List<Reporte>();
            string Consulta = "SELECT * FROM REPORTE WHERE IdReporte = @IdReporte";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                command.Parameters.AddWithValue("@IdReporte", IdReporte);
                command.CommandType = CommandType.Text;
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    reporteList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return reporteList;
        }

        public string GuardarRegistros(Reporte reporte)
        {
            try
            {
                string Registro = "INSERT INTO REPORTE(Reporte, Documento, Extension, IdUsuario, Usuario) VALUES" +
                    "(@NombreReporte, @Documento, @Extension, @IdUsuario, @Usuario);";

                SqlCommand command = new SqlCommand(Registro, Connection);
                command.Parameters.AddWithValue("@NombreReporte", reporte.NombreReporte);
                command.Parameters.AddWithValue("@Documento", reporte.Documento);
                command.Parameters.AddWithValue("@Extension", reporte.Extension);
                command.Parameters.AddWithValue("@IdUsuario", reporte.Usuario.IdPersona);
                command.Parameters.AddWithValue("@Usuario", reporte.Usuario.Nombre);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();

                return $"Se ha registrado el reporte {reporte.NombreReporte}";
            }
            catch (Exception)
            {
                return $"Error al intentar registrar el reporte";
            }
        }

        public string EliminarRegistros(Reporte reporte)
        {
            try
            {
                string Eliminar = "EliminarReportes";

                SqlCommand command = new SqlCommand(Eliminar, Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdReporte", reporte.IdReporte);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al eliminar el reporte, " +
                    "el reporte se encuentra relacionado";
            }
            return $"Se ha eliminado el reporte {reporte.NombreReporte} " +
                $"con la ID {reporte.IdReporte}";
        }

        private Reporte Map(SqlDataReader reader)
        {
            Reporte reporte = new Reporte
            {
                IdReporte = Convert.ToInt32(reader["IdReporte"]),
                NombreReporte = Convert.ToString(reader["Reporte"]),
                Documento = (byte[])reader["Documento"],
                Extension = Convert.ToString(reader["Extension"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
            };

            int IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
            string NombreUsuario = Convert.ToString(reader["Usuario"]);

            reporte.Usuario = usuarioRepository.ObtenerUsuario(IdUsuario, NombreUsuario);
            return reporte;
        }
    }
}
