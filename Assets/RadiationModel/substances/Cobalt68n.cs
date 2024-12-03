using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt68n : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt68n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 67.94477d;

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
    