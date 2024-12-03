using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium142m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium142m";
        public override double halfLife { get; } = 0.303d;
        public override double atomicWeight { get; } = 141.93958d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium142()), new(0.000889d, new GammaParticle(29900.0, 0.04147)), new(0.010668d, new GammaParticle(68200.0, 0.01818)), new(0.0006223d, new GammaParticle(98300.0, 0.01261)), new(0.0889d, new GammaParticle(181800.0, 0.00682)), new(0.889d, new GammaParticle(211500.0, 0.00586)), new(0.19d, new GammaParticle(7118.0, 0.17418)), new(0.21d, new GammaParticle(43743.0, 0.02834)), new(0.37d, new GammaParticle(44481.0, 0.02787)), new(0.11800000000000001d, new GammaParticle(50494.0, 0.02455)), new(0.14800000000000002d, new GammaParticle(51040.0, 0.02429)), new(0.03d, new GammaParticle(51699.0, 0.02398)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    