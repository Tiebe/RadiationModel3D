using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iron45 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron45";
        public override double halfLife { get; } = 0.00189d;
        public override double atomicWeight { get; } = 45.01547d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.57d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium43()), new(1.0d, new ProtonParticle()) } },
            { 0.43d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium45()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.43d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium44()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    