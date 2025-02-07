using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Curium247n : RadioactiveSubstance
    {
        public override string name { get; } = "Curium247n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 247.07079d;

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
    