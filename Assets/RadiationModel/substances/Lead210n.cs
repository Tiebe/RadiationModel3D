using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead210n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead210n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 209.98556d;

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
    