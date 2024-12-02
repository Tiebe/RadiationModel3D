using System.Collections.Generic;

namespace RadiationModel
{
    public abstract class Material
    {
        public abstract string name { get; }
        public abstract double density { get; } // Kg/m^3
        public abstract double atomicWeight { get; } // useless (just like me frfr)

        protected abstract Dictionary<double, double> massAttenuationCoefficients { get; } // { ev, cm^2/g }
        protected abstract Dictionary<double, double> massStoppingPowers { get; } // { eV, cm^2/g }
        
        public double GetClosestMAC(double energy)
        {
            var closestMAC = 0d;
            var closestDistance = double.MaxValue;
            foreach (var (key, value) in massAttenuationCoefficients)
            {
                var distance = System.Math.Abs(key - energy);
                if (!(distance < closestDistance)) continue;
                closestMAC = value;
                closestDistance = distance;
            }

            return closestMAC;
        }
        
        public double GetClosestMSP(double energy)
        {
            var closestMSP = 0d;
            var closestDistance = double.MaxValue;
            foreach (var (key, value) in massStoppingPowers)
            {
                var distance = System.Math.Abs(key - energy);
                if (!(distance < closestDistance)) continue;
                closestMSP = value;
                closestDistance = distance;
            }

            return closestMSP;
        }
    }
}