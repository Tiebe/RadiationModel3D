using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium136m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium136m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 135.93071d;

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
    