using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium121";
        public override double halfLife { get; } = 0.285d;
        public override double atomicWeight { get; } = 120.92895d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver121()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.008d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver121()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    