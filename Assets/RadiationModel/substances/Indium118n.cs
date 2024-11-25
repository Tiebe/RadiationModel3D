using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium118n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium118n";
        public override double halfLife { get; } = 8.5d;
        public override double atomicWeight { get; } = 117.90661d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.986d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium118() }, { 0.2159d, new GammaParticle(138200.0, 0.00897) }, { 0.046573930728d, new GammaParticle(3571.0, 0.3472) }, { 0.10884522662025574d, new GammaParticle(24001.0, 0.05166) }, { 0.20421243268340664d, new GammaParticle(24209.0, 0.05121) }, { 0.05729744386246862d, new GammaParticle(27367.0, 0.0453) }, { 0.06818395819633766d, new GammaParticle(27581.0, 0.04495) }, { 0.010886514333869036d, new GammaParticle(27858.0, 0.04451) } } },
            { 0.013999999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin118() }, { 1.0d, new BetaParticle(-1, 2331400.0) }, { 0.0025d, new GammaParticle(41000.0, 0.03024) }, { 0.013000000000000001d, new GammaParticle(253678.0, 0.00489) }, { 0.013999999999999999d, new GammaParticle(1050690.0, 0.00118) }, { 0.00034d, new GammaParticle(1091510.0, 0.00114) }, { 0.013999999999999999d, new GammaParticle(1229640.0, 0.00101) }, { 0.00042463887088000003d, new GammaParticle(3753.0, 0.33036) }, { 0.001305274371267347d, new GammaParticle(25044.0, 0.04951) }, { 0.0024429615782656693d, new GammaParticle(25271.0, 0.04906) }, { 0.0006907776528546227d, new GammaParticle(28579.0, 0.04338) }, { 0.0008268608504669834d, new GammaParticle(28810.0, 0.04304) }, { 0.0001360831976123607d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    