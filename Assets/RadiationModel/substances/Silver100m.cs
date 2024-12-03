using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver100m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver100m";
        public override double halfLife { get; } = 134.4d;
        public override double atomicWeight { get; } = 99.91613d;

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
    