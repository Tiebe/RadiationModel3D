using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium114m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium114m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 113.91894d;

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
    