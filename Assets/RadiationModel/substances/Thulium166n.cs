using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium166n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium166n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 165.93382d;

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
    