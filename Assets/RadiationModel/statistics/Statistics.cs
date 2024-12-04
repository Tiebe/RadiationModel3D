using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Random;

namespace RadiationModel.statistics
{
    public static class Statistics
    {
        public static double CalculateLambda(double halfLife, long itemAmount, double elapsedTime)
        {
            // calculate lambda for the poisson function
            var decayConstant = Math.Log(2) / halfLife;
            return itemAmount * (1 - Math.Exp(-decayConstant * elapsedTime));
        }

        public static Dictionary<RadioactiveSubstance, long> GetDecayProducts(
            Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts, long amountDecayed)
        {
            var products = new Dictionary<RadioactiveSubstance, long>();

            foreach (var decayProduct in decayProducts)
            {
                var probability = decayProduct.Key;
                var substanceProducts = decayProduct.Value;
                var productAmount = amountDecayed * probability;
                foreach (var product in substanceProducts)
                {
                    products.TryAdd(product.Value, 0);
                    products[product.Value] += (long)Math.Round(productAmount * product.Key);
                }
            }

            return products;
        }
        
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
            var lambda = CalculateLambda(substance.halfLife, itemAmount, elapsedTime);
            
            // error handling in case lambda <= 0
            // lambda can by definition not be less than or equal to 0, but when lambda is very small floating point errors occur and that causes errors
            long decayed = lambda > 0 ? Poisson.Sample(SystemRandomSource.Default, lambda) : 0;

            // convert decayed amount into usable data
            var remainingItems = itemAmount - decayed;

            var products = GetDecayProducts(substance.decayProducts, decayed);
            products.TryAdd(substance, 0);
            products[substance] += remainingItems;

            return products;
        }

        public static double RandomBetaEnergy(Dictionary<double, double> spectrum)
        {
            // Initialize random number generator
            var random = new Random();

            // Extract keys (energies) and values (dN/dE)
            var binEnergies = spectrum.Keys.ToList();
            var dnDeValues = spectrum.Values.ToList();

            // Calculate probabilities by integrating within each bin
            var binProbabilities = new List<double>();
            for (int i = 0; i < dnDeValues.Count - 1; i++)
            {
                // Approximate the area (trapezoidal integration)
                double binWidth = binEnergies[i + 1] - binEnergies[i];
                double binArea = 0.5 * (dnDeValues[i] + dnDeValues[i + 1]) * binWidth;
                binProbabilities.Add(binArea);
            }

            // Normalize the probabilities
            double totalProbability = binProbabilities.Sum();
            for (int i = 0; i < binProbabilities.Count; i++)
            {
                binProbabilities[i] /= totalProbability;
            }
            
            // Build the cumulative distribution function (CDF)
            List<double> cdf = new List<double>();
            double cumulative = 0.0;
            foreach (var prob in binProbabilities)
            {
                cumulative += prob;
                cdf.Add(cumulative);
            }

            // Generate a random number in [0, 1]
            double r = random.NextDouble();

            // Find the corresponding bin
            int binIndex = 0;
            for (int i = 0; i < cdf.Count; i++)
            {
                if (r <= cdf[i])
                {
                    binIndex = i;
                    break;
                }
            }

            // Interpolate within the bin
            double energyLow = binEnergies[binIndex];
            double energyHigh = binEnergies[binIndex + 1];
            double dnDeLow = binProbabilities[binIndex];
            double dnDeHigh = binProbabilities[Math.Min(binIndex + 1, binProbabilities.Count - 1)];

            // Generate a random energy within the bin
            double binSize = energyHigh - energyLow;
            while (true)
            {
                double randomEnergy = energyLow + random.NextDouble() * binSize;
                double interpolatedDnDe = dnDeLow + (dnDeHigh - dnDeLow) * (randomEnergy - energyLow) / binSize;

                // Accept or reject based on interpolated dN/dE
                if (random.NextDouble() <= interpolatedDnDe)
                {
                    return randomEnergy;
                }
            }
        }
    }
}