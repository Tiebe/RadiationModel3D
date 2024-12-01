using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Argon38j : RadioactiveSubstance
    {
        public override string name { get; } = "Argon38j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 37.98289d;

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
    