using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium140";
        public override double halfLife { get; } = 203.4d;
        public override double atomicWeight { get; } = 139.90909d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum140() }, { 1.0d, new BetaParticle(1, -186950.0) }, { 0.00147d, new GammaParticle(306900.0, 0.00404) }, { 0.0003136d, new GammaParticle(751800.0, 0.00165) }, { 0.0002548d, new GammaParticle(925300.0, 0.00134) }, { 1.176e-05d, new GammaParticle(950987.0, 0.0013) }, { 1.225e-06d, new GammaParticle(1303500.0, 0.00095) }, { 6.37e-05d, new GammaParticle(1420700.0, 0.00087) }, { 0.0049d, new GammaParticle(1596100.0, 0.00078) }, { 7.105e-05d, new GammaParticle(2347800.0, 0.00053) }, { 0.0001274d, new GammaParticle(2521400.0, 0.00049) }, { 2.303e-06d, new GammaParticle(2547500.0, 0.00049) }, { 1.96e-06d, new GammaParticle(2900000.0, 0.00043) }, { 8.33e-06d, new GammaParticle(3119000.0, 0.0004) }, { 5.39e-07d, new GammaParticle(3320000.0, 0.00037) }, { 1.0201532d, new GammaParticle(511000.0, 0.00243) }, { 0.052789238181982084d, new GammaParticle(5410.0, 0.22918) }, { 0.10751597509883297d, new GammaParticle(34279.0, 0.03617) }, { 0.1969157053092179d, new GammaParticle(34720.0, 0.03571) }, { 0.05930834092797993d, new GammaParticle(39366.0, 0.0315) }, { 0.07437265952368684d, new GammaParticle(39753.0, 0.03119) }, { 0.015064318595706902d, new GammaParticle(40229.0, 0.03082) } } },

        };
    }
}
    