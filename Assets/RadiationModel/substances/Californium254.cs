using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Californium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium254";
        public override double halfLife { get; } = 5227200.0d;
        public override double atomicWeight { get; } = 254.08732d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9969d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.0031d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium250()), new(1.0d, new AlphaParticle(6948002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    