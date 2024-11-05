using RadiationModel.substances;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Random;
using System.Collections.Generic;
using System;
using System.Linq;

namespace RadiationModel
{
    public static class Statistics
    {
        /**
         * this function calculates the number of atoms that have decayed based on statistics and a random number generator
         * <param name="substance">The radioactive substance</param>
         * <param name="itemAmount">the amount of atoms of the element</param>
         * <param name="elapsedTime">the amount of time when the element was decaying in seconds</param>
         * <remarks>the item amount is an int, if itemAmount is greater than the 32-bit integer limit, it will cause problems (will fix later if problem)</remarks>
         *
         * <returns>A dictionary of left-over particles. Particle is key, amount is value.</returns>
         */
        public static Dictionary<RadioactiveSubstance, long> decay2(RadioactiveSubstance substance, long itemAmount, double elapsedTime)
        {
            var lambda = Math.Log(2) / substance.halfLife;
            var meanDecays = itemAmount * (1 - Math.Exp(-lambda * elapsedTime));

            long decayed;
            if (meanDecays > 0)
            {
                // Sample the number of decayed particles using the Poisson distribution
                decayed = (long)Poisson.Sample(SystemRandomSource.Default, meanDecays);
            }
            else
            {
                // No decays occur for very small meanDecays
                decayed = 0;
            }

            var remainingItems = itemAmount - decayed;

            var decayProducts = substance.decayProducts;
            var products = new Dictionary<RadioactiveSubstance, long>();

            foreach (var (probability, substanceProducts) in decayProducts)
            {
                var productAmount = (long)(decayed * probability);
                foreach (var product in substanceProducts.Where(product => !products.TryAdd(product, productAmount)))
                {
                    products[product] += productAmount;
                }
            }
            products[substance] = remainingItems;

            return products;
        }
    }
}