using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium143";
        public override double halfLife { get; } = 5.6d;
        public override double atomicWeight { get; } = 142.94399d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium143()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
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
    