using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium165";
        public override double halfLife { get; } = 126.6d;
        public override double atomicWeight { get; } = 164.93496d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium165()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    