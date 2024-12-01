using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium186";
        public override double halfLife { get; } = 6.3113851949184e+22d;
        public override double atomicWeight { get; } = 185.95384d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten182()), new(1.0d, new AlphaParticle(3843102.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    