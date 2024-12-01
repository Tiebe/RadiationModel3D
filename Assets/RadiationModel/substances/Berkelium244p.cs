using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Berkelium244p : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium244p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 244.06533d;

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
    