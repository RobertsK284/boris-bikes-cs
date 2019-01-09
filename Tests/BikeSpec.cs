using NUnit.Framework;
using System;
using borisbikescs.Models;

namespace borisbikescs.Tests
{
    [TestFixture()]
    public class BikeSpec
    {
        [Test(Description = "responds to Working?")]
        public void Responds_to_Working()
        {
            // arrange
            Bike bike = new Bike();
            bool expected = true;

            // act
            bool actual = bike.Working();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

