using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium231";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 231.03629d;

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
    