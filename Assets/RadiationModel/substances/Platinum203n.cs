using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum203n : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum203n";
        public override double halfLife { get; } = 12.0d;
        public override double atomicWeight { get; } = 202.98058d;

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
    