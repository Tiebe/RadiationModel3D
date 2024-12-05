using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon199 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon199";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 198.99833d;

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
    