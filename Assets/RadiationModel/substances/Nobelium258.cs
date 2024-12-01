using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium258";
        public override double halfLife { get; } = 0.0012d;
        public override double atomicWeight { get; } = 258.09821d;

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
    