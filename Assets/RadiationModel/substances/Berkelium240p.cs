using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Berkelium240p : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium240p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 240.06001d;

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
    