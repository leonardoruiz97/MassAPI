using MassAPI.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace MassAPI.AccesoDatos
{
    public class InventarioDatos
    {
        public async Task<List<Inventario>> ReporteInventario(SqlConnection Cn, Inventario objInventario)
        {
            List<Inventario> listaInv = new List<Inventario>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "ReporteInventario",
                CommandType = CommandType.StoredProcedure,
                Connection = Cn
            };

            cmd.Parameters.AddWithValue("@Pkarticulo", objInventario.Pk_articulo);
            cmd.Parameters.AddWithValue("@Pkmarca", objInventario.Pk_marca);


            using (SqlDataReader dtr = await cmd.ExecuteReaderAsync(CommandBehavior.SingleResult))
            {
                if (dtr != null)
                {
                    listaInv = new List<Inventario>();
                    while (await dtr.ReadAsync())
                    {
                        listaInv.Add(new Inventario
                        {
                            codigo = !dtr.IsDBNull(dtr.GetOrdinal("codigo")) ? dtr.GetString(dtr.GetOrdinal("codigo")) : "",
                            nombre = !dtr.IsDBNull(dtr.GetOrdinal("nombre")) ? dtr.GetString(dtr.GetOrdinal("nombre")) : "",
                            descripcion = !dtr.IsDBNull(dtr.GetOrdinal("descripcion")) ? dtr.GetString(dtr.GetOrdinal("descripcion")) : "",
                            Pventa = !dtr.IsDBNull(dtr.GetOrdinal("Pventa")) ? dtr.GetDecimal(dtr.GetOrdinal("Pventa")) : 0,
                            fechaV = !dtr.IsDBNull(dtr.GetOrdinal("fechaV")) ? dtr.GetDateTime(dtr.GetOrdinal("fechaV")).ToShortDateString() : "",
                            Marca = !dtr.IsDBNull(dtr.GetOrdinal("Marca")) ? dtr.GetString(dtr.GetOrdinal("Marca")) : "",
                            Categoria = !dtr.IsDBNull(dtr.GetOrdinal("Categoria")) ? dtr.GetString(dtr.GetOrdinal("Categoria")) : "",
                            Eproducto = !dtr.IsDBNull(dtr.GetOrdinal("Eproducto")) ? dtr.GetString(dtr.GetOrdinal("Eproducto")) : "",
                            cant = !dtr.IsDBNull(dtr.GetOrdinal("cant")) ? dtr.GetInt32(dtr.GetOrdinal("cant")) : 0
                        });
                    }
                }
            }
            return listaInv;
        }

        public async Task<List<Inventario.listarInventario>> listarInventario(SqlConnection Cn, Inventario.listarInventario objInventario)
        {
            List<Inventario.listarInventario> listaInv = new List<Inventario.listarInventario>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "listarInventario",
                CommandType = CommandType.StoredProcedure,
                Connection = Cn
            };

            cmd.Parameters.AddWithValue("@Pkarticulo", objInventario.Pkarticulo);
            cmd.Parameters.AddWithValue("@PkUsuario", objInventario.PkUsuario);


            using (SqlDataReader dtr = await cmd.ExecuteReaderAsync(CommandBehavior.SingleResult))
            {
                if (dtr != null)
                {
                    listaInv = new List<Inventario.listarInventario>();
                    while (await dtr.ReadAsync())
                    {
                        listaInv.Add(new Inventario.listarInventario
                        {
                            Inventario = !dtr.IsDBNull(dtr.GetOrdinal("Inventario")) ? dtr.GetString(dtr.GetOrdinal("Inventario")) : "",
                            producto = !dtr.IsDBNull(dtr.GetOrdinal("producto")) ? dtr.GetString(dtr.GetOrdinal("producto")) : "",
                            usuario = !dtr.IsDBNull(dtr.GetOrdinal("usuario")) ? dtr.GetString(dtr.GetOrdinal("usuario")) : "",
                            fecha = !dtr.IsDBNull(dtr.GetOrdinal("fecha")) ? dtr.GetDateTime(dtr.GetOrdinal("fecha")).ToShortDateString() : "",
                            descripcion = !dtr.IsDBNull(dtr.GetOrdinal("descripcion")) ? dtr.GetString(dtr.GetOrdinal("descripcion")) : ""
                        });
                    }
                }
            }
            return listaInv;
        }

        public async Task<List<Inventario.detalleInventario>> detalleInventario(SqlConnection Cn, Inventario.detalleInventario objInventario)
        {
            List<Inventario.detalleInventario> listaDetalleInv = new List<Inventario.detalleInventario>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "detalleInventario",
                CommandType = CommandType.StoredProcedure,
                Connection = Cn
            };

            cmd.Parameters.AddWithValue("@pkarthasinv", objInventario.Pkarthasinv);           


            using (SqlDataReader dtr = await cmd.ExecuteReaderAsync(CommandBehavior.SingleResult))
            {
                if (dtr != null)
                {
                    listaDetalleInv = new List<Inventario.detalleInventario>();
                    while (await dtr.ReadAsync())
                    {
                        listaDetalleInv.Add(new Inventario.detalleInventario
                        {
                            SKU = !dtr.IsDBNull(dtr.GetOrdinal("Inventario")) ? dtr.GetString(dtr.GetOrdinal("Inventario")) : "",
                            producto = !dtr.IsDBNull(dtr.GetOrdinal("producto")) ? dtr.GetString(dtr.GetOrdinal("producto")) : "",
                            marca = !dtr.IsDBNull(dtr.GetOrdinal("marca")) ? dtr.GetString(dtr.GetOrdinal("marca")) : "",
                            Pcompra = !dtr.IsDBNull(dtr.GetOrdinal("Pcompra")) ? dtr.GetDecimal(dtr.GetOrdinal("Pcompra")) : 0,
                            Pventa = !dtr.IsDBNull(dtr.GetOrdinal("Pventa")) ? dtr.GetDecimal(dtr.GetOrdinal("Pventa")) : 0,
                            descripcion = !dtr.IsDBNull(dtr.GetOrdinal("descripcion")) ? dtr.GetString(dtr.GetOrdinal("descripcion")) : "",
                            cant = !dtr.IsDBNull(dtr.GetOrdinal("cant")) ? dtr.GetInt32(dtr.GetOrdinal("cant")) : 0
                        });
                    }
                }
            }
            return listaDetalleInv;
        }

        public async Task<List<Inventario.ddlUsuarioXinv>> DdlUsuarioxInv(SqlConnection Cn, Inventario.ddlUsuarioXinv objInventario)
        {
            List<Inventario.ddlUsuarioXinv> ddlUsXIn = new List<Inventario.ddlUsuarioXinv>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "DdlUsuarioxInv",
                CommandType = CommandType.StoredProcedure,
                Connection = Cn
            };


            using (SqlDataReader dtr = await cmd.ExecuteReaderAsync(CommandBehavior.SingleResult))
            {
                if (dtr != null)
                {
                    ddlUsXIn = new List<Inventario.ddlUsuarioXinv>();
                    while (await dtr.ReadAsync())
                    {
                        ddlUsXIn.Add(new Inventario.ddlUsuarioXinv
                        {
                            idusuario = !dtr.IsDBNull(dtr.GetOrdinal("idusuario")) ? dtr.GetInt32(dtr.GetOrdinal("idusuario")) : 0,
                            usuario = !dtr.IsDBNull(dtr.GetOrdinal("usuario")) ? dtr.GetString(dtr.GetOrdinal("usuario")) : "",


                        });
                    }
                }
            }
            return ddlUsXIn;
        }


        public async Task<List<Inventario.ddlMarca>> DdlMarca(SqlConnection Cn, Inventario.ddlMarca objInventario)
        {
            List<Inventario.ddlMarca> listaInv = new List<Inventario.ddlMarca>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "ddlMarca",
                CommandType = CommandType.StoredProcedure,
                Connection = Cn
            };            


            using (SqlDataReader dtr = await cmd.ExecuteReaderAsync(CommandBehavior.SingleResult))
            {
                if (dtr != null)
                {
                    listaInv = new List<Inventario.ddlMarca>();
                    while (await dtr.ReadAsync())
                    {
                        listaInv.Add(new Inventario.ddlMarca
                        {
                            idMarca = !dtr.IsDBNull(dtr.GetOrdinal("idMarca")) ? dtr.GetInt32(dtr.GetOrdinal("idMarca")) : 0,
                            nombre = !dtr.IsDBNull(dtr.GetOrdinal("nombre")) ? dtr.GetString(dtr.GetOrdinal("nombre")) : "",


                        });
                    }
                }
            }
            return listaInv;
        }

        public async Task<List<Inventario.ddlArticulo>> DdlArticulo(SqlConnection Cn, Inventario.ddlArticulo objInventario)
        {
            List<Inventario.ddlArticulo> listaInv = new List<Inventario.ddlArticulo>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "ddlArticulo",
                CommandType = CommandType.StoredProcedure,
                Connection = Cn
            };

            


            using (SqlDataReader dtr = await cmd.ExecuteReaderAsync(CommandBehavior.SingleResult))
            {
                if (dtr != null)
                {
                    listaInv = new List<Inventario.ddlArticulo>();
                    while (await dtr.ReadAsync())
                    {
                        listaInv.Add(new Inventario.ddlArticulo
                        {
                            idarticulo = !dtr.IsDBNull(dtr.GetOrdinal("idarticulo")) ? dtr.GetInt32(dtr.GetOrdinal("idarticulo")) : 0,
                            nombre = !dtr.IsDBNull(dtr.GetOrdinal("nombre")) ? dtr.GetString(dtr.GetOrdinal("nombre")) : "",

                        });
                    }
                }
            }
            return listaInv;
        }

    }
}
