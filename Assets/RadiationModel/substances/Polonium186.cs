using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium186";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 186.0044d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead182()), new(1.0d, new AlphaParticle(9524002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    