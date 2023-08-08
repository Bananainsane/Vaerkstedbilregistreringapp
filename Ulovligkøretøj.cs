using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VærkstedBilRegistreringApp
{
    public class ulovligkøretøj : Attribute
    {
        public string? mærke { get; set; }
        public string? model { get; set; }
    
    }
}
    