using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum181m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum181m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 180.94801d;

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
    