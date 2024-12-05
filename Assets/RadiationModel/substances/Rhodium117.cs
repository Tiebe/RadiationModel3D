using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium117";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 116.92604d;

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
    