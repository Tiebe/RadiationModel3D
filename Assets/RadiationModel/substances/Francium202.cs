using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium202 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium202";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 202.00333d;

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
    