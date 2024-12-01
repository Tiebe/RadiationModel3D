using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Meitnerium274 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium274";
        public override double halfLife { get; } = 0.44d;
        public override double atomicWeight { get; } = 274.14734d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bohrium270()), new(1.0d, new AlphaParticle(11617002.09)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    