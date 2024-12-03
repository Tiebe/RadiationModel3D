using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum99n : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum99n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 98.90844d;

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
    