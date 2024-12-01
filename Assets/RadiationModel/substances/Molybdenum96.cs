using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum96 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum96";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 95.90467d;

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
    