using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium265 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium265";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 265.11668d;

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
    