using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium82m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium82m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 81.92736d;

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
    