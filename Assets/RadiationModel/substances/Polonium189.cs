using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium189 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium189";
        public override double halfLife { get; } = 0.0035d;
        public override double atomicWeight { get; } = 188.99847d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead185()), new(1.0d, new AlphaParticle(8716002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    