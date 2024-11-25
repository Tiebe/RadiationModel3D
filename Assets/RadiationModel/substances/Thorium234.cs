using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium234";
        public override double halfLife { get; } = 2082240.0d;
        public override double atomicWeight { get; } = 234.0436d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium234() }, { 1.0d, new BetaParticle(-1, 137000.0) }, { 5e-05d, new GammaParticle(20020.0, 0.06193) }, { 1.1999999999999999e-05d, new GammaParticle(29490.0, 0.04204) }, { 5e-05d, new GammaParticle(57750.0, 0.02147) }, { 0.00016d, new GammaParticle(62860.0, 0.01972) }, { 0.03665d, new GammaParticle(63290.0, 0.01959) }, { 0.00013d, new GammaParticle(73920.0, 0.01677) }, { 0.0006d, new GammaParticle(83300.0, 0.01488) }, { 0.000145d, new GammaParticle(87020.0, 0.01425) }, { 0.0213d, new GammaParticle(92380.0, 0.01342) }, { 0.021d, new GammaParticle(92800.0, 0.01336) }, { 3.15e-05d, new GammaParticle(103350.0, 0.012) }, { 8e-05d, new GammaParticle(108000.0, 0.01148) }, { 0.0021d, new GammaParticle(112810.0, 0.01099) }, { 0.0001d, new GammaParticle(184800.0, 0.00671) }, { 0.07200000000000001d, new GammaParticle(16228.0, 0.0764) }, { 8.999999999999999e-05d, new GammaParticle(92282.0, 0.01344) }, { 0.00014000000000000001d, new GammaParticle(95865.0, 0.01293) }, { 5e-05d, new GammaParticle(108373.0, 0.01144) }, { 7.000000000000001e-05d, new GammaParticle(109740.0, 0.0113) }, { 1.7e-05d, new GammaParticle(111482.0, 0.01112) } } },

        };
    }
}
    