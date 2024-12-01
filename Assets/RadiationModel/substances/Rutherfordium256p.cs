using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium256p : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium256p";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 256.10373d;

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
    