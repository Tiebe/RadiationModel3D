using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium121";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 120.91296d;

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
    