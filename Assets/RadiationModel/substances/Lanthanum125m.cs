using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lanthanum125m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum125m";
        public override double halfLife { get; } = 0.39d;
        public override double atomicWeight { get; } = 124.92093d;

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
    