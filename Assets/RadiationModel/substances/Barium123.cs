using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium123";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 122.91878d;

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
    