using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium257";
        public override double halfLife { get; } = 665280.0d;
        public override double atomicWeight { get; } = 257.09597d;

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
    