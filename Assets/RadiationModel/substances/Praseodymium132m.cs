using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium132m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium132m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 131.91927d;

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
    