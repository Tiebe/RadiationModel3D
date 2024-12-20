using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium151";
        public override double halfLife { get; } = 5.36467741568064e+25d;
        public override double atomicWeight { get; } = 150.91986d;

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
    