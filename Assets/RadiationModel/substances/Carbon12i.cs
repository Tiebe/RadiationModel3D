using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Carbon12i : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon12i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 12.01622d;

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
    