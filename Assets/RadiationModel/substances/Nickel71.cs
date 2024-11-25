using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel71 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel71";
        public override double halfLife { get; } = 2.56d;
        public override double atomicWeight { get; } = 70.94052d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper71() }, { 1.0d, new BetaParticle(-1, 3652450.0) }, { 0.0174d, new GammaParticle(161400.0, 0.00768) }, { 0.015d, new GammaParticle(206100.0, 0.00602) }, { 0.0192d, new GammaParticle(348100.0, 0.00356) }, { 0.0582d, new GammaParticle(446900.0, 0.00277) }, { 0.135d, new GammaParticle(472000.0, 0.00263) }, { 0.016200000000000003d, new GammaParticle(520200.0, 0.00238) }, { 0.6d, new GammaParticle(534400.0, 0.00232) }, { 0.0192d, new GammaParticle(655100.0, 0.00189) }, { 0.0108d, new GammaParticle(705700.0, 0.00176) }, { 0.0132d, new GammaParticle(744700.0, 0.00166) }, { 0.0276d, new GammaParticle(939500.0, 0.00132) }, { 0.19260000000000002d, new GammaParticle(981300.0, 0.00126) }, { 0.0492d, new GammaParticle(1019000.0, 0.00122) }, { 0.015d, new GammaParticle(1138900.0, 0.00109) }, { 0.2004d, new GammaParticle(1189500.0, 0.00104) }, { 0.0702d, new GammaParticle(1248200.0, 0.00099) }, { 0.21660000000000001d, new GammaParticle(1251700.0, 0.00099) }, { 0.0084d, new GammaParticle(1297800.0, 0.00096) }, { 0.0294d, new GammaParticle(1311300.0, 0.00095) }, { 0.0588d, new GammaParticle(1352600.0, 0.00092) }, { 0.06d, new GammaParticle(1410400.0, 0.00088) }, { 0.039599999999999996d, new GammaParticle(1497100.0, 0.00083) }, { 0.0216d, new GammaParticle(1581000.0, 0.00078) }, { 0.0462d, new GammaParticle(1885900.0, 0.00066) }, { 0.2202d, new GammaParticle(2017000.0, 0.00061) } } },

        };
    }
}
    