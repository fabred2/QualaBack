using Microsoft.AspNetCore.Mvc;
using Quala.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Contract;
using Entities;

namespace Quala.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalController : ControllerBase
    {

        private ISucursalDomain oISucursalDomain;
        public SucursalController(ISucursalDomain _oISucursalDomain)
        {
            oISucursalDomain = _oISucursalDomain;
        }

        [HttpGet("GetAll")]
        public async Task<Response> GetAll()
        {
            Response oResponse = new Response();
            try
            {
                oResponse.exito = true;
                oResponse.mensaje = "envio correcto!";
                oResponse.data = await oISucursalDomain.GetAll();

            }
            catch (Exception ex)
            {
                oResponse.exito = false;
                oResponse.mensaje = ex.Message;
            }
            return oResponse;
        }


        [HttpPost("Insert")]
        public async Task<Response> Insert(Sucursales oSucursales)
        {
            Response oResponse = new Response();
            try
            {
                oResponse.exito = true;
                oResponse.mensaje = "envio correcto!";
                oResponse.data = await oISucursalDomain.Insert(oSucursales);

            }
            catch (Exception ex)
            {
                oResponse.exito = false;
                oResponse.mensaje = ex.Message;
            }
            return oResponse;
        }

        [HttpPut("Update")]
        public async Task<Response> Update(Sucursales oSucursales)
        {
            Response oResponse = new Response();
            try
            {
             
                oResponse.exito = true;
                oResponse.mensaje = "envio correcto!";
                oResponse.data = await oISucursalDomain.Update(oSucursales);

            }
            catch (Exception ex)
            {
                oResponse.exito = false;
                oResponse.mensaje = ex.Message;
            }
            return oResponse;
        }


        [HttpDelete("{id}")]
        // [HttpDelete("Delete")]
        public async Task<Response> Delete(int id)
        {
            Sucursales oSucu = new Sucursales();
            Response oResponse = new Response();
            try
            {
                var salida = oISucursalDomain.GetById(id);
                if (salida == null) {
                    throw new System.Exception("no existe el registro");
                }
                oResponse.exito = true;
                oResponse.mensaje = "envio correcto!";
                oResponse.data = await oISucursalDomain.Delete(salida.Result);

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
