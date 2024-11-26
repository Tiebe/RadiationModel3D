using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium63";
        public override double halfLife { get; } = 0.0196d;
        public override double atomicWeight { get; } = 62.97666d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium63()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.04d, new GammaParticle(83100.0, 0.01492)), new(0.15d, new GammaParticle(120300.0, 0.01031)), new(0.04d, new GammaParticle(414000.0, 0.00299)) } },
            { 0.29d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium63()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.04d, new GammaParticle(83100.0, 0.01492)), new(0.15d, new GammaParticle(120300.0, 0.01031)), new(0.04d, new GammaParticle(414000.0, 0.00299)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    