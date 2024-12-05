using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium249m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium249m";
        public override double halfLife { get; } = 1.5d;
        public override double atomicWeight { get; } = 249.08296d;

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
    