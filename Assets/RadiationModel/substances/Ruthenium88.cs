using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium88";
        public override double halfLife { get; } = 1.2d;
        public override double atomicWeight { get; } = 87.94166d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum88()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
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
    