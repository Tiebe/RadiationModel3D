using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon205 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon205";
        public override double halfLife { get; } = 170.0d;
        public override double atomicWeight { get; } = 204.99172d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.754d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium205()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.24600000000000002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium201()), new(1.0d, new AlphaParticle(7408002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    