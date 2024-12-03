using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper56i : RadioactiveSubstance
    {
        public override string name { get; } = "Copper56i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 55.96232d;

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
    