using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Hydac
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen");
            Console.WriteLine("\nTryk: 1 for at registrere en gæst");
            int valg =int.Parse(Console.ReadLine());

            Guest guest;
            Company company;
            Worker worker;
            Visit visit;

            Guest[] guestList = new Guest[10];
            int numberofGuestList = 0;

            switch (valg) 
            {
                case 1:
                    Console.Clear();
                    Console.Write("Indtast navn: ");
                    string guestname = Console.ReadLine();                

                    Console.Write("\nIndtast firma navn: ");
                    string companyname = Console.ReadLine();
                    
                    Console.WriteLine("\nHvad tid checker du ud? TT:MM");
                    DateTime checkout = DateTime.Parse(Console.ReadLine());
                    

                    visit = new Visit();
                    visit.CheckIn = DateTime.Now;
                    visit.CheckOut = checkout;
                    company = new Company(companyname);
                    guest = new Guest(guestname, company);
                    guest.visits[guest.numberOfVisit++] = visit;
                    
                    while (visit.DeliveredFolder == false)
                    {
                        Console.WriteLine("Har du modtaget et sikkerhedsfolder? \nTryk Y/N");
                        string sikkerhedsFolderSvar = Console.ReadLine();
                        if (sikkerhedsFolderSvar == "y")
                        {
                            visit.DeliveredFolder = true;
                        }
                        else
                        {
                            visit.DeliveredFolder = false;
                        }
                    }

                    Console.Clear();
                    Console.WriteLine($"{guest.GuestName} fra {company.CompanyName} er tjekket ind {visit.CheckIn.ToString()}");
                    Console.WriteLine($"Du har valgt at tjekket ud {visit.CheckOut.ToShortTimeString()}");

                    break;
            }

        }
    }
}
