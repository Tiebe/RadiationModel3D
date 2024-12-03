using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony122n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony122n";
        public override double halfLife { get; } = 0.00053d;
        public override double atomicWeight { get; } = 121.90532d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony122()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    