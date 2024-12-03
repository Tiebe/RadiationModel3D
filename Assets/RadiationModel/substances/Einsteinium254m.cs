using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium254m : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium254m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 254.08811d;

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
    