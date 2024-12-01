using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium108";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 107.90389d;

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
    