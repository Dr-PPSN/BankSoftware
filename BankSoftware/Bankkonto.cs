using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankSoftware
{
    internal class Bankkonto
    {
        public string Kontonummer { get; set; }
        private string Kontoinhaber { get; set; }
        private double Kontostand { get; set; }
        private double Dispo { get; set; }
        private double Zinssatz { get; set; }
        public bool IstAktiv { get; set; } = true;
        private int KontoType { get; set; }

        public Bankkonto(string kontonummer, string kontoinhaber, double kontostand, double dispo, double zinssatz, int kontoType)
        {
            Kontonummer = kontonummer;
            Kontoinhaber = kontoinhaber;
            Kontostand = kontostand;
            Dispo = dispo;
            Zinssatz = zinssatz;
            KontoType = kontoType;
        }
        public void kontoauszug() {
            Console.WriteLine("Kontonummer: " + Kontonummer);
            Console.WriteLine("Kontoinhaber: " + Kontoinhaber);
            Console.WriteLine("Kontostand: " + Kontostand);
            Console.WriteLine("Dispo: " + Dispo);
            Console.WriteLine("Zinssatz: " + Zinssatz);
        }
        public void einzahlen(double betrag) {
            Kontostand += betrag;
            Console.WriteLine("Neuer Kontostand: " + Kontostand);
        }
        public void auszahlen(double betrag) {
            if(KontoType == 0 && (Kontostand - betrag < 0 - Dispo)){
                Console.WriteLine("Kontostand zu niedrig!");
                return;
            }
            Kontostand -= betrag;
            Console.WriteLine("Neuer Kontostand: " + Kontostand);
        }
    }
}
