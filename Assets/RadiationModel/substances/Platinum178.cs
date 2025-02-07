using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum178 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum178";
        public override double halfLife { get; } = 20.7d;
        public override double atomicWeight { get; } = 177.96565d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9229999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium178()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.077d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium174()), new(1.0d, new AlphaParticle(6595002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    