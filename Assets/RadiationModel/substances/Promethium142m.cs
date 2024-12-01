using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium142m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium142m";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 141.91384d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Promethium142()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    