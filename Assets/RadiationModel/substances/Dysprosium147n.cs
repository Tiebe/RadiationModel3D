using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium147n : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium147n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 146.93474d;

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
    