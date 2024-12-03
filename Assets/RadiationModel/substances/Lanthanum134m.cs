using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lanthanum134m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum134m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 133.90898d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lanthanum134()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    