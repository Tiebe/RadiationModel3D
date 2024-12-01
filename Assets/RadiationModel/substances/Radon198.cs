using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon198 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon198";
        public override double halfLife { get; } = 0.065d;
        public override double atomicWeight { get; } = 197.99868d;

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
    