using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// When creating a message for the reservation system  
///  - must include a pickup date
///  - pickup date must be in the future
///  - must include a dropoff date
///  - dropoff must be later than the pickup date
///  - may include the registered customer's club number

namespace mvc_tdd.Tests
{

    public static class SystemTime
    {
        public static Func<DateTime> Now = () => DateTime.Now;
    }

    public class ReservationMessage
    {
        public ReservationMessage(DateTime pickupDate)
        {
            if (pickupDate < SystemTime.Now())
            {
                throw new ArgumentException();
            }
                        
            PickupDate = pickupDate;
        }
        
        public System.DateTime PickupDate { get; private set; }
    }

    [TestClass]
    public class when_create_message_for_reservation_system
    {
        [TestInitialize]
        public void Initialize()
        {
            SystemTime.Now = () => new DateTime(2009, 1, 1);
        }

         [TestMethod]
        public void it_must_include_a_pickup_date()
        {
            // Arrange
            DateTime pickupDate = new DateTime(2010, 1, 1);

            // Act
            var message = new ReservationMessage(pickupDate);

            // Assert
            Assert.AreEqual(pickupDate, message.PickupDate);

        }

         [TestMethod]
         [ExpectedException(typeof(ArgumentException))]
         public void it_fails_if_pickup_date_is_in_the_past()
         {
             DateTime pickupDate = new DateTime(2008, 12, 31);

             var message = new ReservationMessage(pickupDate);

             Assert.Fail("Message constructor should have thrown an exception");
         }
    }
}
