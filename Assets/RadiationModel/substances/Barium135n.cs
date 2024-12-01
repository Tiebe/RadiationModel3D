using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium135n : RadioactiveSubstance
    {
        public override string name { get; } = "Barium135n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 134.90825d;

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
    