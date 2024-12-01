using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium148n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium148n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 147.93353d;

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
    