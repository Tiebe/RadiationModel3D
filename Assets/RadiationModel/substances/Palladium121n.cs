using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium121n : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium121n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 120.92912d;

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
    