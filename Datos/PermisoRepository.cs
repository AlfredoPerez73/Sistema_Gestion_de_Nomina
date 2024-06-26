﻿using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PermisoRepository : ConexionRepository
    {
        RolRepository rolRepository = new RolRepository();

        public PermisoRepository() : base()
        {

        }

        public List<Permiso> CargarRegistro()
        {
            List<Permiso> permisoList = new List<Permiso>();
            string Consulta = "SELECT * FROM PERMISO";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    permisoList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return permisoList;
        }

        public List<Permiso> ValidacionPermiso(string IdUsuario)
        {
            List<Permiso> permisoList = new List<Permiso>();
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("select p.IdRol,p.NPermiso from PERMISO p");
            stringBuilder.AppendLine("inner join ROL r on r.IdRol = p.IdRol");
            stringBuilder.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
            stringBuilder.AppendLine("where u.IdUsuario = @IdUsuario");
            try
            {
                SqlCommand command = new SqlCommand(stringBuilder.ToString(), Connection);
                command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                command.CommandType = CommandType.Text;
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    permisoList.Add(Map2(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return permisoList;
        }

        public string GuardarRegistros(Permiso permiso)
        {
            try
            {
                string Registro = "INSERT INTO PERMISO(NPermiso,IdRol,NRol) VALUES" +
                    "('" + permiso.NPermiso + "','" + permiso.Rol.IdRol + "', '" + permiso.Rol.NRol + "');";
                SqlCommand command = new SqlCommand(Registro, Connection);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return $"Se ha registrado el permiso {permiso.NPermiso}";
        }

        public string ModificarRegisro(Permiso permiso)
        {
            try
            {
                string Actualizar = "ModificarPermiso";
                SqlCommand command = new SqlCommand(Actualizar, Connection);
                command.Parameters.AddWithValue("@Permiso", permiso.NPermiso);
                command.Parameters.AddWithValue("@IdRol", permiso.Rol.IdRol);
                command.Parameters.AddWithValue("@NRol", permiso.Rol.IdRol);
                command.Parameters.AddWithValue("@IdPermiso", permiso.IdPermiso);
                command.CommandType = CommandType.StoredProcedure;
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al modificar el permiso, " +
                    "el permiso se encuentra relacionado";
            }

            return $"Se ha modificado el permiso {permiso.NPermiso} " +
                $"con la ID {permiso.IdPermiso}";
        }

        public string EliminarRegistros(Permiso permiso)
        {
            try
            {
                string Eliminar = "EliminarPermiso";

                SqlCommand command = new SqlCommand(Eliminar, Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdPermiso", permiso.IdPermiso);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al eliminar el permiso, " +
                   "el permiso se encuentra relacionado";
            }
            return $"Se ha eliminado el permiso {permiso.NPermiso} " +
                $"con la ID {permiso.IdPermiso}";
        }

        private Permiso Map(SqlDataReader reader)
        {
            Permiso permiso = new Permiso
            {
                IdPermiso = Convert.ToInt32(reader["IdPermiso"]),
                NPermiso = Convert.ToString(reader["NPermiso"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };
            int IdRol = Convert.ToInt32(reader["IdRol"]);
            string NRol = Convert.ToString(reader["NRol"]);
            permiso.Rol = rolRepository.ObtenerRol(IdRol, NRol);
            return permiso;
        }

        private Permiso Map2(SqlDataReader reader)
        {
            Permiso permiso = new Permiso
            {
                NPermiso = Convert.ToString(reader["NPermiso"]),
            };
            int IdRol = Convert.ToInt32(reader["IdRol"]);
            permiso.Rol = rolRepository.ObtenerRol(IdRol);
            return permiso;
        }

    }
}
