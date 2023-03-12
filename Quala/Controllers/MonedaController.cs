using Domain.Contract;
using Microsoft.AspNetCore.Mvc;
using Quala.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quala.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedaController : ControllerBase
    {
        private IMonedaDomain oIMonedaDomain;
        public MonedaController(IMonedaDomain _oIMonedaDomain)
        {
            oIMonedaDomain = _oIMonedaDomain;
        }

        [HttpGet("GetAll")]
        public async Task<Response> GetAll()
        {
            Response oResponse = new Response();
            try
            {
                oResponse.exito = true;
                oResponse.mensaje = "envio correcto!";
                oResponse.data = await oIMonedaDomain.GetAll();

            }
            catch (Exception ex)
            {
                oResponse.exito = false;
                oResponse.mensaje = ex.Message;
            }
            return oResponse;
        }
    }
}
