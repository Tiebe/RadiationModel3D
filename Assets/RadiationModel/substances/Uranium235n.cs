using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium235n : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium235n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 235.04661d;

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
    