namespace Hydac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen");
            Console.WriteLine("\nTryk: 1 for at registrere en gæst");
            int valg =int.Parse(Console.ReadLine());

            Guest guest = new Guest("");
            Company company = new Company("");
            Worker worker = new Worker("");
            Visit visit = new Visit();

            switch (valg) 
            {
                case 1:
                    Console.Clear();
                    Console.Write("Indtast navn: ");
                    guest.GuestName = Console.ReadLine();

                    Console.Write("\nIndtast firma navn: ");
                    company.CompanyName = Console.ReadLine();
                    
                    Console.WriteLine("\nHvad tid checker du ud?");
                    //visit.CheckOut = Parse.Console.ReadLine();
                    //visit.CheckOut = Console.ReadLine();
                    //Console.WriteLine(visit.CheckOut);

                    Console.Clear();
                    Console.WriteLine($"{guest.GuestName} fra {company.CompanyName} er tjekket ind {visit.CheckIn.ToString()}");

                    break;
            }

        }
    }
}
