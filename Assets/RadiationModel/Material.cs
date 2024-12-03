using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RadiationModel
{
    public abstract class Material
    {
        public abstract string name { get; }
        public abstract double density { get; } // Kg/m^3
        public abstract double atomicWeight { get; } // useless (just like me frfr)

        /**
         * The mass attenuation coefficients of the material.
         * Key: the energy of the gamma particle in eV
         * Value: the mass attenuation coefficient in cm^2/g
         */
        public abstract Dictionary<double, double> massAttenuationCoefficients { get; }

        public abstract Dictionary<double, double> massStoppingPowers { get; }

        public double GetMACForEnergy(double energy)
        {
            if (massAttenuationCoefficients.ContainsKey(energy))
            {
                return massAttenuationCoefficients[energy];
            }

            var lowerBound = double.MinValue;
            var upperBound = double.MaxValue;
            var lowerValue = 0d;
            var upperValue = 0d;

            foreach (var (key, value) in massAttenuationCoefficients)
            {
                if (key < energy && key > lowerBound)
                {
                    lowerBound = key;
                    lowerValue = value;
                }

                if (!(key > energy) || !(key < upperBound)) continue;
                upperBound = key;
                upperValue = value;
            }

            if (lowerBound == double.MinValue)
            {
                // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
                Debug.LogWarning("Energy is lower than the lowest value in the MAC table. Returning the lowest value.");
                return massAttenuationCoefficients.Values.First();
            }

            if (upperBound == double.MaxValue)
            {
                // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
                Debug.LogWarning("Energy is higher than the highest value in the MAC table. Returning the highest value.");
                return massAttenuationCoefficients.Values.Last();
            }

            var slope = (upperValue - lowerValue) / (upperBound - lowerBound);
            return lowerValue + slope * (energy - lowerBound);
        }

        public double GetMSPForEnergy(double energy)
        {
            if (massStoppingPowers.ContainsKey(energy))
            {
                return massStoppingPowers[energy];
            }

            var lowerBound = double.MinValue;
            var upperBound = double.MaxValue;
            var lowerValue = 0d;
            var upperValue = 0d;

            foreach (var (key, value) in massStoppingPowers)
            {
                if (key < energy && key > lowerBound)
                {
                    lowerBound = key;
                    lowerValue = value;
                }

                if (!(key > energy) || !(key < upperBound)) continue;
                upperBound = key;
                upperValue = value;
            }

            if (lowerBound == double.MinValue)
            {
                // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
                Debug.LogWarning("Energy is lower than the lowest value in the MSP table. Returning the lowest value.");
                return massStoppingPowers.Values.First();
            }

            if (upperBound == double.MaxValue)
            {
                // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
                Debug.LogWarning("Energy is higher than the highest value in the MSP table. Returning the highest value.");
                return massStoppingPowers.Values.Last();
            }

            var slope = (upperValue - lowerValue) / (upperBound - lowerBound);
            return lowerValue + slope * (energy - lowerBound);
        }
    }
}