using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Sodium35 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium35";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 35.04061d;

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
    