using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Berkelium250n : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium250n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 250.07841d;

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
    