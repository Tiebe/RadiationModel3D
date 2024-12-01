using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fermium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium258";
        public override double halfLife { get; } = 0.00037d;
        public override double atomicWeight { get; } = 258.09708d;

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
    