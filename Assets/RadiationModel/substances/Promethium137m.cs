using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium137m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium137m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 136.92065d;

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
    