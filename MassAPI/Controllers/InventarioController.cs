
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
        public async Task<IActionResult> ReporteInventario()
        {
            //Inventario inventario = new Inventario
            //{
            //    Pk_articulo = parameters.Pk_articulo,
            //    Pk_marca = parameters.Pk_marca
            //};            

            InventarioLogica InvLogic = new InventarioLogica();
            var data = await InvLogic.ReporteInventario(new Inventario());


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
        [Route("api/Inventario/DdlArticulo")]
        public async Task<IActionResult> DdlArticulo()
        {



            InventarioLogica InvLogic = new InventarioLogica();
            var data = await InvLogic.DdlArticulo(new Inventario.ddlArticulo());





            return Ok(data);
        }


    }
}
