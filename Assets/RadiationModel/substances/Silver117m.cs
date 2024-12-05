using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver117m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver117m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 116.91181d;

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
    