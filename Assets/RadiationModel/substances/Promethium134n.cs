using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium134n : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium134n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 133.92846d;

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
    