using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium115";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 114.94748d;

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
    