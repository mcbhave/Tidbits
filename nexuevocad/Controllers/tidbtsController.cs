using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tidbits.Authentication;
using yardillocore.Models;
using Tidbits.Sevices;
namespace Tidbits.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    [BasicAuthFilter()]
    public class tidbtsController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpGet(Name = "Gettidbt")]
        public IActionResult Get()
        {
            //Message oms;
            var usrid = HttpContext.Session.GetString("mbaduserid");
            var tenantid = HttpContext.Session.GetString("mbadtanent");
            try
            {


                //Case ocase = _tidbitservice.Gettidbit();

                //if (ocase == null)
                //{
                //    oms = _tidbitservice.SetMessage(ICallerType.CASE, "", "", "GET", "404", "Case Search", usrid, null);
                //    ocase = new Case();
                //    ocase.Message = new MessageResponse() { Messagecode = oms.Messagecode, Messageype = oms.Messageype, _id = oms._id };

                //    return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status404NotFound, ocase);
                //}
                //else
                //{
                //    oms = _tidbitservice.SetMessage(ICallerType.CASE, "", "", "GET", "200", "Case Search", usrid, null);
                //    ocase.Message = new MessageResponse() { Messagecode = oms.Messagecode, Messageype = oms.Messageype, _id = oms._id };
                //    return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status200OK, ocase);
                //}
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status200OK, "");
            }
            catch
            {
                Case ocase = new Case();

                //oms = _tidbitservice.SetMessage(ICallerType.CASE, "", "", "GET", "", "", usrid, ex);

                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status417ExpectationFailed, "");
            }
        }
    }
}
