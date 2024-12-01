using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium188 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium188";
        public override double halfLife { get; } = 0.00027d;
        public override double atomicWeight { get; } = 187.99942d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead184()), new(1.0d, new AlphaParticle(9105002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    