using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium207n : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium207n";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 206.98279d;

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
    