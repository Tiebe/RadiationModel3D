using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fermium251m : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium251m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 251.08176d;

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
    