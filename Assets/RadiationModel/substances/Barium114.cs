using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium114";
        public override double halfLife { get; } = 0.43d;
        public override double atomicWeight { get; } = 113.95071d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.991d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon114()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.2d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon113()), new(1.0d, new ProtonParticle()) } },
            { 0.009000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon110()), new(1.0d, new AlphaParticle(4607002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    