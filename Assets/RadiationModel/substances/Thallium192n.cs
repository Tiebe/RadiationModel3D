using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium192n : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium192n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 191.97271d;

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
    