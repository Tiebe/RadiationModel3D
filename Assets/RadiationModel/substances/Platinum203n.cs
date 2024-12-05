using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum203n : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum203n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 202.98058d;

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
    