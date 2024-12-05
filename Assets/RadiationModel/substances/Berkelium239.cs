using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Berkelium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium239";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 239.05824d;

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
    