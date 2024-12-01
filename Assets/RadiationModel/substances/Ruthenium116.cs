using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium116";
        public override double halfLife { get; } = 0.204d;
        public override double atomicWeight { get; } = 115.93122d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium116()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
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
    