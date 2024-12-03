using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth206m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth206m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 205.97856d;

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
    