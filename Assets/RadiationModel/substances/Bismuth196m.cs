using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth196m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth196m";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 195.98084d;

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
    