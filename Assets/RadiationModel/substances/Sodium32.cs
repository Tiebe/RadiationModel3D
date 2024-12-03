using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Sodium32 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium32";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 32.02001d;

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
    