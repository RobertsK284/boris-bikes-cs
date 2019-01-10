using NUnit.Framework;
using System;
using borisbikescs.Models;

namespace borisbikescs.Tests
{
    [TestFixture]
    public class DockingStationSpec
    {

        [Test(Description = "ReleaseBike releases a working bike")]
        public void Responds_to_ReleaseBike()
        {
            // arrange
            DockingStation dockingstation = new DockingStation();
            Bike bike = new Bike();
            dockingstation.Dock(bike);

             // act
            Bike bike2 = dockingstation.ReleaseBike();

            // assert
            Assert.That(bike2, Is.SameAs(bike));
            Assert.AreEqual(true, bike2.Working());
        }

        [Test(Description = "ReleaseBike raises an error if no bikes are available")]
     
        public void ReleaseBike_Error()
        {
            // arrange
            DockingStation dockingstation = new DockingStation();

            // act
            Bike bike2 = dockingstation.ReleaseBike();

            // assert
            Assert.That(bike2, Throws.Exception);
        }

        [Test(Description = "Can Dock a bike")]
        public void Responds_to_Dock()
        {
            // arrange
            DockingStation dockingstation = new DockingStation();
            Bike bike = new Bike();

            // act
            Bike bike2 = dockingstation.Dock(bike);

            // assert
            Assert.That(bike2, Is.SameAs(bike));

        }
    }
}
