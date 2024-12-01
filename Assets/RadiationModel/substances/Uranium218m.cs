using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium218m : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium218m";
        public override double halfLife { get; } = 0.00056d;
        public override double atomicWeight { get; } = 218.02577d;

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
    