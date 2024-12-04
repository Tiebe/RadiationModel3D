using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using RadiationModel;
using RadiationModel.statistics;

namespace Tests.RadiationModelTests
{
    public class StatisticsTest
    {
        [Test]
        public void DecayTest()
        {
            // TODO: what's a good way to test this?
            
        }

        [Test]
        public void CalculateLambdaTest()
        {
            // lambda is the expected value
            // so after 60 seconds (aka 1 half life) the expected value should be half of the current itemAmount
            var itemAmount = 1000L;
            var halfLife = 60.0;
            var elapsedTime = 60.0;
            
            var result = Statistics.CalculateLambda(halfLife, itemAmount, elapsedTime);
            
            Assert.AreEqual(itemAmount / 2, result);
            
            // and after 120 seconds (aka 2 half lives) the expected value (amount that has been decayed) should be three quarters of the current itemAmount
            elapsedTime = 120.0;
            
            result = Statistics.CalculateLambda(halfLife, itemAmount, elapsedTime);
            
            Assert.AreEqual(itemAmount * 3/4, result);
        }

        [Test]
        public void GetDecayProductsTest()
        {
            // Arrange
            var decayProducts = new Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>>
            {
                {0.6, new List<KeyValuePair<double, RadioactiveSubstance>> {new(0.5, new GammaParticle())}},
                {0.4, new List<KeyValuePair<double, RadioactiveSubstance>> {new(0.5, new BetaParticle())}}
            };
            var amountDecayed = 1000L;
            
            // Act
            var result = Statistics.GetDecayProducts(decayProducts, amountDecayed);
            
            // Assert
            // expecting 2 decay products (gamma and beta, original particle isn't included in this function), one with itemAmount * 0.6 * 0.5 and the other with itemAmount * 0.4 * 0.5
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(amountDecayed * 0.6 * 0.5, result.Where(x => x.Key is GammaParticle).Select(x => x.Value).First());
            Assert.AreEqual(amountDecayed * 0.4 * 0.5, result.Where(x => x.Key is BetaParticle).Select(x => x.Value).First());
        }

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

        public class TestingSubstance : RadioactiveSubstance
        {
            public override string name { get; } = "TestingSubstance";
            public override double halfLife { get; } = 60.0;
            public override double atomicWeight { get; } = 0.0;
            public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
            {
                {1.0, new List<KeyValuePair<double, RadioactiveSubstance>> {new(1.0, new GammaParticle())}}
            };
        }
    }
}
