using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt56i : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt56i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 55.94369d;

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
    