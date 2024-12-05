using System;
using System.Collections.Generic;
using NUnit.Framework;
using RadiationModel;
using UnityEngine;

namespace Tests.ScriptsTests
{
    public class RadiationEmitterTest
    {
        [Test]
        public void HasGammaAbsorbedTest()
        {
            var total = 0L;
            const int amount = 200;
            
            // run a million times, and check if expected value
            const int startingAmount = 1000000;
            const double mu = 1.0;
            const double distance = 1.0;
            const double density = 1.0;

            var expected = startingAmount * Math.Exp(-mu * distance * density);

            for (var i = 0; i < amount; i++)
            {
                var result = 0;
                for (var j = 0; j < startingAmount; j++)
                {
                    result += RadiationEmitter.HasGammaAbsorbed(null, distance,  density, mu) ? 1 : 0;
                }

                Debug.Log("Off by: " + (expected - result));
                total += result;
            }
            
            var average = total / amount;
            
            Debug.Log("Average off by: " + (expected - average));

            Assert.LessOrEqual(Math.Abs(expected - average), startingAmount * 0.0001);
        }
        
        [Test]
        public void HasBetaAbsorbedTest()
        {
            var betaParticle = new BetaParticle(1, new Dictionary<double, double>())
            {
                energy = 100
            };
            
            var result = RadiationEmitter.HasBetaAbsorbed(betaParticle, 500, 1, 1000);
            Debug.Log("Result: " + betaParticle.energy);
            betaParticle.energy = 100;
             var result2 = RadiationEmitter.HasBetaAbsorbed(betaParticle, 50, 1, 1000);
            betaParticle.energy = 100;
            var result3 = RadiationEmitter.HasBetaAbsorbed(betaParticle, 100, 1, 1000);
            
            Assert.AreEqual(true, result);
            Assert.AreEqual(false, result2);
            Assert.AreEqual(true, result3);
        }
    }
}