using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury179m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury179m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 178.98201d;

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
    