using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium97";
        public override double halfLife { get; } = 3.75d;
        public override double atomicWeight { get; } = 96.91829d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium97() }, { 1.0d, new BetaParticle(-1, 3410845.0) }, { 0.00362d, new GammaParticle(161400.0, 0.00768) }, { 0.002896d, new GammaParticle(189600.0, 0.00654) }, { 0.012669999999999999d, new GammaParticle(296880.0, 0.00418) }, { 0.00905d, new GammaParticle(544800.0, 0.00228) }, { 0.00362d, new GammaParticle(594700.0, 0.00208) }, { 0.010860000000000002d, new GammaParticle(756000.0, 0.00164) }, { 0.050679999999999996d, new GammaParticle(1103000.0, 0.00112) }, { 0.00181d, new GammaParticle(1264200.0, 0.00098) }, { 0.05792d, new GammaParticle(1291200.0, 0.00096) }, { 0.00905d, new GammaParticle(1344000.0, 0.00092) }, { 0.045250000000000005d, new GammaParticle(1400000.0, 0.00089) }, { 0.00724d, new GammaParticle(1428900.0, 0.00087) }, { 0.008326d, new GammaParticle(1639800.0, 0.00076) }, { 0.018643d, new GammaParticle(1887400.0, 0.00066) }, { 0.07421d, new GammaParticle(1996600.0, 0.00062) }, { 0.009412d, new GammaParticle(2057300.0, 0.0006) }, { 0.06516d, new GammaParticle(2743100.0, 0.00045) }, { 0.18100000000000002d, new GammaParticle(3287600.0, 0.00038) }, { 0.14118d, new GammaParticle(3401300.0, 0.00036) }, { 0.031132d, new GammaParticle(3549500.0, 0.00035) }, { 2.3999999999999997e-05d, new GammaParticle(2161.0, 0.57374) }, { 0.00013d, new GammaParticle(15691.0, 0.07902) }, { 0.00025d, new GammaParticle(15775.0, 0.0786) }, { 6e-05d, new GammaParticle(17736.0, 0.06991) }, { 7.000000000000001e-05d, new GammaParticle(17824.0, 0.06956) }, { 9e-06d, new GammaParticle(17968.0, 0.069) } } },
            { 0.00055d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium97() }, { 1.0d, new BetaParticle(-1, 3410845.0) }, { 0.00362d, new GammaParticle(161400.0, 0.00768) }, { 0.002896d, new GammaParticle(189600.0, 0.00654) }, { 0.012669999999999999d, new GammaParticle(296880.0, 0.00418) }, { 0.00905d, new GammaParticle(544800.0, 0.00228) }, { 0.00362d, new GammaParticle(594700.0, 0.00208) }, { 0.010860000000000002d, new GammaParticle(756000.0, 0.00164) }, { 0.050679999999999996d, new GammaParticle(1103000.0, 0.00112) }, { 0.00181d, new GammaParticle(1264200.0, 0.00098) }, { 0.05792d, new GammaParticle(1291200.0, 0.00096) }, { 0.00905d, new GammaParticle(1344000.0, 0.00092) }, { 0.045250000000000005d, new GammaParticle(1400000.0, 0.00089) }, { 0.00724d, new GammaParticle(1428900.0, 0.00087) }, { 0.008326d, new GammaParticle(1639800.0, 0.00076) }, { 0.018643d, new GammaParticle(1887400.0, 0.00066) }, { 0.07421d, new GammaParticle(1996600.0, 0.00062) }, { 0.009412d, new GammaParticle(2057300.0, 0.0006) }, { 0.06516d, new GammaParticle(2743100.0, 0.00045) }, { 0.18100000000000002d, new GammaParticle(3287600.0, 0.00038) }, { 0.14118d, new GammaParticle(3401300.0, 0.00036) }, { 0.031132d, new GammaParticle(3549500.0, 0.00035) }, { 2.3999999999999997e-05d, new GammaParticle(2161.0, 0.57374) }, { 0.00013d, new GammaParticle(15691.0, 0.07902) }, { 0.00025d, new GammaParticle(15775.0, 0.0786) }, { 6e-05d, new GammaParticle(17736.0, 0.06991) }, { 7.000000000000001e-05d, new GammaParticle(17824.0, 0.06956) }, { 9e-06d, new GammaParticle(17968.0, 0.069) } } },

        };
    }
}
    