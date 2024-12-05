using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver102 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver102";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 101.9117d;

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
    