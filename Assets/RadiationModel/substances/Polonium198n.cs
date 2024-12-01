using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium198n : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium198n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 197.98633d;

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
    