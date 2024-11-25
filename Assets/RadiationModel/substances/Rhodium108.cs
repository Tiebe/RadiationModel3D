using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium108";
        public override double halfLife { get; } = 16.8d;
        public override double atomicWeight { get; } = 107.90872d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium108() }, { 1.0d, new BetaParticle(-1, 2246600.0) }, { 0.05261999999999999d, new GammaParticle(327600.0, 0.00378) }, { 0.2631d, new GammaParticle(404300.0, 0.00307) }, { 0.43d, new GammaParticle(434100.0, 0.00286) }, { 0.877d, new GammaParticle(434200.0, 0.00286) }, { 0.05261999999999999d, new GammaParticle(437600.0, 0.00283) }, { 0.0516d, new GammaParticle(497300.0, 0.00249) }, { 0.19294d, new GammaParticle(497400.0, 0.00249) }, { 0.59636d, new GammaParticle(581100.0, 0.00213) }, { 0.21047999999999997d, new GammaParticle(614300.0, 0.00202) }, { 0.1505d, new GammaParticle(618900.0, 0.002) }, { 0.10523999999999999d, new GammaParticle(723300.0, 0.00171) }, { 0.28064d, new GammaParticle(901300.0, 0.00138) }, { 0.12278d, new GammaParticle(931600.0, 0.00133) }, { 0.012470000000000002d, new GammaParticle(931700.0, 0.00133) }, { 0.49112d, new GammaParticle(947500.0, 0.00131) }, { 0.04385d, new GammaParticle(1092500.0, 0.00113) }, { 0.0877d, new GammaParticle(1234300.0, 0.001) }, { 0.2631d, new GammaParticle(2102200.0, 0.00059) }, { 4.20256212126e-05d, new GammaParticle(3053.0, 0.40611) }, { 0.00016729094649348415d, new GammaParticle(21020.0, 0.05898) }, { 0.00031606073397597614d, new GammaParticle(21177.0, 0.05855) }, { 8.671411771841004e-05d, new GammaParticle(23904.0, 0.05187) }, { 0.00010145551773053972d, new GammaParticle(24070.0, 0.05151) }, { 1.4741400012129706e-05d, new GammaParticle(24297.0, 0.05103) } } },

        };
    }
}
    