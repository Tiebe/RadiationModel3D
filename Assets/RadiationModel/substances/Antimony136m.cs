using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony136m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony136m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 135.93104d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony136()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    