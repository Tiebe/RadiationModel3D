using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium132p : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium132p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 131.91956d;

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
    