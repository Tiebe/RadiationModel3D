using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum157n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum157n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 156.96994d;

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
    