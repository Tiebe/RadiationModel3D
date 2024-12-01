using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium90n : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium90n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 89.90855d;

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
    