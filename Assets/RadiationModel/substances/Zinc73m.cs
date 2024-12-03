using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zinc73m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc73m";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 72.92979d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc73()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    