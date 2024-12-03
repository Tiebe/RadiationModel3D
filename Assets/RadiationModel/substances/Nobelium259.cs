using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium259 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium259";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 259.101d;

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
    