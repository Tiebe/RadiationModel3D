using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony107 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony107";
        public override double halfLife { get; } = 4.0d;
        public override double atomicWeight { get; } = 106.92415d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium107() }, { 1.0d, new BetaParticle(1, 6457000.0) }, { 0.1408d, new GammaParticle(151500.0, 0.00818) }, { 0.0066d, new GammaParticle(552700.0, 0.00224) }, { 0.1386d, new GammaParticle(666600.0, 0.00186) }, { 0.0748d, new GammaParticle(703500.0, 0.00176) }, { 0.0748d, new GammaParticle(818200.0, 0.00152) }, { 0.019799999999999998d, new GammaParticle(819400.0, 0.00151) }, { 0.0968d, new GammaParticle(970200.0, 0.00128) }, { 0.22d, new GammaParticle(1280100.0, 0.00097) }, { 0.08800000000000001d, new GammaParticle(1453900.0, 0.00085) }, { 0.022000000000000002d, new GammaParticle(1619500.0, 0.00077) }, { 0.0154d, new GammaParticle(2045500.0, 0.00061) }, { 1.974d, new GammaParticle(511000.0, 0.00243) }, { 0.0019d, new GammaParticle(3753.0, 0.33036) }, { 0.0059d, new GammaParticle(25044.0, 0.04951) }, { 0.0111d, new GammaParticle(25271.0, 0.04906) }, { 0.0031d, new GammaParticle(28579.0, 0.04338) }, { 0.0038d, new GammaParticle(28810.0, 0.04304) }, { 0.00062d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    