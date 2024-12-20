using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zinc79m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc79m";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 78.94382d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
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
    