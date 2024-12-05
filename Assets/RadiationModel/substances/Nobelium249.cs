using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium249";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 249.08781d;

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
    