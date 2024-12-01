using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium192m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium192m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 191.9938d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium192()), new(0.8652d, new GammaParticle(154000.0, 0.00805)), new(0.043385368d, new GammaParticle(13292.0, 0.09328)), new(0.03050144236322405d, new GammaParticle(76862.0, 0.01613)), new(0.050793409430847716d, new GammaParticle(79290.0, 0.01564)), new(0.01748676445913672d, new GammaParticle(89837.0, 0.0138)), new(0.022925148205928236d, new GammaParticle(90941.0, 0.01363)), new(0.00543838374679152d, new GammaParticle(92315.0, 0.01343)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    