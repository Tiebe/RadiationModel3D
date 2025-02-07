using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium207p : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium207p";
        public override double halfLife { get; } = 2.79d;
        public override double atomicWeight { get; } = 206.98308d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium207()), new(0.003165056d, new GammaParticle(109100.0, 0.01136)), new(0.44508600000000004d, new GammaParticle(268080.0, 0.00462)), new(0.33430904d, new GammaParticle(300648.0, 0.00412)), new(0.98908d, new GammaParticle(814410.0, 0.00152)), new(0.57d, new GammaParticle(13292.0, 0.09328)), new(0.2d, new GammaParticle(76862.0, 0.01613)), new(0.33d, new GammaParticle(79290.0, 0.01564)), new(0.113d, new GammaParticle(89837.0, 0.0138)), new(0.15d, new GammaParticle(90941.0, 0.01363)), new(0.035d, new GammaParticle(92315.0, 0.01343)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    