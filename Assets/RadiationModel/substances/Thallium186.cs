using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium186";
        public override double halfLife { get; } = 3.4d;
        public override double atomicWeight { get; } = 185.97865d;

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
    