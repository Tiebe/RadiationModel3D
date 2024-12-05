using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium195 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium195";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 194.98807d;

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
    