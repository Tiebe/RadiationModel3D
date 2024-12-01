using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony106 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony106";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 105.92864d;

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
    