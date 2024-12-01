using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium181";
        public override double halfLife { get; } = 294.0d;
        public override double atomicWeight { get; } = 180.95763d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium181()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    