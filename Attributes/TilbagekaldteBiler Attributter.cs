using System;

namespace Værkstedsapp.Attributes
{
    public class TilbagekaldteBilerAttributter : Attribute
    {
        public string? mærke { get; set; }
        public string? model { get; set; }
        public string? årgang { get; set; }
        public string? fabriksfejl { get; set; }
    }
}
