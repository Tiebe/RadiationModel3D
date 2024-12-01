using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth205m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth205m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 204.97899d;

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
    