using NUnit.Framework;
using Project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    [TestFixture]
    public class AirplaneTicketingTests
    {
        [Test]
        public void TestCalculateTotalPrice()
        {
            // Arrange
            var family = new Family();
            family.AddMember(new Passenger("Adult1", 35, isChild: false));
            family.AddMember(new Passenger("Child1", 8, isChild: true));
            family.AddMember(new Passenger("Child2", 10, isChild: true));

            // Act
            int totalPrice = family.CalculateTotalPrice();

            // Assert

            Assert.That(totalPrice, Is.EqualTo(550));

            // Expected total price: 250 (Adult) + 150 (Child) + 150 (Child) = 550
        }

        [Test]
        public void TestOptimizeRevenue()
        {
            // Arrange
            var ticketing = new AirplaneTicketing();
            ticketing.GeneratePassengersAndFamilies();

            // Act
            ticketing.OptimizeRevenue();


            // Assert
            Assert.That(ticketing.OptimizeRevenue(), Is.EqualTo(2250));


        }


    }
}
