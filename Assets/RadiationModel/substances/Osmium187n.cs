using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium187n : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium187n";
        public override double halfLife { get; } = 0.00023d;
        public override double atomicWeight { get; } = 186.95603d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    