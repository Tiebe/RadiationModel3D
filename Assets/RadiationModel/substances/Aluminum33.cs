using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Aluminum33 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum33";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 32.99088d;

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
    