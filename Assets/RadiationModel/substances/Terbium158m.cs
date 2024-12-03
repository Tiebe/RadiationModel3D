using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium158m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium158m";
        public override double halfLife { get; } = 10.7d;
        public override double atomicWeight { get; } = 157.92554d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium158()), new(0.0092d, new GammaParticle(110300.0, 0.01124)), new(0.14813784d, new GammaParticle(7118.0, 0.17418)), new(0.13836193172677075d, new GammaParticle(43743.0, 0.02834)), new(0.24809383490545234d, new GammaParticle(44481.0, 0.02787)), new(0.07922496693230881d, new GammaParticle(50494.0, 0.02455)), new(0.0997442333677768d, new GammaParticle(51040.0, 0.02429)), new(0.02051926643546798d, new GammaParticle(51699.0, 0.02398)) } },
            { 0.006d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium158()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.0001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium158()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    