using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Scandium44n : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium44n";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 43.95956d;

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
    