using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth197 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth197";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 196.97887d;

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
    