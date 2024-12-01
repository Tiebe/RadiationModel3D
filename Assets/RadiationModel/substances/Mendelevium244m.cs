using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium244m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium244m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 244.08137d;

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
    