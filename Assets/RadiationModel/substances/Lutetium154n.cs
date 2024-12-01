using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium154n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium154n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 153.96033d;

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
    