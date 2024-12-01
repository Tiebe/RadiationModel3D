using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Phosphorus37 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus37";
        public override double halfLife { get; } = 2.31d;
        public override double atomicWeight { get; } = 36.9796d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Sulfur37()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    