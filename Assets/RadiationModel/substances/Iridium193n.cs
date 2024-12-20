using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium193n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium193n";
        public override double halfLife { get; } = 0.00012d;
        public override double atomicWeight { get; } = 192.96537d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium193()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    