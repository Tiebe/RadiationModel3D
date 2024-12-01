using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver94m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver94m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 93.9452d;

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
    