using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Californium249m : RadioactiveSubstance
    {
        public override string name { get; } = "Californium249m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 249.07501d;

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
    