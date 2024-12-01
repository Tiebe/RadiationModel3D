using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lanthanum152 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum152";
        public override double halfLife { get; } = 0.298d;
        public override double atomicWeight { get; } = 151.94709d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cerium152()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    