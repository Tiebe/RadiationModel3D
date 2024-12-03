using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lanthanum136m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum136m";
        public override double halfLife { get; } = 0.114d;
        public override double atomicWeight { get; } = 135.90791d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lanthanum136()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    