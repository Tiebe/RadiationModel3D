using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony126 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony126";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 125.90726d;

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
    