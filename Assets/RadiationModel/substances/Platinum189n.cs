using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum189n : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum189n";
        public override double halfLife { get; } = 0.00014d;
        public override double atomicWeight { get; } = 188.96105d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum189()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    