using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead181 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead181";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 180.99666d;

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
    