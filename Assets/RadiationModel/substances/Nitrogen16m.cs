using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nitrogen16m : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen16m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 16.00623d;

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
    