using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iron65n : RadioactiveSubstance
    {
        public override string name { get; } = "Iron65n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 64.94544d;

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
    