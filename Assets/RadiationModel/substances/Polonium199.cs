using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium199 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium199";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 198.98364d;

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
    