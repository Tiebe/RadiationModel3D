using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium169";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 168.94581d;

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
    