using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Roentgenium278 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium278";
        public override double halfLife { get; } = 0.0042d;
        public override double atomicWeight { get; } = 278.16159d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Meitnerium274()), new(1.0d, new AlphaParticle(11867002.09)) } },
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
    