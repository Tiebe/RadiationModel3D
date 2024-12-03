using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium191m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium191m";
        public override double halfLife { get; } = 47160.0d;
        public override double atomicWeight { get; } = 190.96101d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium191()), new(0.000607d, new GammaParticle(74380.0, 0.01667)), new(0.203408128d, new GammaParticle(10393.0, 0.1193)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    