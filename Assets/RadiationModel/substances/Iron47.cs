using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron47 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron47";
        public override double halfLife { get; } = 0.0218d;
        public override double atomicWeight { get; } = 46.99235d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium47()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium46()), new(1.0d, new ProtonParticle()), new(0.76d, new GammaParticle(892100.0, 0.00139)), new(0.22d, new GammaParticle(1094900.0, 0.00113)), new(0.035d, new GammaParticle(2304500.0, 0.00054)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    