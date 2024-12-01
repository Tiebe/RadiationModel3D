using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth190p : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth190p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 189.98905d;

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
    