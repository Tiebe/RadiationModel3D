using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chromium42 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium42";
        public override double halfLife { get; } = 0.0133d;
        public override double atomicWeight { get; } = 42.00758d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Titanium42()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.9440000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Titanium41()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    