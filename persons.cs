global using VærkstedBilRegistreringApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VærkstedBilRegistreringApp
{
    internal class Person
    {
        public køretøj? MinBil { get; set; }
        public int age { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        private bool _showname { get; set; }

        public Person()
        {
            _showname = false;
        }

        public Person(string firstname, string lastname)
        {
            _showname = true;
            this.firstname = firstname;
            this.lastname = lastname;
            MinBil = new();
            MinBil.mærke = "VW";
        }

        public string SayHello()
        {
            if (_showname)
                return $"Hello {firstname} {lastname}!";
            else
                return "no name given";
        }
    }
}