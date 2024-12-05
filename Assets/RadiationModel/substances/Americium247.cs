using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Americium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium247";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 247.07209d;

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
    