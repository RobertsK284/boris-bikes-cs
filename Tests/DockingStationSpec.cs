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

            // act
            Bike bike = dockingstation.ReleaseBike();

            // assert
            Assert.That(bike, Is.InstanceOf(typeof(Bike)));
            Assert.AreEqual(true, bike.Working());
        }
    }
}
