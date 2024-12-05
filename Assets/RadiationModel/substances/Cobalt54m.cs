using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt54m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt54m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 53.94867d;

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
    