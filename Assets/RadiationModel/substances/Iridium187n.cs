using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium187n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium187n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 186.95801d;

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
    