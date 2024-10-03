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

            switch (valg) 
            {
                case 1:
                    Console.Clear();
                    Console.Write("Indtast navn: ");
                    guest.GuestName = Console.ReadLine();

                    Console.Write("\nIndtast firma navn: ");
                    company.CompanyName = Console.ReadLine();
                    
                    break;
            }

        }
    }
}
