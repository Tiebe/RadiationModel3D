using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium125n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium125n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 124.91583d;

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
    