using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Sodium26m : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium26m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 25.99272d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Sodium26()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    