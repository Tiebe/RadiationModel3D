using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium102";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 101.90563d;

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
    