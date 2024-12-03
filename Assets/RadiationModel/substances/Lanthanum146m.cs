using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lanthanum146m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum146m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 145.92584d;

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
    