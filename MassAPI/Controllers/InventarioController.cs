
using MassAPI.Authorization;
using MassAPI.Logica;
using MassAPI.Modelo;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
namespace MassAPI.Controllers
{
    
    
    public class InventarioController : Controller
    {
        
        
        [HttpGet]
        [Route("api/Inventario/Reporte")]
        public async Task<IActionResult> ReporteInventario(Inventario objInv)
        {  

            InventarioLogica InvLogic = new InventarioLogica();
            var data = await InvLogic.ReporteInventario(objInv);


            return Ok(data);
        }




        [HttpGet]
        [Route("api/Inventario/listarInventario")]
        public async Task<IActionResult> listarInventario(Inventario.listarInventario objInv)
        {
            InventarioLogica InvLogic = new InventarioLogica();
            var data = await InvLogic.listarInventario(objInv);
            return Ok(data);
        }

        [HttpGet]
        [Route("api/Inventario/detalleInventario")]
        public async Task<IActionResult> detalleInventario(Inventario.detalleInventario objInv)
        {
            InventarioLogica InvLogic = new InventarioLogica();
            var data = await InvLogic.detalleInventario(objInv);
            return Ok(data);
        }

        [HttpGet]
        [Route("api/Inventario/DdlMarca")]
        public async Task<IActionResult> DdlMarca()
        {



            InventarioLogica InvLogic = new InventarioLogica();
            var data = await InvLogic.DdlMarca(new Inventario.ddlMarca());





            return Ok(data);
        }




        [HttpGet]
        [Route("api/Inventario/DdlUsuarioxInv")]
        public async Task<IActionResult> DdlUsuarioxInv()
        {



            InventarioLogica InvLogic = new InventarioLogica();
            var data = await InvLogic.DdlUsuarioxInv(new Inventario.ddlUsuarioXinv());





            return Ok(data);
        }

        [HttpGet]
        [Route("api/Inventario/DdlArticulo")]
        public async Task<IActionResult> DdlArticulo()
        {



            InventarioLogica InvLogic = new InventarioLogica();
            var data = await InvLogic.DdlArticulo(new Inventario.ddlArticulo());





            return Ok(data);
        }


    }
}
