using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iron67 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron67";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 66.95093d;

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
    