using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bromine81m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine81m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 80.91686d;

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
    