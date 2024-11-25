using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium53 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium53";
        public override double halfLife { get; } = 32.7d;
        public override double atomicWeight { get; } = 52.94967d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium53() }, { 1.0d, new BetaParticle(-1, 2485300.0) }, { 0.20298d, new GammaParticle(100800.0, 0.0123) }, { 0.45770000000000005d, new GammaParticle(127600.0, 0.00972) }, { 0.39799999999999996d, new GammaParticle(228400.0, 0.00543) }, { 0.040198d, new GammaParticle(679600.0, 0.00182) }, { 0.044974d, new GammaParticle(1001000.0, 0.00124) }, { 0.025472d, new GammaParticle(1033100.0, 0.0012) }, { 0.059699999999999996d, new GammaParticle(1321100.0, 0.00094) }, { 0.10746d, new GammaParticle(1421700.0, 0.00087) }, { 0.25074d, new GammaParticle(1675500.0, 0.00074) }, { 0.048158000000000006d, new GammaParticle(1729200.0, 0.00072) }, { 0.04059599999999999d, new GammaParticle(1776500.0, 0.0007) }, { 0.032238d, new GammaParticle(1855500.0, 0.00067) }, { 0.12337999999999999d, new GammaParticle(1904000.0, 0.00065) }, { 0.034626000000000004d, new GammaParticle(1956400.0, 0.00063) }, { 0.030646d, new GammaParticle(2355500.0, 0.00053) }, { 0.053332d, new GammaParticle(2456600.0, 0.0005) }, { 0.061689999999999995d, new GammaParticle(2601000.0, 0.00048) }, { 0.009552d, new GammaParticle(2702000.0, 0.00046) }, { 0.028656d, new GammaParticle(2702000.0, 0.00046) }, { 0.020297999999999997d, new GammaParticle(2829100.0, 0.00044) }, { 8.998560864742201e-05d, new GammaParticle(536.0, 2.31314) }, { 0.0011011385661160531d, new GammaParticle(4945.0, 0.25073) }, { 0.002166316281951708d, new GammaParticle(4952.0, 0.25037) }, { 0.00043587847673223925d, new GammaParticle(5444.0, 0.22774) }, { 0.00043587847673223925d, new GammaParticle(5444.0, 0.22774) } } },

        };
    }
}
    