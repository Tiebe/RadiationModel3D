using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Argon38 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon38";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 37.96273d;

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
    