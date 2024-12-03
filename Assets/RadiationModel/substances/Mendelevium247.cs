using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium247";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 247.08152d;

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
    