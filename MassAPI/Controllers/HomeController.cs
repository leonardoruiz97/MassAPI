using MassAPI.Logica;
using MassAPI.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace MassAPI.Controllers
{
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("api/Inve")]
        public async Task<IActionResult> GetMethods()
        {


            //List<object> list = new List<object>();

            //list.Add(new
            //{
            //    id = 5,
            //    name = "KashIO"
            //});

            //list.Add(new
            //{
            //    id = 7,
            //    name = "PagoEfectivo"
            //});





            return Ok();
        }
    }
}
