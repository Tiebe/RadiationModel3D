using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum179 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum179";
        public override double halfLife { get; } = 21.2d;
        public override double atomicWeight { get; } = 178.96536d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9976d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium179() }, { 1.0d, new BetaParticle(1, 5376000.0) }, { 0.026000000000000002d, new GammaParticle(93300.0, 0.01329) }, { 0.13d, new GammaParticle(99800.0, 0.01242) }, { 0.025d, new GammaParticle(106300.0, 0.01166) }, { 0.165d, new GammaParticle(171700.0, 0.00722) }, { 0.14300000000000002d, new GammaParticle(193100.0, 0.00642) }, { 0.025d, new GammaParticle(203300.0, 0.0061) }, { 0.067d, new GammaParticle(243200.0, 0.0051) }, { 0.053d, new GammaParticle(300000.0, 0.00413) }, { 0.033d, new GammaParticle(309000.0, 0.00401) }, { 0.067d, new GammaParticle(393300.0, 0.00315) }, { 0.053d, new GammaParticle(402400.0, 0.00308) }, { 0.079d, new GammaParticle(915300.0, 0.00135) }, { 0.11199999999999999d, new GammaParticle(1565400.0, 0.00079) }, { 1.212d, new GammaParticle(511000.0, 0.00243) }, { 0.3275316217283d, new GammaParticle(10728.0, 0.11557) }, { 0.18123290688071655d, new GammaParticle(63287.0, 0.01959) }, { 0.3110226649746294d, new GammaParticle(64896.0, 0.01911) }, { 0.10435971593503826d, new GammaParticle(73637.0, 0.01684) }, { 0.1338935155446541d, new GammaParticle(74510.0, 0.01664) }, { 0.029533799609615826d, new GammaParticle(75576.0, 0.01641) } } },
            { 0.0024d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium175() }, { 1.0d, new AlphaParticle(6434002.09) } } },

        };
    }
}
    