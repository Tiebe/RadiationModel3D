using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chromium43 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium43";
        public override double halfLife { get; } = 0.0212d;
        public override double atomicWeight { get; } = 42.99789d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Titanium43()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.7929999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Titanium42()), new(1.0d, new ProtonParticle()), new(0.049d, new GammaParticle(838400.0, 0.00148)), new(0.278d, new GammaParticle(1554600.0, 0.0008)), new(0.013999999999999999d, new GammaParticle(1936800.0, 0.00064)) } },
            { 0.11599999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Scandium41()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    