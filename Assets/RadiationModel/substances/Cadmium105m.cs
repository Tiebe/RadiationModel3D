using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium105m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium105m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 104.91217d;

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
    