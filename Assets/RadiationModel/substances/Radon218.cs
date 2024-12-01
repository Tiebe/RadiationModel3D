using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon218 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon218";
        public override double halfLife { get; } = 0.03375d;
        public override double atomicWeight { get; } = 218.0056d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium214()), new(1.0d, new AlphaParticle(8284402.09)), new(0.00127d, new GammaParticle(609310.0, 0.00203)), new(9.000000000000001e-07d, new GammaParticle(665300.0, 0.00186)), new(8.272576244231e-06d, new GammaParticle(13292.0, 0.09328)), new(5.334705375956275e-06d, new GammaParticle(76862.0, 0.01613)), new(8.883772482858077e-06d, new GammaParticle(79290.0, 0.01564)), new(3.058436884962355e-06d, new GammaParticle(89837.0, 0.0138)), new(4.009610756185647e-06d, new GammaParticle(90941.0, 0.01363)), new(9.511738712232925e-07d, new GammaParticle(92315.0, 0.01343)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    