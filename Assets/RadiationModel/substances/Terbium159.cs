using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium159";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 158.92535d;

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
    