using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium257n : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium257n";
        public override double halfLife { get; } = 0.00014d;
        public override double atomicWeight { get; } = 257.10416d;

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
    