using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury181 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury181";
        public override double halfLife { get; } = 3.6d;
        public override double atomicWeight { get; } = 180.97782d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.73d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum181()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.27d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum177()), new(1.0d, new AlphaParticle(7306002.09)) } },
            { 0.00013d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum180()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    