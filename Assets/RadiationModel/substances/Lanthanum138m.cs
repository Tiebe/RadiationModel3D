using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lanthanum138m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum138m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 137.9072d;

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
    