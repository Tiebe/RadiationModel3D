using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold176 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold176";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 175.98012d;

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
    