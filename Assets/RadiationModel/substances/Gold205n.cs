using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold205n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold205n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 204.98312d;

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
    