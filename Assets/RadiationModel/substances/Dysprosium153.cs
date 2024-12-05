using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium153";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 152.92577d;

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
    