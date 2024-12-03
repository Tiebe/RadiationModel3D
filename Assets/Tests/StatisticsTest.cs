using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using RadiationModel.statistics;
using UnityEngine.TestTools;

namespace Tests
{
    public class StatisticsTest
    {
        [Test]
        public void RandomBetaEnergyTest()
        {
            // Arrange
            var spectrum = new Dictionary<double, double>
            {
                {0.0, 0.0},
                {1.0, 1.0},
                {2.0, 2.0},
                {3.0, 3.0},
                {4.0, 4.0},
                {5.0, 5.0},
                {6.0, 6.0},
                {7.0, 7.0},
                {8.0, 8.0},
                {9.0, 9.0},
                {10.0, 10.0}
            };
            
            for (var i = 0; i < 100; i++)
            {
                // Act
                var result = Statistics.RandomBetaEnergy(spectrum);

                // Assert
                Assert.That(result, Is.GreaterThanOrEqualTo(0.0));
                Assert.That(result, Is.LessThanOrEqualTo(10.0));
            }
        }

        [Test]
        public void DecayTest()
        {
            Assert.Fail("Write the test");
        }
    }
}
