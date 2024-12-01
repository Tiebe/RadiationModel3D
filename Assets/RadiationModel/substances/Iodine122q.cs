using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine122q : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine122q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 121.90807d;

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
    