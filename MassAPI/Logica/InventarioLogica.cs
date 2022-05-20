using MassAPI.AccesoDatos;
using MassAPI.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassAPI.Logica
{
    public class InventarioLogica : GeneralLogica<Inventario>
    {
        public async Task<List<Inventario>> ReporteInventario(Inventario Item)
        {
            List< Inventario > oSection = null;
            using (SqlConnection cn = new SqlConnection(this.stringConexion))
            {
                await cn.OpenAsync();
                InventarioDatos oSectionDatos = new InventarioDatos();
                oSection = await oSectionDatos.ReporteInventario(cn, Item);
            }
            return oSection;
        }

        public async Task<List<Inventario.detalleInventario>> detalleInventario(Inventario.detalleInventario objDetalle)
        {
            List<Inventario.detalleInventario> oSection = null;
            using (SqlConnection cn = new SqlConnection(this.stringConexion))
            {         
                
                await cn.OpenAsync();
                InventarioDatos oSectionDatos = new InventarioDatos();
                oSection = await oSectionDatos.detalleInventario(cn, objDetalle);
            }
            return oSection;
        }

        public async Task<List<Inventario.listarInventario>> listarInventario(Inventario.listarInventario Item)
        {
            List<Inventario.listarInventario> oSection = null;
            using (SqlConnection cn = new SqlConnection(this.stringConexion))
            {
                await cn.OpenAsync();
                InventarioDatos oSectionDatos = new InventarioDatos();
                oSection = await oSectionDatos.listarInventario(cn, Item);
            }
            return oSection;
        }


        public async Task<List<Inventario.ddlMarca>> DdlMarca(Inventario.ddlMarca Item)
        {
            List<Inventario.ddlMarca> oSection = null;
            using (SqlConnection cn = new SqlConnection(this.stringConexion))
            {
                await cn.OpenAsync();
                InventarioDatos oSectionDatos = new InventarioDatos();
                oSection = await oSectionDatos.DdlMarca(cn, Item);
            }
            return oSection;
        }

        public async Task<List<Inventario.ddlUsuarioXinv>> DdlUsuarioxInv(Inventario.ddlUsuarioXinv Item)
        {
            List<Inventario.ddlUsuarioXinv> oSection = null;
            using (SqlConnection cn = new SqlConnection(this.stringConexion))
            {
                await cn.OpenAsync();
                InventarioDatos oSectionDatos = new InventarioDatos();
                oSection = await oSectionDatos.DdlUsuarioxInv(cn, Item);
            }
            return oSection;
        }

        public async Task<List<Inventario.ddlArticulo>> DdlArticulo(Inventario.ddlArticulo Item)
        {
            List<Inventario.ddlArticulo> oSection = null;
            using (SqlConnection cn = new SqlConnection(this.stringConexion))
            {
                await cn.OpenAsync();
                InventarioDatos oSectionDatos = new InventarioDatos();
                oSection = await oSectionDatos.DdlArticulo(cn, Item);
            }
            return oSection;
        }

    }
}
