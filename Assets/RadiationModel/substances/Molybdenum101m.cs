using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum101m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum101m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 100.91035d;

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
    