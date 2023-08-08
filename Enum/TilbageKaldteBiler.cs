using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VærkstedBilRegistreringApp.Attributes; // Add missing using statement for VærkstedBilRegistreringApp.Attributes

namespace VærkstedBilRegistreringApp.Enum
{
    internal enum TilbageKaldteBilerEnum
    {
        [TilbagekaldteBilerAttributter(Mærke = "Fiat", Model = "Punto", Årgang = "20.20.2020", Fabriksfejl = "udstødning")]
        FiatPunto, 
        [TilbagekaldteBilerAttributter(Mærke = "Alfa", Model = "Romeo", Årgang = "30.1.2021", Fabriksfejl = "styretøj")]
        AlfaRomeo
    }
}
