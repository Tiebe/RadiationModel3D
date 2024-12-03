using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium184m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium184m";
        public override double halfLife { get; } = 0.00047d;
        public override double atomicWeight { get; } = 183.95772d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium184()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    