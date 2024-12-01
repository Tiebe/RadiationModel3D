using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton83m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton83m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 82.91414d;

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
    