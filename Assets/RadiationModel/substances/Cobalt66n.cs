using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt66n : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt66n";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 65.94013d;

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
    