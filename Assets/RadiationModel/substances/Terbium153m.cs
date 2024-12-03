using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium153m";
        public override double halfLife { get; } = 0.00019d;
        public override double atomicWeight { get; } = 152.92362d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium153()), new(0.193d, new GammaParticle(80723.0, 0.01536)), new(0.0218d, new GammaParticle(82464.0, 0.01503)), new(0.27509753400000003d, new GammaParticle(7118.0, 0.17418)), new(0.3663930384380065d, new GammaParticle(43743.0, 0.02834)), new(0.6569715589707844d, new GammaParticle(44481.0, 0.02787)), new(0.20979380666497932d, new GammaParticle(50494.0, 0.02455)), new(0.26413040259120896d, new GammaParticle(51040.0, 0.02429)), new(0.054336595926229636d, new GammaParticle(51699.0, 0.02398)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    