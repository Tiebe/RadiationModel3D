using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead190p : RadioactiveSubstance
    {
        public override string name { get; } = "Lead190p";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 189.98093d;

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
    