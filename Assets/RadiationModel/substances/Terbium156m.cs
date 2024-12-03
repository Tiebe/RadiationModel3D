using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium156m";
        public override double halfLife { get; } = 19080.0d;
        public override double atomicWeight { get; } = 155.92485d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium156()), new(0.0115d, new GammaParticle(88400.0, 0.01403)), new(0.07d, new GammaParticle(7118.0, 0.17418)), new(0.008d, new GammaParticle(43743.0, 0.02834)), new(0.013999999999999999d, new GammaParticle(44481.0, 0.02787)), new(0.005d, new GammaParticle(50494.0, 0.02455)), new(0.006d, new GammaParticle(51040.0, 0.02429)), new(0.0012d, new GammaParticle(51699.0, 0.02398)) } },
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium156()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    