using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium261p : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium261p";
        public override double halfLife { get; } = 1.9d;
        public override double atomicWeight { get; } = 261.10902d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.73d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.27d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium257()), new(1.0d, new AlphaParticle(9900002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    