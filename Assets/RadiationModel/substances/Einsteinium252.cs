using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium252";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 252.08297d;

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
    