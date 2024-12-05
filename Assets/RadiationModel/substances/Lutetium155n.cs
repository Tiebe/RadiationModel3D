using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium155n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium155n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 154.95624d;

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
    