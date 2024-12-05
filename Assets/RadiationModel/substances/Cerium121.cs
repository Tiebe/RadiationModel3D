using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cerium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium121";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 120.94343d;

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
    