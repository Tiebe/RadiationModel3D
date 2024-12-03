using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver110m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver110m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 109.90611d;

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
    