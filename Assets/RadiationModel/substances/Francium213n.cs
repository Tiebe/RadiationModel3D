using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium213n : RadioactiveSubstance
    {
        public override string name { get; } = "Francium213n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 212.99891d;

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
    