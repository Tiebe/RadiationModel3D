using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium253n : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium253n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 253.09185d;

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
    