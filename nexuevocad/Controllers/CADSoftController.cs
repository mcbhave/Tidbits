using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tidbits.Authentication;
using yardillocore.Models;
using Tidbits.Sevices;
using nexuevocad.Models;
using Microsoft.AspNetCore.Http;

namespace nexuevocad.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    [BasicAuthFilter()]
    public class CADSoftController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpPost(Name = "postCAD")]
        public IActionResult Post(CADDrawing param)
        {
            //Message oms;
            var usrid = HttpContext.Session.GetString("mbaduserid");
            var tenantid = HttpContext.Session.GetString("mbadtanent");

            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status200OK, param);
        }
    }
}
