using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine143 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine143";
        public override double halfLife { get; } = 0.13d;
        public override double atomicWeight { get; } = 142.94547d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
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
    