using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Manganese50m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese50m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 49.95448d;

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
    