using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium167";
        public override double halfLife { get; } = 18.9d;
        public override double atomicWeight { get; } = 166.94001d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium167()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    