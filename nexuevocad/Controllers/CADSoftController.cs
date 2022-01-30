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
            CADDrawing tempo = new CADDrawing();
            if (param.url == "test")
            {
              
                tempo.url = param.url;
                tempo.Image_bottom = "https://drive.google.com/file/d/1ejiQg0RT88MoqSb3E7nSUyIWOpK_Taj1/view?usp=sharing";
                tempo.Image_left = "https://drive.google.com/file/d/1ejiQg0RT88MoqSb3E7nSUyIWOpK_Taj1/view?usp=sharing";
                tempo.Image_right = "https://drive.google.com/file/d/1ci86AHOpbFskJPdwQ4Eow-4mof-uxBro/view?usp=sharing";
                tempo.Image_rear = "https://drive.google.com/file/d/1IW02uLKu7OIAG2k4w_RpRHm_6iVNCwtG/view?usp=sharing";
                tempo.Image_front = "https://drive.google.com/file/d/1hASOiPcPg00A7jK5Tyj4PHmyNEh3JS9T/view?usp=sharing";
                tempo.Image_ISObottom = "https://drive.google.com/file/d/1wLkWO1qO3P8FTlzBku0UlnBAZFh7-mQl/view?usp=sharing";
                tempo.Image_ISOtop = "https://drive.google.com/file/d/1V8LhaSwxwHFDptaHV7kNIq0gY4lsnsiP/view?usp=sharing";

                tempo.X = 47.542;
                tempo.Y = 371.360;
                tempo.Z = 371.360;
                tempo.Volume = 394993.9;
                tempo.Surfacearea = 297532.5;

                tempo.Image_CrossSection_1 = "https://drive.google.com/file/d/1V_U6tq6JmpRuQtbozdtQl_miivqgp6Ab/view?usp=sharing";
                tempo.Image_CrossSection_2 = "https://drive.google.com/file/d/1im2iUSv661ZYUES90e-0zEaGFd48feBD/view?usp=sharing";
                tempo.Image_CrossSection_3 = "https://drive.google.com/file/d/1Gza_MZVj5cjarkaL91IBkAYGj42mWTRa/view?usp=sharing";


            }

            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status200OK, tempo);
        }
    }
}
