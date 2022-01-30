using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nexuevocad.Models
{
    public class CADDrawing
    {
        public string url { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }
        public decimal Volume { get; set; }
        public decimal Surfacearea { get; set; }

        public string Image_top { get; set; }
        public string Image_bottom { get; set; }
        public string Image_left { get; set; }
        public string Image_right { get; set; }
        public string Image_rear { get; set; }
        public string Image_front { get; set; }
        public string Image_ISOtop { get; set; }
        public string Image_ISObottom { get; set; }
        public string Image_CrossSection_1 { get; set; }
        public string Image_CrossSection_2 { get; set; }
        public string Image_CrossSection_3 { get; set; }
    }
}
