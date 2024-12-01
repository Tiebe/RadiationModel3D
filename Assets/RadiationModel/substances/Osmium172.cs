using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium172";
        public override double halfLife { get; } = 19.2d;
        public override double atomicWeight { get; } = 171.96002d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.998d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten172()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten168()), new(1.0d, new AlphaParticle(6246002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    