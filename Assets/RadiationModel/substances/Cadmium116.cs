using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium116";
        public override double halfLife { get; } = 1.041378557161536e+27d;
        public override double atomicWeight { get; } = 115.90476d;

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
    