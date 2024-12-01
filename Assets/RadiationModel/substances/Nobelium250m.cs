using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium250m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium250m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 250.0887d;

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
    