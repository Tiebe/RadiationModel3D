using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium168m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium168m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 167.93861d;

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
    