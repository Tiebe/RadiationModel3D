using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt64m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt64m";
        public override double halfLife { get; } = 0.28d;
        public override double atomicWeight { get; } = 63.93592d;

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
    