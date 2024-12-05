using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium204 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium204";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 204.00065d;

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
    