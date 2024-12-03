using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Titanium43m : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium43m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 42.96886d;

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
    