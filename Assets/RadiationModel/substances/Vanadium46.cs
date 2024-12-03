using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium46 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium46";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 45.9602d;

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
    