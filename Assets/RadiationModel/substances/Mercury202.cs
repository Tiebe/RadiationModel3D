using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury202 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury202";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 201.97064d;

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
    