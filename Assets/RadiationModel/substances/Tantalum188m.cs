using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum188m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum188m";
        public override double halfLife { get; } = 19.6d;
        public override double atomicWeight { get; } = 187.9637d;

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
    