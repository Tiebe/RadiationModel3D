using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Berkelium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium253";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 253.08688d;

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
    