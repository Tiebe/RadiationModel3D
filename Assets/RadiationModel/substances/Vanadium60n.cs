using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium60n : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium60n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 59.96469d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Vanadium60()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    