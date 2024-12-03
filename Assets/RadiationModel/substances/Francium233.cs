using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium233";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 233.05252d;

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
    