using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon134n : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon134n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 133.90864d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon134()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    