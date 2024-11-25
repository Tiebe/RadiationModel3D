using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium90";
        public override double halfLife { get; } = 49.2d;
        public override double atomicWeight { get; } = 89.92407d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum90() }, { 0.052000000000000005d, new GammaParticle(134600.0, 0.00921) }, { 0.0268d, new GammaParticle(231200.0, 0.00536) }, { 0.013000000000000001d, new GammaParticle(262500.0, 0.00472) }, { 0.026000000000000002d, new GammaParticle(310300.0, 0.004) }, { 0.136d, new GammaParticle(481700.0, 0.00257) }, { 0.042d, new GammaParticle(543400.0, 0.00228) }, { 0.09300000000000001d, new GammaParticle(546800.0, 0.00227) }, { 0.012d, new GammaParticle(592900.0, 0.00209) }, { 0.027999999999999997d, new GammaParticle(801200.0, 0.00155) }, { 0.34299999999999997d, new GammaParticle(809800.0, 0.00153) }, { 0.366d, new GammaParticle(944700.0, 0.00131) }, { 1.0d, new GammaParticle(948100.0, 0.00131) }, { 0.054000000000000006d, new GammaParticle(983500.0, 0.00126) }, { 0.011000000000000001d, new GammaParticle(1035500.0, 0.0012) }, { 1.0d, new GammaParticle(1054300.0, 0.00118) }, { 0.017d, new GammaParticle(1147900.0, 0.00108) }, { 0.073d, new GammaParticle(1291400.0, 0.00096) }, { 0.036000000000000004d, new GammaParticle(1363700.0, 0.00091) }, { 0.019d, new GammaParticle(2091700.0, 0.00059) }, { 0.006999999999999999d, new GammaParticle(2355300.0, 0.00053) }, { 1.964d, new GammaParticle(511000.0, 0.00243) }, { 0.00077d, new GammaParticle(2440.0, 0.50813) }, { 0.0039000000000000003d, new GammaParticle(17374.0, 0.07136) }, { 0.0074d, new GammaParticle(17479.0, 0.07093) }, { 0.0019500000000000001d, new GammaParticle(19681.0, 0.063) }, { 0.0022500000000000003d, new GammaParticle(19794.0, 0.06264) }, { 0.0003d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    