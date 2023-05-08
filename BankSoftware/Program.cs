namespace BankSoftware
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bankkonto> bankKontos = new List<Bankkonto>();

            menu();

            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    neuesKonto(bankKontos);
                    break;
                case "2":
                    kontoauszug();
                    break;
                case "3":
                    einzahlen();
                    break;
                case "4":
                    auszahlen();
                    break;
                case "5":
                    kontoLoeschen();
                    break;
                case "0":
                    Environment.Exit(1);
                    break;
            }
        }
        static void menu()
        {
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("------------\n");
            Console.WriteLine("1. Neues Konto anlegen");
            Console.WriteLine("2. Kontoauszug");
            Console.WriteLine("3. Einzahlen");
            Console.WriteLine("4. Auszahlen");
            Console.WriteLine("5. Konto löschen");
            Console.WriteLine("0. Beenden\n");
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
            
            Bankkonto bankkonto = new Bankkonto(getKontonummer(kontoType), kontoInhaber, kontostand, dispo, zinssatz);
            bankKontos.Add(bankkonto);
        }
        static void kontoauszug()
        {
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("------------\n");
        }
        static void einzahlen()
        {
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("------------\n");
        }
        static void auszahlen()
        {
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("------------\n");
        }
        static void kontoLoeschen()
        {
            Console.Clear();
            Console.WriteLine("BankSoftware");
            Console.WriteLine("------------\n");
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