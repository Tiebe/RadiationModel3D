using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium205n : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium205n";
        public override double halfLife { get; } = 0.00064d;
        public override double atomicWeight { get; } = 204.98214d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium205()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    