using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead212m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead212m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 211.99333d;

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
    