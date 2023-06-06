namespace BankSoftware
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Bankkonto> bankKontos = new List<Bankkonto>();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            
            menu(bankKontos);
        }
        static void menu(List<Bankkonto> bankKontos)
        {
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("------------\n");
            Console.WriteLine("1. Neues Konto anlegen");
            Console.WriteLine("2. Kontoauszug");
            Console.WriteLine("3. Einzahlen");
            Console.WriteLine("4. Auszahlen");
            Console.WriteLine("5. Konto löschen");
            Console.WriteLine("6. Konto wiederherstellen");
            Console.WriteLine("0. Beenden\n");

            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    neuesKonto(bankKontos);
                    break;
                case "2":
                    kontoauszug(bankKontos);
                    break;
                case "3":
                    einzahlen(bankKontos);
                    break;
                case "4":
                    auszahlen(bankKontos);
                    break;
                case "5":
                    kontoLoeschen(bankKontos);
                    break;
                case "6":
                    kontoWiederherstellen(bankKontos);
                    break;
                case "0":
                    Environment.Exit(1);
                    break;
            }
            menu(bankKontos);
        }
        static void neuesKonto(List<Bankkonto> bankKontos)
        {
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("Neues Konto erstellen");
            Console.WriteLine("------------\n");

            Console.WriteLine("Sparkonto (0) oder Kontokorrentkonto (1)?: ");
            int kontoType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kontoinhaber: ");
            string kontoInhaber = Console.ReadLine();
            Console.WriteLine("Kontostand: ");
            double kontostand = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dispo: ");
            double dispo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zinssatz: ");
            double zinssatz = Convert.ToDouble(Console.ReadLine());
            
            Bankkonto bankkonto = new Bankkonto(getKontonummer(kontoType), kontoInhaber, kontostand, dispo, zinssatz, kontoType);
            bankKontos.Add(bankkonto);
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("Neues Konto erstellen");
            Console.WriteLine("------------\n");
            Console.WriteLine("Neues Konto erstellt!");
            Console.WriteLine("Kontonummer: " + bankkonto.Kontonummer);
            Console.ReadLine();
        }
        static void kontoauszug(List<Bankkonto> bankKontos)
        {
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("Kontoauszug");
            Console.WriteLine("------------\n");

            Console.WriteLine("Bitte Kontonummer eingeben oder 'all' für alle: ");
            string kontonummer = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("Kontoauszug");
            Console.WriteLine("------------\n");
            foreach (Bankkonto bankkonto in bankKontos)
            {
                if (bankkonto.Kontonummer == kontonummer && bankkonto.IstAktiv == true)
                {
                    bankkonto.kontoauszug();
                    Console.ReadLine();
                    return;
                }
                else if (kontonummer == "all" && bankkonto.IstAktiv == true)
                {
                    bankkonto.kontoauszug();
                    Console.WriteLine("--------------------\n");
                }
            }
            Console.ReadLine();
        }
        static void einzahlen(List<Bankkonto> bankKontos)
        {
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("Einzahlen");
            Console.WriteLine("------------\n");

            Console.WriteLine("Bitte Kontonummer eingeben: ");
            string kontonummer = Console.ReadLine();
            Console.WriteLine("Bitte Betrag eingeben: ");
            double betrag = Convert.ToDouble(Console.ReadLine());
            foreach (Bankkonto bankkonto in bankKontos)
            {
                if (bankkonto.Kontonummer == kontonummer && bankkonto.IstAktiv == true)
                {
                    bankkonto.einzahlen(betrag);
                    Console.ReadLine();
                    return;
                }
                
            }
            Console.WriteLine("Konto nicht gefunden!");
            Console.ReadLine();
        }
        static void auszahlen(List<Bankkonto> bankKontos)
        {
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("Auszahlen");
            Console.WriteLine("------------\n");

            Console.WriteLine("Bitte Kontonummer eingeben: ");
            string kontonummer = Console.ReadLine();
            Console.WriteLine("Bitte Betrag eingeben: ");
            double betrag = Convert.ToDouble(Console.ReadLine());
            foreach (Bankkonto bankkonto in bankKontos)
            {
                if (bankkonto.Kontonummer == kontonummer && bankkonto.IstAktiv == true)
                {
                    bankkonto.auszahlen(betrag);
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Konto nicht gefunden!");
                Console.ReadLine();
        }
        static void kontoLoeschen(List<Bankkonto> bankKontos)
        {
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("Konto löschen");
            Console.WriteLine("------------\n");

            Console.WriteLine("Bitte Kontonummer eingeben: ");
            string kontonummer = Console.ReadLine();
            foreach (Bankkonto bankkonto in bankKontos)
            {
                if (bankkonto.Kontonummer == kontonummer && bankkonto.IstAktiv == true)
                {
                    bankkonto.IstAktiv = false;
                    Console.WriteLine("Konto wurde gelöscht!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Konto nicht gefunden!");
            Console.ReadLine();
        }
        static void kontoWiederherstellen(List<Bankkonto> bankkontos)
        {
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("Konto wiederherstellen");
            Console.WriteLine("------------\n");

            Console.WriteLine("Bitte Kontonummer eingeben: ");
            string kontonummer = Console.ReadLine();
            foreach (Bankkonto bankkonto in bankkontos)
            {
                if (bankkonto.Kontonummer == kontonummer && bankkonto.IstAktiv == false)
                {
                    bankkonto.IstAktiv = true;
                    Console.WriteLine("Konto wiederhergestellt");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Konto konnte nicht wiederhergestellt werden");
            Console.ReadLine();
        }
        static string getKontonummer(int type)
        {
            Guid guid = Guid.NewGuid();
            if (type == 0)
            {
                return "00" + guid.ToString();
            }
            else if(type == 1)
            {
                return "11" + guid.ToString();
            }
            return "Fehler, Konto ungültig";
        }
    }
}