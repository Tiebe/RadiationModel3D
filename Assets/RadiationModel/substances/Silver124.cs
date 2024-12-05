using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver124 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver124";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 123.9289d;

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
    