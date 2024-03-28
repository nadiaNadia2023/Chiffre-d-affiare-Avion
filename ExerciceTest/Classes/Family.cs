using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Family
    {
        public List<Passenger> Members { get; private set; }

        public Family()
        {
            Members = new List<Passenger>();
        }

        public void AddMember(Passenger passenger)
        {
            Members.Add(passenger);
        }

        public int CalculateTotalPrice()
        {
            int totalPrice = 0;
            foreach (var member in Members)
            {
                totalPrice += CalculateTicketPrice(member);
            }
            return totalPrice;
        }
        private int CalculateTicketPrice(Passenger passenger)
        {
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

