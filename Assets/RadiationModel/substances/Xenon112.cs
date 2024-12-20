using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon112 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon112";
        public override double halfLife { get; } = 2.7d;
        public override double atomicWeight { get; } = 111.93556d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.988d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium112()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.012d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium108()), new(1.0d, new AlphaParticle(4353002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    