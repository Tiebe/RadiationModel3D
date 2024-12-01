using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium228m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium228m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 228.03159d;

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
    