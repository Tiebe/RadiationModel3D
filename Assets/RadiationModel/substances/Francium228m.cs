using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium228m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium228m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 228.03692d;

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
    