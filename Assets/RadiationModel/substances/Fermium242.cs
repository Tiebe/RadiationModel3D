using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fermium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium242";
        public override double halfLife { get; } = 0.0008d;
        public override double atomicWeight { get; } = 242.07343d;

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
    