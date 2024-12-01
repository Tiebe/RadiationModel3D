using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium195 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium195";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 194.97256d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium195()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    