using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Manganese67 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese67";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 66.96395d;

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
    