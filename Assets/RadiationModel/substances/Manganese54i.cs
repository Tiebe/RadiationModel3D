using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Manganese54i : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese54i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 53.94695d;

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
    