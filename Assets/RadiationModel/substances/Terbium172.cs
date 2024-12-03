using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium172";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 171.95739d;

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
    