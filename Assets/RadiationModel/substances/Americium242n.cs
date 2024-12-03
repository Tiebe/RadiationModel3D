using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Americium242n : RadioactiveSubstance
    {
        public override string name { get; } = "Americium242n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 242.06191d;

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
    