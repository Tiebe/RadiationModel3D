using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony126n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony126n";
        public override double halfLife { get; } = 11.0d;
        public override double atomicWeight { get; } = 125.9073d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony126()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    