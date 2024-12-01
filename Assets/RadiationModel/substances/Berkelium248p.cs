using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Berkelium248p : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium248p";
        public override double halfLife { get; } = 284012333.77133d;
        public override double atomicWeight { get; } = 248.07319d;

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
    