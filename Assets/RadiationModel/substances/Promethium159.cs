using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium159";
        public override double halfLife { get; } = 1.634d;
        public override double atomicWeight { get; } = 158.93929d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium159()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.006d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium159()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    