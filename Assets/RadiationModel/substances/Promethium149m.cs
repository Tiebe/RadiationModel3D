using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium149m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium149m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 148.9186d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Promethium149()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    