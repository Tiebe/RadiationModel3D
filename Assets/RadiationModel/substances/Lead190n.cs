using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead190n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead190n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 189.98094d;

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
    