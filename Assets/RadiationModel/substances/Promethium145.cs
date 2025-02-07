using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium145";
        public override double halfLife { get; } = 558557589.75028d;
        public override double atomicWeight { get; } = 144.91276d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium145()), new(0.0068200000000000005d, new GammaParticle(67200.0, 0.01845)), new(0.022000000000000002d, new GammaParticle(72400.0, 0.01712)), new(0.134361617656d, new GammaParticle(5870.0, 0.21122)), new(0.21724692648106356d, new GammaParticle(36848.0, 0.03365)), new(0.39564182568031975d, new GammaParticle(37362.0, 0.03318)), new(0.12150507322085659d, new GammaParticle(42380.0, 0.02926)), new(0.1527318770386167d, new GammaParticle(42810.0, 0.02896)), new(0.031226803817760142d, new GammaParticle(43335.0, 0.02861)) } },
            { 2.8000000000000003e-09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Praseodymium141()), new(1.0d, new AlphaParticle(3344002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    