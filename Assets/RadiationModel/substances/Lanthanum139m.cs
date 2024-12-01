using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lanthanum139m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum139m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 138.9083d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lanthanum139()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    