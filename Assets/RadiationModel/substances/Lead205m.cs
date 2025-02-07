using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead205m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead205m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 204.97448d;

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
    