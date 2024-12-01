using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium120";
        public override double halfLife { get; } = 0.132d;
        public override double atomicWeight { get; } = 119.93707d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium120()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.054000000000000006d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium120()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
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
    