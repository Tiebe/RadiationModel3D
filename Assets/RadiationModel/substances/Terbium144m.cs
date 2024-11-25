using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium144m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium144m";
        public override double halfLife { get; } = 4.25d;
        public override double atomicWeight { get; } = 143.93347d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.66d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium144() }, { 0.027999999999999997d, new GammaParticle(113000.0, 0.01097) }, { 0.66d, new GammaParticle(283900.0, 0.00437) }, { 0.09853605712800001d, new GammaParticle(7118.0, 0.17418) }, { 0.03237775634661611d, new GammaParticle(43743.0, 0.02834) }, { 0.05805586578199051d, new GammaParticle(44481.0, 0.02787) }, { 0.018539251684982824d, new GammaParticle(50494.0, 0.02455) }, { 0.023340917871393373d, new GammaParticle(51040.0, 0.02429) }, { 0.0048016661864105515d, new GammaParticle(51699.0, 0.02398) } } },
            { 0.34d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium144() }, { 1.0d, new BetaParticle(1, 6824000.0) } } },

        };
    }
}
    