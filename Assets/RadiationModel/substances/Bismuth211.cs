using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth211 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth211";
        public override double halfLife { get; } = 128.4d;
        public override double atomicWeight { get; } = 210.98727d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99724d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium207() }, { 1.0d, new AlphaParticle(7772002.09) }, { 0.13019999999999998d, new GammaParticle(351070.0, 0.00353) }, { 0.0093360162588d, new GammaParticle(12148.0, 0.10206) }, { 0.007250530205260422d, new GammaParticle(70832.0, 0.0175) }, { 0.012239247476806926d, new GammaParticle(72874.0, 0.01701) }, { 0.004162427461783081d, new GammaParticle(82629.0, 0.015) }, { 0.005398668417932656d, new GammaParticle(83631.0, 0.01483) }, { 0.001236240956149575d, new GammaParticle(84866.0, 0.01461) } } },
            { 0.0027600000000000003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium211() }, { 1.0d, new BetaParticle(-1, 286750.0) } } },

        };
    }
}
    