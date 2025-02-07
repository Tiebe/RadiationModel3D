using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Plutonium241n : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium241n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 241.05922d;

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
    