using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium224";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 224.02335d;

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
    