using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium147";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 146.91901d;

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
    