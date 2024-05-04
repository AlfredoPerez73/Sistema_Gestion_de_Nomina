using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Xml.Linq;

namespace Datos
{
    public class DetalleLiquidacionRepository : ConexionRepository
    {
        private LiquidacionRepository liquidacionRepository = new LiquidacionRepository();
        private UsuarioRepository usuarioRepository = new UsuarioRepository();
        private CargoRepository cargoRepository = new CargoRepository();

        public DetalleLiquidacionRepository() : base()
        {

        }

        public List<DetalleLiquidacion> CargarRegistro()
        {
            List<DetalleLiquidacion> detalleLiquidacionList = new List<DetalleLiquidacion>();
            string Consulta = "SELECT * FROM DETALLE_LIQUIDACION";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    detalleLiquidacionList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return detalleLiquidacionList;
        }

        public string GuardarRegistros(DetalleLiquidacion detalle)
        {
            try
            {
                string Registro = "INSERT INTO DETALLE_LIQUIDACION(Codigo,DiasTrabajados,HorasExtras,Salud,Pension,ValorHorasExtra,AuxTransporte," +
                        "BonificacionServicios,PrimaServicios,AuxAlimentacion,PrimaNavidad,Devengado,IdProducto,Documento," +
                        "Nombre,NCargo,Salario,Estado,IdFactura,Año,Mes,IdUsuario,NombreUsuario) VALUES" +
                        "(@Codigo,@DiasTrabajados,@HorasExtras,@Salud, @Pension, @ValorHorasExtra, @AuxTransporte, @BonificacionServicios, @PrimaServicios, " +
                        "@AuxAlimentacion, @PrimaNavidad, @Devengado, @IdProducto, @Documento, @Nombre, @NCargo, @Salario, " +
                        "@Estado, @IdFactura, @AñoDetalle, @MesDetalle, @IdUsuario, @NombreUsuario);";
                SqlCommand commandDetalle = new SqlCommand(Registro, Connection);
                commandDetalle.Parameters.AddWithValue("@Codigo", detalle.Codigo);
                commandDetalle.Parameters.AddWithValue("@DiasTrabajados", detalle.DiasTrabajados);
                commandDetalle.Parameters.AddWithValue("@HorasExtras", detalle.HorasExtras);
                commandDetalle.Parameters.AddWithValue("@Salud", detalle.Salud);
                commandDetalle.Parameters.AddWithValue("@Pension", detalle.Pension);
                commandDetalle.Parameters.AddWithValue("@ValorHorasExtra", detalle.ValorHorasExtra);
                commandDetalle.Parameters.AddWithValue("@AuxTransporte", detalle.AuxTransporte);
                commandDetalle.Parameters.AddWithValue("@BonificacionServicios", detalle.BonificacionServicios);
                commandDetalle.Parameters.AddWithValue("@PrimaServicios", detalle.PrimaServicios);
                commandDetalle.Parameters.AddWithValue("@AuxAlimentacion", detalle.AuxAlimentacion);
                commandDetalle.Parameters.AddWithValue("@PrimaNavidad", detalle.PrimaNavidad);
                commandDetalle.Parameters.AddWithValue("@Devengado", detalle.Devengado);
                commandDetalle.Parameters.AddWithValue("@IdProducto", detalle.empleado.IdPersona);
                commandDetalle.Parameters.AddWithValue("@Documento", detalle.empleado.Documento);
                commandDetalle.Parameters.AddWithValue("@Nombre", detalle.empleado.Nombre);
                commandDetalle.Parameters.AddWithValue("@NCargo", detalle.empleado.Cargo.CargoDesempeñado);
                commandDetalle.Parameters.AddWithValue("@Salario", detalle.empleado.Contrato.Salario);
                commandDetalle.Parameters.AddWithValue("@Estado", detalle.empleado.Estado);
                commandDetalle.Parameters.AddWithValue("@IdFactura", detalle.liquidacion.IdFactura);
                commandDetalle.Parameters.AddWithValue("@AñoDetalle", detalle.liquidacion.Año);
                commandDetalle.Parameters.AddWithValue("@MesDetalle", detalle.liquidacion.Mes);
                commandDetalle.Parameters.AddWithValue("@IdUsuario", detalle.usuario.IdPersona);
                commandDetalle.Parameters.AddWithValue("@NombreUsuario", detalle.usuario.Nombre);

                AbrirConnection();
                var index = commandDetalle.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return $"Se ha registrado la liquidacion {detalle.Codigo}";
        }


        private DetalleLiquidacion Map(SqlDataReader reader)
        {
            DetalleLiquidacion detalle = new DetalleLiquidacion
            {
                IdDetalle = Convert.ToInt32(reader["IdDetalle"]),
                Codigo = Convert.ToString(reader["Codigo"]),
                DiasTrabajados = Convert.ToInt32(reader["DiasTrabajados"]),
                HorasExtras = Convert.ToInt32(reader["HorasExtras"]),
                Salud = Convert.ToDecimal(reader["Salud"]),
                Pension = Convert.ToDecimal(reader["Pension"]),
                ValorHorasExtra = Convert.ToDecimal(reader["ValorHorasExtra"]),
                AuxTransporte = Convert.ToDecimal(reader["AuxTransporte"]),
                BonificacionServicios = Convert.ToDecimal(reader["BonificacionServicios"]),
                PrimaServicios = Convert.ToDecimal(reader["PrimaServicios"]),
                AuxAlimentacion = Convert.ToDecimal(reader["AuxAlimentacion"]),
                PrimaNavidad = Convert.ToDecimal(reader["PrimaNavidad"]),
                Devengado = Convert.ToDecimal(reader["Devengado"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
                empleado = new Empleado
                {
                    IdPersona = Convert.ToInt32(reader["IdProducto"]),
                    Documento = Convert.ToString(reader["Documento"]),
                    Nombre = Convert.ToString(reader["Nombre"]),
                    Estado = Convert.ToString(reader["Estado"]),
                    Contrato = new Contrato
                    {
                        Salario = Convert.ToDecimal(reader["Salario"]),
                    },
                },
            };
            string Cargo = Convert.ToString(reader["NCargo"]);
            detalle.empleado.Cargo = cargoRepository.ObtenerCategoria(Cargo);

            int IdFactura = Convert.ToInt32(reader["IdFactura"]);
            int Año = Convert.ToInt32(reader["Año"]);
            int Mes = Convert.ToInt32(reader["Mes"]);
            int IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
            string NombreUsuario = Convert.ToString(reader["NombreUsuario"]);

            detalle.liquidacion = liquidacionRepository.ObtenerLiquidacion(IdFactura, Año, Mes);
            detalle.usuario = usuarioRepository.ObtenerUsuario(IdUsuario, NombreUsuario);

            return detalle;
        }

    }
}
