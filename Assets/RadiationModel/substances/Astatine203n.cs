using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine203n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine203n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 202.98944d;

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
    