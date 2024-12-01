using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium122";
        public override double halfLife { get; } = 0.175d;
        public override double atomicWeight { get; } = 121.93063d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver122()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.025d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver122()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    