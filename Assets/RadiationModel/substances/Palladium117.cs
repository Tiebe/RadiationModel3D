using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium117";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 116.91796d;

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
    