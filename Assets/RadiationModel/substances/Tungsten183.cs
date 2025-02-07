using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten183 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten183";
        public override double halfLife { get; } = 2.114314040297664e+28d;
        public override double atomicWeight { get; } = 182.95022d;

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
    