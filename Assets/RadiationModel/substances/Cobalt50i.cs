using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt50i : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt50i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 49.98632d;

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
    