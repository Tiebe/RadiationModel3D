using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium128";
        public override double halfLife { get; } = 0.035d;
        public override double atomicWeight { get; } = 127.95235d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver128()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
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
    