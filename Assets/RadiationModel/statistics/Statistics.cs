using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Random;
using RadiationModel.substances;

namespace RadiationModel.statistics
{
    public static class Statistics
    {
        /**
         * calculates the remaining amount of particles after a specified amount of time
         * <param name="substance">The radioactive substance</param>
         * <param name="itemAmount">the amount of atoms of the element</param>
         * <param name="elapsedTime">the amount of time when the element was decaying in seconds</param>
         * <remarks>our testing using excel and calculating the R-squared value has shown that the poisson distribution shows better results</remarks>
         *
         * <returns>A dictionary of left-over particles. Particle is key, amount is value.</returns>
         */
        public static Dictionary<RadioactiveSubstance, long> Decay(RadioactiveSubstance substance, long itemAmount,
            double elapsedTime)
        {
            // calculate lambda for the poisson function
            var decayConstant = Math.Log(2) / substance.halfLife;
            var lambda = itemAmount * (1 - Math.Exp(-decayConstant * elapsedTime));

            // error handling in case lambda <= 0
            // lambda can by definition not be less than or equal to 0, but when lambda is very small floating point errors occur and that causes errors
            long decayed = lambda > 0 ? Poisson.Sample(SystemRandomSource.Default, lambda) : 0;

            // convert decayed amount into usable data
            var remainingItems = itemAmount - decayed;

            var decayProducts = substance.decayProducts;
            var products = new Dictionary<RadioactiveSubstance, long>();

            foreach (var decayProduct in decayProducts)
            {
                var probability = decayProduct.Key;
                var substanceProducts = decayProduct.Value;
                var productAmount = (long)(decayed * probability);
                foreach (var product in substanceProducts)
                {
                    if (!products.ContainsKey(product))
                    {
                        products.Add(product, 0);
                    }
                    products[product] += productAmount;
                }
            }

            products[substance] = remainingItems;

            return products;
        }
    }
}