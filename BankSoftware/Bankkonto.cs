using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSoftware
{
    internal class Bankkonto
    {
        protected string Kontonummer { get; set; }
        protected string Kontoinhaber { get; set; }
        protected double Kontostand { get; set; }
        protected double Dispo { get; set; }
        protected double Zinssatz { get; set; }

        public Bankkonto(string kontonummer, string kontoinhaber, double kontostand, double dispo, double zinssatz)
        {
            Kontonummer = kontonummer;
            Kontoinhaber = kontoinhaber;
            Kontostand = kontostand;
            Dispo = dispo;
            Zinssatz = zinssatz;
        }
        public void kontoauszug() { }
        public void einzahlen() { }
        public void auszahlen() { }
    }
}
