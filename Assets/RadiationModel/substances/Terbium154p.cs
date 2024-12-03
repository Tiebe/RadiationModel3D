using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium154p : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium154p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 153.92511d;

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
    