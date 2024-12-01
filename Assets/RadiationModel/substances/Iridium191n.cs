using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium191n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium191n";
        public override double halfLife { get; } = 5.75d;
        public override double atomicWeight { get; } = 190.96285d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium191()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    