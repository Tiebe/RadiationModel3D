using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Phosphorus39 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus39";
        public override double halfLife { get; } = 0.28d;
        public override double atomicWeight { get; } = 38.98629d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Sulfur39()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.26d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Sulfur39()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    