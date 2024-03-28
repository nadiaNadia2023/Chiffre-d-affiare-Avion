using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class AirplaneTicketing
    {
        private const int TotalSeats = 200;
        private const int TotalRows = 34;
        private const int SeatsPerRow = 6;
        private const int LastRowSeats = 2;

        private List<Passenger> passengers;
        private List<Family> families;

        public AirplaneTicketing()
        {
            passengers = new List<Passenger>();
            families = new List<Family>();
        }

        public void GeneratePassengersAndFamilies()
        {
            // Générer une liste de passagers et de familles en respectant les contraintes

            // Ajouter les passagers à la liste
            passengers.Add(new Passenger("Adult1", 35));
            passengers.Add(new Passenger("Adult2", 40));
            passengers.Add(new Passenger("Child1", 8, isChild: true));
            passengers.Add(new Passenger("Child2", 10, isChild: true));
            passengers.Add(new Passenger("Child3", 6, isChild: true));
            passengers.Add(new Passenger("Adult3", 30));
            passengers.Add(new Passenger("Adult4", 50, requiresExtraSeat: true));
            passengers.Add(new Passenger("Child4", 9, isChild: true));
            passengers.Add(new Passenger("Child5", 7, isChild: true));
            passengers.Add(new Passenger("Adult5", 45));

            // Créer et ajouter des familles à la liste
            Family family1 = new Family();
            family1.AddMember(passengers[2]); // Child1
            family1.AddMember(passengers[3]); // Child2
            family1.AddMember(passengers[4]); // Child3
            families.Add(family1);

            Family family2 = new Family();
            family2.AddMember(passengers[7]); // Child4
            family2.AddMember(passengers[8]); // Child5
            families.Add(family2);

            // Ajouter les adultes restants à la liste des passagers
            passengers.RemoveAll(p => p.IsChild);
        }

        public int OptimizeRevenue()
        {
            // Répartir les passagers et les familles dans l'avion pour maximiser le chiffre d'affaires

            // Trier les passagers en fonction de leur nécessité de place supplémentaire
            var sortedPassengers = passengers.OrderByDescending(p => p.RequiresExtraSeat).ToList();

            int totalRevenue = 0;
            foreach (var passenger in sortedPassengers)
            {
                if (FindOptimalSeat(passenger))
                {
                    totalRevenue += CalculateTicketPrice(passenger);
                }
            }

            // Ajouter le chiffre d'affaires des familles
            foreach (var family in families)
            {
                totalRevenue += family.CalculateTotalPrice();
            }

            Console.WriteLine($"Total revenue: {totalRevenue} €");
            return totalRevenue;
        }


        private bool FindOptimalSeat(Passenger passenger)
        {
            return true; // A faire
        }
        private int CalculateTicketPrice(Passenger passenger)
        {
            // Calculer le prix du billet pour un passager
            if (passenger.IsAdult && passenger.RequiresExtraSeat)
            {
                return 500; // Prix de deux places pour un adulte nécessitant deux places
            }
            else if (passenger.IsAdult)
            {
                return 250; // Prix d'un billet adulte
            }
            else
            {
                return 150; // Prix d'un billet enfant
            }
        }
    }
}