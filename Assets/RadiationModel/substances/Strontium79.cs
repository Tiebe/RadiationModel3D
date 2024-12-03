using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Strontium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium79";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 78.9297d;

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
    