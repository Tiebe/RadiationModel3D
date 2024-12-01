using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bohrium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium261";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 261.1214d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.95d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dubnium257()), new(1.0d, new AlphaParticle(11527002.09)) } },
            { 0.1d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    