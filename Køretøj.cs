using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VærkstedBilRegistreringApp;

namespace VærkstedBilRegistreringApp
{
    [Ulovligkøretøj(mærke: "toyota", model: "camry")]
    public class køretøj<T>
    {
        private const int _førsteGangSynk = 5;
        private const int _interValSyn = 2;

        public string? Mærke { get; set; }
        public string? Model { get; set; }
        public T Størrelse { get; set; }

        public køretøj(string? mærke, string? model, T størrelse)
        {
            mærke = Mærke;
            model = Model;
            størrelse = Størrelse;
        }

        [Ulovligkøretøj(mærke: "genesis", model: "gv80")]
        public string GetAllKøretøjinfo()
        {
            return $"mærke: {mærke}, model: {model}, størrelse: {størrelse}";
        }
    }
}
