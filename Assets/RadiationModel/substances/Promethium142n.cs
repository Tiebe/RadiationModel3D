using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium142n : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium142n";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 141.91593d;

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
    