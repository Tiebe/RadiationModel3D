using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hassium265m : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium265m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 265.13004d;

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
    