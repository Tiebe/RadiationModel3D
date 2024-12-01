using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth212n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth212n";
        public override double halfLife { get; } = 420.0d;
        public override double atomicWeight { get; } = 211.99287d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.75d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth212()) } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium212()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    