using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Hydac
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {

                Guest guest;
                Company company;
                Worker worker;
                Visit visit;
                List<Visit> visitList;      //Liste der senere indeholder visits

                if (File.Exists("HydacVisitList.json"))         // Hvis der er en fil allerede indlæser den filen
                {
                    string readInformation = File.ReadAllText("HydacVisitList.json");       //Laver filen og laver en string
                    visitList = JsonSerializer.Deserialize<List<Visit>>(readInformation);   //stringen bliver parset til en liste
                }
                else        // Ellers laver den en ny
                {
                    visitList = new List<Visit>();
                }

                Console.WriteLine("Velkommen");
                Console.WriteLine("\nTryk: 1 for at checke en gæst");
                Console.WriteLine("\nTryk: 2 for at lukke programmet");
                Console.WriteLine("\nTryk: 3 for at læse filen");
                int valg = int.Parse(Console.ReadLine());

                switch (valg)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Indtast navn på medarbejder: ");
                        string workername = Console.ReadLine();

                        Console.Write("Indtast navn på gæst: ");
                        string guestname = Console.ReadLine();

                        Console.Write("\nIndtast firma navn: ");
                        string companyname = Console.ReadLine();

                        Console.WriteLine("\nHvad tid checker du ud? TT:MM");
                        DateTime checkout = DateTime.Parse(Console.ReadLine());

                        worker = new Worker(workername);
                        company = new Company(companyname);
                        guest = new Guest(guestname, company);
                        //guest.visits[guest.numberOfVisit++] = visit;
                        visit = new Visit(guest,worker);
                        visit.CheckIn = DateTime.Now;
                        visit.CheckOut = checkout;

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

                        visitList.Add(visit);           // tilføjer visit til visit listen
                        string jsonstring = JsonSerializer.Serialize(visitList);        //Laver listen om til en jsonstring
                        File.WriteAllText("HydacVisitList.json", jsonstring);       //Skriver det i filen

                        Console.Clear();
                        Console.WriteLine($"{guest.GuestName} fra {company.CompanyName} er tjekket ind {visit.CheckIn.ToString()}");
                        Console.WriteLine($"Du har valgt at tjekket ud {visit.CheckOut.ToShortTimeString()}");

                        break;
                        
                    case 2:
                        Console.Clear();
                        running = false;
                        break;

                    case 3:
                        Console.Clear();
                        foreach(Visit v in visitList)           //for hver element i listen visitlist kaldes metoden Tostring som er blevet overridet i visit
                        {
                            Console.WriteLine(v.ToString());
                        }

                        break;
                }
            }
        }   
    }
}
