using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium151";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 150.92619d;

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
    