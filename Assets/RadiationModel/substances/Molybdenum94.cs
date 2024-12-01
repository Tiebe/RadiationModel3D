using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum94 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum94";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 93.90508d;

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
    