using System.Security.Cryptography.X509Certificates;
global using VærkstedBilRegistreringApp;
using TilbageKaldteBiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VærkstedBilRegistreringApp
{
    internal class Person
    {
        public TilbageKaldteBiler TilbageKaldteBiler { get; set; }
        public int age { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        private bool _showname { get; set; }

        public Person()
        {
            _showname = false;
        }

        public Person(string? firstname, string? lastname)
        {
            _showname = true;
            this.firstname = firstname;
            this.lastname = lastname;
            køretøj<Double> MinBil = new("audi", "a6", 134);
            køretøj<Double> MinCykel = new("VW", "Golf", "150");
        }

        public string SayHello()
        {
            if (_showname)
                return $"Hello {firstname} {lastname}!";
            else
                return "no name given";
        }

        Public string TjekForTilbageKaldteBiler(TilbageKaldteBiler TilbageKaldteBiler )
        {
            return "";
        }
    }
}
