using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth199n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth199n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 198.97978d;

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
    