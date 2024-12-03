using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium90q : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium90q";
        public override double halfLife { get; } = 0.00619d;
        public override double atomicWeight { get; } = 89.91167d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium90()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    