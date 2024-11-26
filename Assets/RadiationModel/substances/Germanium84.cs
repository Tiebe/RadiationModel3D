using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium84";
        public override double halfLife { get; } = 0.954d;
        public override double atomicWeight { get; } = 83.93758d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic84()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.09881999999999999d, new GammaParticle(42700.0, 0.02904)), new(0.09638d, new GammaParticle(99900.0, 0.01241)), new(0.11224d, new GammaParticle(242400.0, 0.00511)), new(0.06466d, new GammaParticle(386000.0, 0.00321)) } },
            { 0.102d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic84()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.09881999999999999d, new GammaParticle(42700.0, 0.02904)), new(0.09638d, new GammaParticle(99900.0, 0.01241)), new(0.11224d, new GammaParticle(242400.0, 0.00511)), new(0.06466d, new GammaParticle(386000.0, 0.00321)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    