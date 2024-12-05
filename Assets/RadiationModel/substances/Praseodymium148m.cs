using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium148m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium148m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 147.92221d;

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
    